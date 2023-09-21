# This file was generated for the RSC PowerShell SDK
param(
    [switch]$GetGqlRequest
)

. "${PSScriptRoot}/../Utils/import.ps1"
. "${PSScriptRoot}/SampleUtils.ps1"

if ($GetGqlRequest) {
    $gqlDir = "gql"

    # Check if the directory exists
    if (-Not (Test-Path -Path $gqlDir -PathType Container)) {
        # Create the directory if it doesn't exist
        New-Item -Path $gqlDir -ItemType Directory
    }

    # Change to the directory
    Set-Location -Path $gqlDir
}

# -------------------------------------------------------------------
# New-RscMutationActivitySeries -Cancel
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationActivitySeries -Cancel).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationActivitySeries -Cancel
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	activitySeriesId = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscMutationActivitySeries -Cancel" @"
    Cancel an activity series.
"@ "[GraphQL: cancelActivitySeries]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationAws -StartNativeEc2InstanceSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartNativeEc2InstanceSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartNativeEc2InstanceSnapshotsJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	ec2InstanceIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}
"@
    Write-Message "New-RscMutationAws -StartNativeEc2InstanceSnapshotsJob" @"
    Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.
"@ "[GraphQL: startAwsNativeEc2InstanceSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartRestoreNativeEc2InstanceSnapshotJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartRestoreNativeEc2InstanceSnapshotJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartRestoreNativeEc2InstanceSnapshotJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	shouldPowerOn = <System.Boolean>
	# REQUIRED
	shouldRestoreTags = <System.Boolean>
	# OPTIONAL
	snapshotTypeToUseIfSourceExpired = <SnapshotTypeToUseIfSourceExpired> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnapshotTypeToUseIfSourceExpired]) for enum values.
}
"@
    Write-Message "New-RscMutationAws -StartRestoreNativeEc2InstanceSnapshotJob" @"
    Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.
"@ "[GraphQL: startRestoreAwsNativeEc2InstanceSnapshotJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartRefreshNativeAccountsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartRefreshNativeAccountsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartRefreshNativeAccountsJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsAccountRubrikIds = @(
		<System.String>
	)
	# REQUIRED
	awsNativeProtectionFeatures = @(
		<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
	)
}
"@
    Write-Message "New-RscMutationAws -StartRefreshNativeAccountsJob" @"
    Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.
"@ "[GraphQL: startRefreshAwsNativeAccountsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartCreateNativeEbsVolumeSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartCreateNativeEbsVolumeSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartCreateNativeEbsVolumeSnapshotsJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	ebsVolumeIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}
"@
    Write-Message "New-RscMutationAws -StartCreateNativeEbsVolumeSnapshotsJob" @"
    Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.
"@ "[GraphQL: startCreateAwsNativeEbsVolumeSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartNativeAccountDisableJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartNativeAccountDisableJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartNativeAccountDisableJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsAccountRubrikId = <System.String>
	# REQUIRED
	shouldDeleteNativeSnapshots = <System.Boolean>
	# REQUIRED
	awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
}
"@
    Write-Message "New-RscMutationAws -StartNativeAccountDisableJob" @"
    Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.
"@ "[GraphQL: startAwsNativeAccountDisableJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartExportNativeEbsVolumeSnapshotJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartExportNativeEbsVolumeSnapshotJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartExportNativeEbsVolumeSnapshotJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
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
}
"@
    Write-Message "New-RscMutationAws -StartExportNativeEbsVolumeSnapshotJob" @"
    Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.
"@ "[GraphQL: startExportAwsNativeEbsVolumeSnapshotJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -ExcludeNativeEbsVolumesFromSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -ExcludeNativeEbsVolumesFromSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -ExcludeNativeEbsVolumesFromSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsNativeEc2InstanceId = <System.String>
	# REQUIRED
	volumeIdExclusions = @(
		@{
			# REQUIRED
			volumeId = <System.String>
			# REQUIRED
			isExcluded = <System.Boolean>
		}
	)
}
"@
    Write-Message "New-RscMutationAws -ExcludeNativeEbsVolumesFromSnapshot" @"
    Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.
"@ "[GraphQL: excludeAwsNativeEbsVolumesFromSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartNativeRdsInstanceSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartNativeRdsInstanceSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartNativeRdsInstanceSnapshotsJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	rdsInstanceIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}
"@
    Write-Message "New-RscMutationAws -StartNativeRdsInstanceSnapshotsJob" @"
    Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.
"@ "[GraphQL: startAwsNativeRdsInstanceSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	secretKey = <System.String>
}
"@
    Write-Message "New-RscMutationAws -CreateAccount" @"
    
"@ "[GraphQL: createAwsAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	secretKey = <System.String>
}
"@
    Write-Message "New-RscMutationAws -UpdateAccount" @"
    
"@ "[GraphQL: updateAwsAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateAutomaticTargetMapping
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	bucketPrefix = <System.String>
	# REQUIRED
	storageClass = <AwsStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# REQUIRED
	region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = <System.String>
	# OPTIONAL
	rsaKey = <System.String>
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	clusterUuidList = @(
		<System.String>
	)
	# OPTIONAL
	awsComputeSettingsId = <System.String>
}
"@
    Write-Message "New-RscMutationAws -CreateAutomaticTargetMapping" @"
    
"@ "[GraphQL: createAutomaticAwsTargetMapping]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateCloudNativeStorageSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	bucketPrefix = <System.String>
	# REQUIRED
	storageClass = <AwsStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# OPTIONAL
	region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = <System.String>
	# REQUIRED
	cloudNativeLocTemplateType = <CloudNativeLocTemplateType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
	# OPTIONAL
	bucketTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = <System.String>
				# REQUIRED
				value = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationAws -CreateCloudNativeStorageSetting" @"
    
"@ "[GraphQL: createCloudNativeAwsStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateAutomaticTargetMapping
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	storageClass = <AwsStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# OPTIONAL
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	clusterUuidList = @(
		<System.String>
	)
	# OPTIONAL
	awsComputeSettingsId = <System.String>
}
"@
    Write-Message "New-RscMutationAws -UpdateAutomaticTargetMapping" @"
    
"@ "[GraphQL: updateAutomaticAwsTargetMapping]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateCloudNativeStorageSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	storageClass = <AwsStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = <System.String>
}
"@
    Write-Message "New-RscMutationAws -UpdateCloudNativeStorageSetting" @"
    
"@ "[GraphQL: updateCloudNativeAwsStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateTarget
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	bucketName = <System.String>
	# REQUIRED
	storageClass = <AwsStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# REQUIRED
	region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = <System.String>
	# OPTIONAL
	rsaKey = <System.String>
	# OPTIONAL
	encryptionPassword = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	awsComputeSettingsId = <System.String>
	# OPTIONAL
	cloudComputeSettings = @{
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		vpcId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
	}
	# OPTIONAL
	computeProxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	awsRetrievalTier = <AwsRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# OPTIONAL
	s3Endpoint = <System.String>
	# OPTIONAL
	kmsEndpoint = <System.String>
	# REQUIRED
	bypassProxy = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAws -CreateTarget" @"
    
"@ "[GraphQL: createAwsTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateTarget
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	storageClass = <AwsStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# OPTIONAL
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	awsComputeSettingsId = <System.String>
	# OPTIONAL
	cloudComputeSettings = @{
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		vpcId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
	}
	# OPTIONAL
	computeProxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	awsRetrievalTier = <AwsRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# OPTIONAL
	s3Endpoint = <System.String>
	# OPTIONAL
	kmsEndpoint = <System.String>
	# OPTIONAL
	bypassProxy = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAws -UpdateTarget" @"
    
"@ "[GraphQL: updateAwsTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateReaderTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateReaderTarget
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	bucketName = <System.String>
	# REQUIRED
	storageClass = <AwsStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsStorageClass]) for enum values.
	# REQUIRED
	region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	kmsMasterKeyId = <System.String>
	# OPTIONAL
	rsaKey = <System.String>
	# OPTIONAL
	encryptionPassword = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	awsComputeSettingsId = <System.String>
	# OPTIONAL
	cloudComputeSettings = @{
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		vpcId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
	}
	# OPTIONAL
	awsRetrievalTier = <AwsRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRetrievalTier]) for enum values.
	# REQUIRED
	readerRetrievalMethod = <ReaderRetrievalMethod> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# OPTIONAL
	s3Endpoint = <System.String>
	# OPTIONAL
	kmsEndpoint = <System.String>
	# OPTIONAL
	computeProxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# REQUIRED
	bypassProxy = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAws -CreateReaderTarget" @"
    Create a reader type for AWS archival location on a Rubrik cluster.
"@ "[GraphQL: createAwsReaderTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateComputeSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateComputeSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	subnetId = <System.String>
	# OPTIONAL
	vpcId = <System.String>
	# OPTIONAL
	securityGroupId = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
	# OPTIONAL
	isSecurityGroupPolarisManaged = <System.Boolean>
	# OPTIONAL
	clusterInterfaceCidrs = @(
		@{
			# OPTIONAL
			clusterName = <System.String>
			# OPTIONAL
			clusterId = <System.String>
			# OPTIONAL
			interfaceCidr = @(
				@{
					# OPTIONAL
					interfaceType = <InterfaceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InterfaceType]) for enum values.
					# OPTIONAL
					cidr = <System.String>
					# OPTIONAL
					selected = <System.Boolean>
				}
			)
		}
	)
}
"@
    Write-Message "New-RscMutationAws -CreateComputeSetting" @"
    
"@ "[GraphQL: createAwsComputeSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateComputeSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateComputeSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	subnetId = <System.String>
	# OPTIONAL
	vpcId = <System.String>
	# OPTIONAL
	securityGroupId = <System.String>
}
"@
    Write-Message "New-RscMutationAws -UpdateComputeSetting" @"
    
"@ "[GraphQL: updateAwsComputeSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -DeleteComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -DeleteComputeSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -DeleteComputeSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	id = <System.String>
}
"@
    Write-Message "New-RscMutationAws -DeleteComputeSetting" @"
    
"@ "[GraphQL: deleteAwsComputeSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -ValidateAndCreateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -ValidateAndCreateCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -ValidateAndCreateCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	action = <CloudAccountAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	awsAdminAccount = @{
		# OPTIONAL
		id = <System.String>
		# OPTIONAL
		nativeId = <System.String>
		# OPTIONAL
		accountName = <System.String>
		# OPTIONAL
		seamlessFlowEnabled = <System.Boolean>
		# OPTIONAL
		cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	}
	# REQUIRED
	awsChildAccounts = @(
		@{
			# OPTIONAL
			id = <System.String>
			# OPTIONAL
			nativeId = <System.String>
			# OPTIONAL
			accountName = <System.String>
			# OPTIONAL
			seamlessFlowEnabled = <System.Boolean>
			# OPTIONAL
			cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		}
	)
	# OPTIONAL
	awsRoleCustomization = @{
		# OPTIONAL
		crossAccountRoleName = <System.String>
		# OPTIONAL
		crossAccountRolePath = <System.String>
		# OPTIONAL
		masterRoleName = <System.String>
		# OPTIONAL
		masterRolePath = <System.String>
		# OPTIONAL
		workerRoleName = <System.String>
		# OPTIONAL
		workerRolePath = <System.String>
		# OPTIONAL
		instanceProfileName = <System.String>
		# OPTIONAL
		instanceProfilePath = <System.String>
		# OPTIONAL
		ec2RecoveryRolePath = <System.String>
	}
}
"@
    Write-Message "New-RscMutationAws -ValidateAndCreateCloudAccount" @"
    Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the ""message"" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.
"@ "[GraphQL: validateAndCreateAwsCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -FinalizeCloudAccountProtection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -FinalizeCloudAccountProtection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -FinalizeCloudAccountProtection
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	action = <CloudAccountAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	awsAdminAccount = @{
		# OPTIONAL
		id = <System.String>
		# OPTIONAL
		nativeId = <System.String>
		# OPTIONAL
		accountName = <System.String>
		# OPTIONAL
		seamlessFlowEnabled = <System.Boolean>
		# OPTIONAL
		cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	}
	# REQUIRED
	awsChildAccounts = @(
		@{
			# OPTIONAL
			id = <System.String>
			# OPTIONAL
			nativeId = <System.String>
			# OPTIONAL
			accountName = <System.String>
			# OPTIONAL
			seamlessFlowEnabled = <System.Boolean>
			# OPTIONAL
			cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		}
	)
	# OPTIONAL
	awsRegions = @(
		<AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	stackName = <System.String>
	# OPTIONAL
	stackSetName = <System.String>
	# OPTIONAL
	externalId = <System.String>
	# OPTIONAL
	featureVersion = @(
		@{
			# REQUIRED
			feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# REQUIRED
			version = <System.Int32>
		}
	)
}
"@
    Write-Message "New-RscMutationAws -FinalizeCloudAccountProtection" @"
    Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.
"@ "[GraphQL: finalizeAwsCloudAccountProtection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -PrepareCloudAccountDeletion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -PrepareCloudAccountDeletion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -PrepareCloudAccountDeletion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
}
"@
    Write-Message "New-RscMutationAws -PrepareCloudAccountDeletion" @"
    Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.
"@ "[GraphQL: prepareAwsCloudAccountDeletion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -FinalizeCloudAccountDeletion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -FinalizeCloudAccountDeletion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -FinalizeCloudAccountDeletion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
}
"@
    Write-Message "New-RscMutationAws -FinalizeCloudAccountDeletion" @"
    Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.
"@ "[GraphQL: finalizeAwsCloudAccountDeletion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateCloudAccountFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateCloudAccountFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateCloudAccountFeature
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	action = <CloudAccountAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRegions = @(
		<AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	roleArn = <System.String>
	# OPTIONAL
	stackArn = <System.String>
	# OPTIONAL
	awsAccountName = <System.String>
}
"@
    Write-Message "New-RscMutationAws -UpdateCloudAccountFeature" @"
    Updates regions, stack ARN, and role ARN for a feature for a given cloud account.
"@ "[GraphQL: updateAwsCloudAccountFeature]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# OPTIONAL
	awsAccountName = <System.String>
}
"@
    Write-Message "New-RscMutationAws -UpdateCloudAccount" @"
    Update properties for a given AWS cloud account.
"@ "[GraphQL: updateAwsCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -PrepareFeatureUpdateForCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -PrepareFeatureUpdateForCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -PrepareFeatureUpdateForCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}
"@
    Write-Message "New-RscMutationAws -PrepareFeatureUpdateForCloudAccount" @"
    Prepare manual update features to latest version.
"@ "[GraphQL: prepareFeatureUpdateForAwsCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateExocomputeConfigs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	configs = @(
		@{
			# REQUIRED
			region = <AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
			# OPTIONAL
			clusterSecurityGroupId = <System.String>
			# REQUIRED
			vpcId = <System.String>
			# OPTIONAL
			nodeSecurityGroupId = <System.String>
			# REQUIRED
			subnets = @(
				@{
					# REQUIRED
					subnetId = <System.String>
					# REQUIRED
					availabilityZone = <System.String>
				}
			)
			# REQUIRED
			isRscManaged = <System.Boolean>
		}
	)
	# OPTIONAL
	triggerHealthCheck = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAws -CreateExocomputeConfigs" @"
    Create AWS Exocompute configs.
"@ "[GraphQL: createAwsExocomputeConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -DeleteExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -DeleteExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -DeleteExocomputeConfigs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	configIdsToBeDeleted = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationAws -DeleteExocomputeConfigs" @"
    Deletes AWS Exocompute configs.
"@ "[GraphQL: deleteAwsExocomputeConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpdateExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpdateExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpdateExocomputeConfigs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	configs = @(
		@{
			# REQUIRED
			region = <AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
			# OPTIONAL
			clusterSecurityGroupId = <System.String>
			# REQUIRED
			vpcId = <System.String>
			# OPTIONAL
			nodeSecurityGroupId = <System.String>
			# REQUIRED
			subnets = @(
				@{
					# REQUIRED
					subnetId = <System.String>
					# REQUIRED
					availabilityZone = <System.String>
				}
			)
			# REQUIRED
			isRscManaged = <System.Boolean>
		}
	)
	# OPTIONAL
	triggerHealthCheck = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAws -UpdateExocomputeConfigs" @"
    Update AWS Exocompute configs.
"@ "[GraphQL: updateAwsExocomputeConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -StartExocomputeDisableJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -StartExocomputeDisableJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -StartExocomputeDisableJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
}
"@
    Write-Message "New-RscMutationAws -StartExocomputeDisableJob" @"
    Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.
"@ "[GraphQL: startAwsExocomputeDisableJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -AddIamUserBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -AddIamUserBasedCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -AddIamUserBasedCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	accessKey = <System.String>
	# OPTIONAL
	secretKey = <System.String>
	# REQUIRED
	nativeId = <System.String>
	# REQUIRED
	cloudAccountName = <System.String>
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# OPTIONAL
	awsRegions = @(
		<AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	roleArn = <System.String>
}
"@
    Write-Message "New-RscMutationAws -AddIamUserBasedCloudAccount" @"
    Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.
"@ "[GraphQL: addAwsIamUserBasedCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsCloudAccountId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}
"@
    Write-Message "New-RscMutationAws -UpgradeIamUserBasedCloudAccountPermissions" @"
    Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.
"@ "[GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsCloudAccountId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}
"@
    Write-Message "New-RscMutationAws -UpgradeCloudAccountFeaturesWithoutCft" @"
    Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.
"@ "[GraphQL: upgradeAwsCloudAccountFeaturesWithoutCft]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -AddAuthenticationServerBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -AddAuthenticationServerBasedCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -AddAuthenticationServerBasedCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	awsAccountName = <System.String>
	# OPTIONAL
	awsRegions = @(
		<AwsAuthServerBasedCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsAuthServerBasedCloudAccountRegion]) for enum values.
	)
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	nativeId = <System.String>
	# OPTIONAL
	agencyName = <System.String>
	# OPTIONAL
	roleName = <System.String>
	# OPTIONAL
	authServerHostName = <System.String>
	# OPTIONAL
	authServerUserClientCertId = @{
		# REQUIRED
		id = <System.Int64>
	}
	# OPTIONAL
	authServerCaCertId = @{
		# REQUIRED
		id = <System.Int64>
	}
	# OPTIONAL
	awsCaCertId = @{
		# REQUIRED
		id = <System.Int64>
	}
}
"@
    Write-Message "New-RscMutationAws -AddAuthenticationServerBasedCloudAccount" @"
    Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the ""message"" field of the response object.
"@ "[GraphQL: addAwsAuthenticationServerBasedCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsCloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRegions = @{
		# REQUIRED
		regions = @(
			<AwsAuthServerBasedCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsAuthServerBasedCloudAccountRegion]) for enum values.
		)
	}
	# OPTIONAL
	roleName = @{
		# REQUIRED
		name = <System.String>
	}
	# OPTIONAL
	authServerUserClientCertId = @{
		# REQUIRED
		id = <System.Int64>
	}
	# OPTIONAL
	authServerCaCertId = @{
		# REQUIRED
		id = <System.Int64>
	}
}
"@
    Write-Message "New-RscMutationAws -PatchAuthenticationServerBasedCloudAccount" @"
    Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
"@ "[GraphQL: patchAwsAuthenticationServerBasedCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -PatchIamUserBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -PatchIamUserBasedCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -PatchIamUserBasedCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsCloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	awsRegions = @{
		# REQUIRED
		regions = @(
			<AwsCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudAccountRegion]) for enum values.
		)
	}
	# OPTIONAL
	awsUserKeys = @{
		# REQUIRED
		accessKey = <System.String>
		# REQUIRED
		secretKey = <System.String>
	}
	# OPTIONAL
	awsRoleArn = @{
		# REQUIRED
		roleArn = <System.String>
	}
}
"@
    Write-Message "New-RscMutationAws -PatchIamUserBasedCloudAccount" @"
    Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
"@ "[GraphQL: patchAwsIamUserBasedCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -RegisterFeatureArtifacts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -RegisterFeatureArtifacts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -RegisterFeatureArtifacts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsArtifacts = @(
		@{
			# REQUIRED
			awsNativeId = <System.String>
			# REQUIRED
			externalArtifacts = @(
				@{
					# REQUIRED
					externalArtifactValue = <System.String>
					# OPTIONAL
					externalArtifactKey = <AwsCloudExternalArtifact> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudExternalArtifact]) for enum values.
				}
			)
			# REQUIRED
			features = @(
				<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			)
		}
	)
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
}
"@
    Write-Message "New-RscMutationAws -RegisterFeatureArtifacts" @"
    Registers the AWS account artifacts such as roles in RSC backend while onboarding AWS account in manual flow.
"@ "[GraphQL: registerAwsFeatureArtifacts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -BulkDeleteCloudAccountWithoutCft
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -BulkDeleteCloudAccountWithoutCft).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -BulkDeleteCloudAccountWithoutCft
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsNativeId = <System.String>
	# OPTIONAL
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}
"@
    Write-Message "New-RscMutationAws -BulkDeleteCloudAccountWithoutCft" @"
    Deletes specified AWS cloud accounts without using CloudFormation Template (CFT).
"@ "[GraphQL: bulkDeleteAwsCloudAccountWithoutCft]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -CreateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -CreateCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	keepClusterOnFailure = <System.Boolean>
	# OPTIONAL
	region = <System.String>
	# OPTIONAL
	disableApiTermination = <System.Boolean>
	# OPTIONAL
	clusterConfig = @{
		# OPTIONAL
		userEmail = <System.String>
		# OPTIONAL
		adminPassword = <System.String>
		# OPTIONAL
		clusterName = <System.String>
		# OPTIONAL
		numNodes = <System.Int32>
		# OPTIONAL
		dnsSearchDomains = @(
			<System.String>
		)
		# OPTIONAL
		dnsNameServers = @(
			<System.String>
		)
		# OPTIONAL
		ntpServers = @(
			<System.String>
		)
		# OPTIONAL
		azureEsConfig = @{
			# OPTIONAL
			storageAccount = <System.String>
			# OPTIONAL
			resourceGroup = <System.String>
			# OPTIONAL
			storageSecret = <System.String>
			# OPTIONAL
			containerName = <System.String>
			# OPTIONAL
			shouldCreateContainer = <System.Boolean>
			# OPTIONAL
			enableImmutability = <System.Boolean>
		}
		# OPTIONAL
		awsEsConfig = @{
			# OPTIONAL
			bucketName = <System.String>
			# OPTIONAL
			shouldCreateBucket = <System.Boolean>
			# OPTIONAL
			enableObjectLock = <System.Boolean>
			# OPTIONAL
			enableImmutability = <System.Boolean>
		}
	}
	# OPTIONAL
	vmConfig = @{
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		imageId = <System.String>
		# OPTIONAL
		instanceProfileName = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		securityGroups = @(
			<System.String>
		)
		# OPTIONAL
		instanceType = <AwsInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
	}
}
"@
    Write-Message "New-RscMutationAws -CreateCluster" @"
    Create a Rubrik Cloud Cluster on AWS.
"@ "[GraphQL: createAwsCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAws -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAws -DeleteCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAws -DeleteCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	clusterName = <System.String>
	# OPTIONAL
	numNodes = <System.Int32>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	bucketName = <System.String>
	# OPTIONAL
	isNewContainer = <System.Boolean>
	# OPTIONAL
	clusterUuid = <System.String>
	# OPTIONAL
	region = <System.String>
}
"@
    Write-Message "New-RscMutationAws -DeleteCluster" @"
    Delete a Rubrik Cloud Cluster on AWS.
"@ "[GraphQL: deleteAwsCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationAzure -StartRefreshNativeSubscriptionsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartRefreshNativeSubscriptionsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartRefreshNativeSubscriptionsJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationAzure -StartRefreshNativeSubscriptionsJob" @"
    Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.
"@ "[GraphQL: startRefreshAzureNativeSubscriptionsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartRestoreNativeVirtualMachineJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartRestoreNativeVirtualMachineJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartRestoreNativeVirtualMachineJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
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
}
"@
    Write-Message "New-RscMutationAzure -StartRestoreNativeVirtualMachineJob" @"
    Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.
"@ "[GraphQL: startRestoreAzureNativeVirtualMachineJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartExportNativeVirtualMachineJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartExportNativeVirtualMachineJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartExportNativeVirtualMachineJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
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
}
"@
    Write-Message "New-RscMutationAzure -StartExportNativeVirtualMachineJob" @"
    Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.
"@ "[GraphQL: startExportAzureNativeVirtualMachineJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	virtualMachineRubrikId = <System.String>
	# REQUIRED
	managedDiskExclusions = @(
		@{
			# REQUIRED
			managedDiskRubrikId = <System.String>
			# REQUIRED
			isExcludedFromSnapshot = <System.Boolean>
		}
	)
}
"@
    Write-Message "New-RscMutationAzure -ExcludeNativeManagedDisksFromSnapshot" @"
    Exclude the Managed Disks from snapshots, for the specified virtual machines.
"@ "[GraphQL: excludeAzureNativeManagedDisksFromSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	virtualMachineRubrikIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -StartCreateNativeVirtualMachineSnapshotsJob" @"
    Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.
"@ "[GraphQL: startCreateAzureNativeVirtualMachineSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikId = <System.String>
	# REQUIRED
	shouldDeleteNativeSnapshots = <System.Boolean>
	# REQUIRED
	azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -StartDisableNativeSubscriptionProtectionJob" @"
    Start a job to disable protection for a specified Azure subscription.
"@ "[GraphQL: startDisableAzureNativeSubscriptionProtectionJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	managedDiskRubrikIds = @(
		<System.String>
	)
	# OPTIONAL
	retentionSlaId = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -StartCreateNativeManagedDiskSnapshotsJob" @"
    Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.
"@ "[GraphQL: startCreateAzureNativeManagedDiskSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartExportNativeManagedDiskJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartExportNativeManagedDiskJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartExportNativeManagedDiskJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	diskName = <System.String>
	# OPTIONAL
	diskEncryptionSetNativeId = <System.String>
	# REQUIRED
	diskStorageTier = <AzureNativeManagedDiskType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeManagedDiskType]) for enum values.
	# REQUIRED
	diskSize = <System.Int32>
	# REQUIRED
	resourceGroup = <System.String>
	# REQUIRED
	destinationRegion = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
	# OPTIONAL
	destinationAvailabilityZone = <System.String>
	# OPTIONAL
	destinationSubscriptionRubrikId = <System.String>
	# REQUIRED
	shouldExportTags = <System.Boolean>
	# REQUIRED
	shouldReplaceAttachedManagedDisk = <System.Boolean>
	# OPTIONAL
	shouldUseReplica = <System.Boolean>
	# OPTIONAL
	snapshotType = <AzureSnapshotType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSnapshotType]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -StartExportNativeManagedDiskJob" @"
    Start a job to export the specified Azure Native Managed Disks to the desired destination.
"@ "[GraphQL: startExportAzureNativeManagedDiskJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartExportSqlDatabaseDbJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartExportSqlDatabaseDbJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartExportSqlDatabaseDbJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sourceDatabaseRubrikId = <System.String>
	# REQUIRED
	destinationDatabaseName = <System.String>
	# OPTIONAL
	destinationServerRubrikId = <System.String>
	# OPTIONAL
	elasticPoolName = <System.String>
	# REQUIRED
	shouldExportTags = <System.Boolean>
	# OPTIONAL
	azureSqlDatabaseDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = <DateTime>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	azureSqlDatabaseDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# REQUIRED
		destinationResourceGroupName = <System.String>
		# REQUIRED
		destinationServerName = <System.String>
		# REQUIRED
		destinationRegionName = <System.String>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = <System.String>
			# REQUIRED
			password = <System.String>
		}
		# OPTIONAL
		authMechanism = <SqlAuthenticationMechanism> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = <System.String>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = <System.String>
	# OPTIONAL
	serviceObjectiveName = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -StartExportSqlDatabaseDbJob" @"
    Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.
"@ "[GraphQL: startExportAzureSqlDatabaseDbJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartExportSqlManagedInstanceDbJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartExportSqlManagedInstanceDbJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartExportSqlManagedInstanceDbJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sourceManagedInstanceDatabaseRubrikId = <System.String>
	# OPTIONAL
	destinationManagedInstanceRubrikId = <System.String>
	# REQUIRED
	destinationDatabaseName = <System.String>
	# REQUIRED
	destinationManagedInstanceName = <System.String>
	# REQUIRED
	destinationResourceGroupName = <System.String>
	# OPTIONAL
	azureSqlManagedInstanceDbPitExportInput = @{
		# REQUIRED
		restorePointInTime = <DateTime>
	}
	# OPTIONAL
	azureSqlManagedInstanceDbLtrExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# REQUIRED
		destinationRegionName = <System.String>
	}
	# OPTIONAL
	persistentBackupExportInput = @{
		# REQUIRED
		sourceSnapshotRubrikId = <System.String>
		# OPTIONAL
		destinationServerCredentials = @{
			# REQUIRED
			login = <System.String>
			# REQUIRED
			password = <System.String>
		}
		# OPTIONAL
		authMechanism = <SqlAuthenticationMechanism> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SqlAuthenticationMechanism]) for enum values.
		# OPTIONAL
		sessionId = <System.String>
		# OPTIONAL
		dbBackupRedundancy = <AzureSqlBackupStorageRedundancyType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlBackupStorageRedundancyType]) for enum values.
	}
	# OPTIONAL
	serviceTier = <System.String>
	# OPTIONAL
	serviceObjectiveName = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -StartExportSqlManagedInstanceDbJob" @"
    Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.
"@ "[GraphQL: startExportAzureSqlManagedInstanceDbJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# REQUIRED
	subscriptionId = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -CreateAccount" @"
    
"@ "[GraphQL: createAzureAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	subscriptionId = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -UpdateAccount" @"
    
"@ "[GraphQL: updateAzureAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateAutomaticTargetMapping
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	containerNamePrefix = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	instanceType = <InstanceTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	clusterUuidList = @(
		<System.String>
	)
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAzure -CreateAutomaticTargetMapping" @"
    
"@ "[GraphQL: createAutomaticAzureTargetMapping]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateCloudNativeStorageSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	containerName = <System.String>
	# OPTIONAL
	storageAccountTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = <System.String>
				# REQUIRED
				value = <System.String>
			}
		)
	}
	# OPTIONAL
	storageAccountRegion = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	storageTier = <AzureStorageTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# REQUIRED
	redundancy = <AzureRedundancy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRedundancy]) for enum values.
	# REQUIRED
	subscriptionNativeId = <System.String>
	# REQUIRED
	cloudNativeLocTemplateType = <CloudNativeLocTemplateType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = <System.String>
			# OPTIONAL
			keyName = <System.String>
			# OPTIONAL
			region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -CreateCloudNativeStorageSetting" @"
    Creates Storage Settings for the archival of azure cloud native protected objects
"@ "[GraphQL: createCloudNativeAzureStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateCloudNativeRcvStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateCloudNativeRcvStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateCloudNativeRcvStorageSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# REQUIRED
	cloudNativeLocTemplateType = <CloudNativeLocTemplateType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudNativeLocTemplateType]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -CreateCloudNativeRcvStorageSetting" @"
    Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects.
"@ "[GraphQL: createCloudNativeRcvAzureStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateAutomaticTargetMapping).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateAutomaticTargetMapping
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	storageAccountName = <System.String>
	# OPTIONAL
	accessKey = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	clusterUuidList = @(
		<System.String>
	)
	# OPTIONAL
	isConsolidationEnabled = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAzure -UpdateAutomaticTargetMapping" @"
    
"@ "[GraphQL: updateAutomaticAzureTargetMapping]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateCloudNativeStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateCloudNativeStorageSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	name = <System.String>
	# REQUIRED
	storageAccountTags = @{
		# REQUIRED
		tagList = @(
			@{
				# REQUIRED
				key = <System.String>
				# REQUIRED
				value = <System.String>
			}
		)
	}
	# REQUIRED
	storageTier = <AzureStorageTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureStorageTier]) for enum values.
	# OPTIONAL
	cmkInfo = @(
		@{
			# OPTIONAL
			keyVaultName = <System.String>
			# OPTIONAL
			keyName = <System.String>
			# OPTIONAL
			region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		}
	)
}
"@
    Write-Message "New-RscMutationAzure -UpdateCloudNativeStorageSetting" @"
    
"@ "[GraphQL: updateCloudNativeAzureStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	name = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -UpdateCloudNativeRcvStorageSetting" @"
    Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects.
"@ "[GraphQL: updateCloudNativeRcvAzureStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateTarget
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	name = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	containerName = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	instanceType = <InstanceTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# OPTIONAL
	retrievalTier = <AzureRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAzure -CreateTarget" @"
    Creates an Azure archival target on the Rubrik cluster.
"@ "[GraphQL: createAzureTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateTarget
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	storageAccountName = <System.String>
	# OPTIONAL
	accessKey = <System.String>
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# OPTIONAL
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# OPTIONAL
	retrievalTier = <AzureRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAzure -UpdateTarget" @"
    
"@ "[GraphQL: updateAzureTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateReaderTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateReaderTarget
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	name = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	storageAccountName = <System.String>
	# REQUIRED
	accessKey = <System.String>
	# REQUIRED
	containerName = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	instanceType = <InstanceTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InstanceTypeEnum]) for enum values.
	# REQUIRED
	rsaKey = <System.String>
	# OPTIONAL
	computeSettings = @{
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecretKey = <System.String>
		# OPTIONAL
		region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
		# OPTIONAL
		generalPurposeStorageName = <System.String>
		# OPTIONAL
		generalPurposeStorageContainer = <System.String>
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		virtualNetworkId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
		# OPTIONAL
		securityGroupId = <System.String>
		# OPTIONAL
		computeProxySettings = @{
			# OPTIONAL
			proxyServer = <System.String>
			# OPTIONAL
			portNumber = <System.Int32>
			# OPTIONAL
			username = <System.String>
			# OPTIONAL
			password = <System.String>
			# OPTIONAL
			protocol = <System.String>
		}
		# OPTIONAL
		cloudAccountId = <System.String>
	}
	# OPTIONAL
	proxySettings = @{
		# OPTIONAL
		proxyServer = <System.String>
		# OPTIONAL
		portNumber = <System.Int32>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		protocol = <System.String>
	}
	# REQUIRED
	isConsolidationEnabled = <System.Boolean>
	# OPTIONAL
	immutabilitySettings = @{
		# OPTIONAL
		lockDurationDays = <System.Int32>
	}
	# REQUIRED
	readerRetrievalMethod = <ReaderRetrievalMethod> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReaderRetrievalMethod]) for enum values.
	# OPTIONAL
	retrievalTier = <AzureRetrievalTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRetrievalTier]) for enum values.
	# REQUIRED
	bypassProxy = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAzure -CreateReaderTarget" @"
    Creates reader type for Azure archival location on a CDM cluster.
"@ "[GraphQL: createAzureReaderTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartCloudAccountOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartCloudAccountOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartCloudAccountOauth
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	tenantDomainName = <System.String>
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -StartCloudAccountOauth" @"
    Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.
"@ "[GraphQL: startAzureCloudAccountOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CompleteCloudAccountOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CompleteCloudAccountOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CompleteCloudAccountOauth
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	tenantDomainName = <System.String>
	# REQUIRED
	authorizationCode = <System.String>
	# REQUIRED
	redirectUrl = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	appId = <System.String>
	# OPTIONAL
	appSecretKey = <System.String>
	# REQUIRED
	shouldSkipPermissionChecks = <System.Boolean>
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	resource = <AzureOauthResource> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureOauthResource]) for enum values.
	# OPTIONAL
	performBasicOauth = <System.Boolean>
	# OPTIONAL
	shouldKeepRefreshToken = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAzure -CompleteCloudAccountOauth" @"
    Complete the Azure OAuth flow and pass the authorization code.
"@ "[GraphQL: completeAzureCloudAccountOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -SetCloudAccountCustomerAppCredentials
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -SetCloudAccountCustomerAppCredentials).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -SetCloudAccountCustomerAppCredentials
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appId = <System.String>
	# REQUIRED
	appSecretKey = <System.String>
	# OPTIONAL
	appTenantId = <System.String>
	# OPTIONAL
	appName = <System.String>
	# OPTIONAL
	tenantDomainName = <System.String>
	# REQUIRED
	shouldReplace = <System.Boolean>
	# REQUIRED
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -SetCloudAccountCustomerAppCredentials" @"
    Set credentials for the customer application, for the tenant domain name.
"@ "[GraphQL: setAzureCloudAccountCustomerAppCredentials]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -AddCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -AddCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -AddCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	tenantDomainName = <System.String>
	# REQUIRED
	subscriptions = @(
		@{
			# REQUIRED
			features = @(
				@{
					# OPTIONAL
					resourceGroup = @{
						# REQUIRED
						name = <System.String>
						# OPTIONAL
						tags = @{
							# REQUIRED
							tagList = @(
								@{
									# REQUIRED
									key = <System.String>
									# REQUIRED
									value = <System.String>
								}
							)
						}
						# REQUIRED
						region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
					}
					# REQUIRED
					featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					permissionsGroups = @(
						<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
					)
				}
			)
			# REQUIRED
			subscription = @{
				# REQUIRED
				nativeId = <System.String>
				# REQUIRED
				name = <System.String>
			}
		}
	)
	# REQUIRED
	regions = @(
		<AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
}
"@
    Write-Message "New-RscMutationAzure -AddCloudAccount" @"
    Add the Azure Subscriptions cloud account for the given feature.
"@ "[GraphQL: addAzureCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -AddCloudAccountWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -AddCloudAccountWithoutOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -AddCloudAccountWithoutOauth
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantDomainName = <System.String>
	# REQUIRED
	subscriptions = @(
		@{
			# REQUIRED
			features = @(
				@{
					# REQUIRED
					policyVersion = <System.Int32>
					# OPTIONAL
					resourceGroup = @{
						# REQUIRED
						name = <System.String>
						# OPTIONAL
						tags = @{
							# REQUIRED
							tagList = @(
								@{
									# REQUIRED
									key = <System.String>
									# REQUIRED
									value = <System.String>
								}
							)
						}
						# REQUIRED
						region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
					}
					# OPTIONAL
					specificFeatureInput = @{
						# REQUIRED
						userAssignedManagedIdentityInput = @{
							# REQUIRED
							name = <System.String>
							# REQUIRED
							resourceGroupName = <System.String>
							# REQUIRED
							principalId = <System.String>
							# REQUIRED
							region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
						}
					}
					# REQUIRED
					featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
					# OPTIONAL
					permissionsGroups = @(
						<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
					)
				}
			)
			# REQUIRED
			subscription = @{
				# REQUIRED
				nativeId = <System.String>
				# REQUIRED
				name = <System.String>
			}
		}
	)
	# REQUIRED
	regions = @(
		<AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -AddCloudAccountWithoutOauth" @"
    Add the Azure Subscription cloud account for the given feature without OAuth.
"@ "[GraphQL: addAzureCloudAccountWithoutOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationAzure -DeleteCloudAccount" @"
    Delete the Azure Subscriptions cloud account for the given feature.
"@ "[GraphQL: deleteAzureCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteCloudAccountWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteCloudAccountWithoutOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteCloudAccountWithoutOauth
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationAzure -DeleteCloudAccountWithoutOauth" @"
    Delete the Azure Subscriptions cloud account for the given feature without OAuth.
"@ "[GraphQL: deleteAzureCloudAccountWithoutOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpgradeCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpgradeCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpgradeCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featuresToUpgrade = @(
		@{
			# REQUIRED
			featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
			# REQUIRED
			permissionsGroups = @(
				<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
		}
	)
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationAzure -UpgradeCloudAccount" @"
    Update permissions of the Azure Subscriptions cloud account for given feature.
"@ "[GraphQL: upgradeAzureCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateCustomerAppPermissionForSql
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateCustomerAppPermissionForSql).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateCustomerAppPermissionForSql
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscMutationAzure -UpdateCustomerAppPermissionForSql" @"
    Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication.
"@ "[GraphQL: updateCustomerAppPermissionForAzureSql]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -StartDisableCloudAccountJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -StartDisableCloudAccountJob).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -StartDisableCloudAccountJob
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationAzure -StartDisableCloudAccountJob" @"
    Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.
"@ "[GraphQL: startDisableAzureCloudAccountJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpdateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpdateCloudAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpdateCloudAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	subscriptions = @(
		@{
			# OPTIONAL
			id = <System.String>
			# OPTIONAL
			name = <System.String>
		}
	)
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	regionsToAdd = @(
		<AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
	# OPTIONAL
	regionsToRemove = @(
		<AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
	)
}
"@
    Write-Message "New-RscMutationAzure -UpdateCloudAccount" @"
    Update names of the Azure Subscriptions cloud account and regions for the given feature.
"@ "[GraphQL: updateAzureCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
	# REQUIRED
	persistentStorageId = <System.String>
	# REQUIRED
	azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -MapCloudAccountToPersistentStorageLocation" @"
    Map Azure cloud accounts to a persistent storage location.
"@ "[GraphQL: mapAzureCloudAccountToPersistentStorageLocation]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -AddCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -AddCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -AddCloudAccountExocomputeConfigurations
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	azureExocomputeRegionConfigs = @(
		@{
			# REQUIRED
			region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			# REQUIRED
			subnetNativeId = <System.String>
			# REQUIRED
			isRscManaged = <System.Boolean>
			# OPTIONAL
			podSubnetNativeId = <System.String>
		}
	)
	# OPTIONAL
	triggerHealthCheck = <System.Boolean>
}
"@
    Write-Message "New-RscMutationAzure -AddCloudAccountExocomputeConfigurations" @"
    Add Exocompute configurations for an Azure Cloud Account.
"@ "[GraphQL: addAzureCloudAccountExocomputeConfigurations]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationAzure -DeleteCloudAccountExocomputeConfigurations" @"
    Delete Exocompute configurations for an Azure Cloud Account.
"@ "[GraphQL: deleteAzureCloudAccountExocomputeConfigurations]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -MapCloudAccountExocomputeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -MapCloudAccountExocomputeSubscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -MapCloudAccountExocomputeSubscription
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
	# REQUIRED
	exocomputeCloudAccountId = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -MapCloudAccountExocomputeSubscription" @"
    Map Azure cloud accounts to an Exocompute subscription.
"@ "[GraphQL: mapAzureCloudAccountExocomputeSubscription]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationAzure -UnmapCloudAccountExocomputeSubscription" @"
    Unmap Azure cloud accounts from the mapped Exocompute subscription.
"@ "[GraphQL: unmapAzureCloudAccountExocomputeSubscription]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# OPTIONAL
	featureToUpgrade = @{
		# REQUIRED
		featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		# REQUIRED
		permissionsGroups = @(
			<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
		)
	}
}
"@
    Write-Message "New-RscMutationAzure -UpgradeCloudAccountPermissionsWithoutOauth" @"
    Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.
"@ "[GraphQL: upgradeAzureCloudAccountPermissionsWithoutOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -UnmapPersistentStorageSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -UnmapPersistentStorageSubscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -UnmapPersistentStorageSubscription
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	applicationCloudAccountIds = @(
		<System.String>
	)
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	unmappingValidationType = <UnmappingValidationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -UnmapPersistentStorageSubscription" @"
    Unmaps the archival location from the subscription.
"@ "[GraphQL: unmapAzurePersistentStorageSubscription]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -OauthConsentKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -OauthConsentKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -OauthConsentKickoff
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscMutationAzure -OauthConsentKickoff" @"
    Kicks off an OAuth consent flow for Azure resource access.
"@ "[GraphQL: azureOauthConsentKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -OauthConsentComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -OauthConsentComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -OauthConsentComplete
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	code = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	redirectUrl = <System.String>
	# OPTIONAL
	azureAppId = <System.String>
	# OPTIONAL
	azureAppSecret = <System.String>
	# REQUIRED
	azureCloudType = <O365AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
}
"@
    Write-Message "New-RscMutationAzure -OauthConsentComplete" @"
    Completes an OAuth consent flow for Azure resource access.
"@ "[GraphQL: azureOauthConsentComplete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateSaasAppAad
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateSaasAppAad).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateSaasAppAad
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscMutationAzure -CreateSaasAppAad" @"
    Create or get an Azure AAD application.
"@ "[GraphQL: createAzureSaasAppAad]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -CreateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -CreateCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	keepClusterOnFailure = <System.Boolean>
	# OPTIONAL
	clusterConfig = @{
		# OPTIONAL
		userEmail = <System.String>
		# OPTIONAL
		adminPassword = <System.String>
		# OPTIONAL
		clusterName = <System.String>
		# OPTIONAL
		numNodes = <System.Int32>
		# OPTIONAL
		dnsSearchDomains = @(
			<System.String>
		)
		# OPTIONAL
		dnsNameServers = @(
			<System.String>
		)
		# OPTIONAL
		ntpServers = @(
			<System.String>
		)
		# OPTIONAL
		azureEsConfig = @{
			# OPTIONAL
			storageAccount = <System.String>
			# OPTIONAL
			resourceGroup = <System.String>
			# OPTIONAL
			storageSecret = <System.String>
			# OPTIONAL
			containerName = <System.String>
			# OPTIONAL
			shouldCreateContainer = <System.Boolean>
			# OPTIONAL
			enableImmutability = <System.Boolean>
		}
		# OPTIONAL
		awsEsConfig = @{
			# OPTIONAL
			bucketName = <System.String>
			# OPTIONAL
			shouldCreateBucket = <System.Boolean>
			# OPTIONAL
			enableObjectLock = <System.Boolean>
			# OPTIONAL
			enableImmutability = <System.Boolean>
		}
	}
	# OPTIONAL
	vmConfig = @{
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		location = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		networkResourceGroup = <System.String>
		# OPTIONAL
		vnetResourceGroup = <System.String>
		# OPTIONAL
		networkSecurityGroup = <System.String>
		# OPTIONAL
		networkSecurityResourceGroup = <System.String>
		# OPTIONAL
		vnet = <System.String>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		vmImage = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = <AzureInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
}
"@
    Write-Message "New-RscMutationAzure -CreateCluster" @"
    Create a Rubrik Cloud Cluster on Azure.
"@ "[GraphQL: createAzureCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationAzure -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzure -DeleteCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzure -DeleteCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	clusterName = <System.String>
	# OPTIONAL
	numNodes = <System.Int32>
	# OPTIONAL
	resourceGroupName = <System.String>
	# OPTIONAL
	networkResourceGroup = <System.String>
	# OPTIONAL
	isEsType = <System.Boolean>
	# OPTIONAL
	storageAccount = <System.String>
	# OPTIONAL
	containerName = <System.String>
	# OPTIONAL
	storageResourceGroup = <System.String>
	# OPTIONAL
	isNewContainer = <System.Boolean>
	# OPTIONAL
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscMutationAzure -DeleteCluster" @"
    Delete a Rubrik Cloud Cluster on Azure.
"@ "[GraphQL: deleteAzureCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationAzureO365 -SetupExocompute
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationAzureO365 -SetupExocompute).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationAzureO365 -SetupExocompute
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.exocomputeConfig = @{
	# REQUIRED
	regionName = <System.String>
	# OPTIONAL
	newGroupConfig = @{
		# OPTIONAL
		name = <System.String>
	}
	# OPTIONAL
	existingGroupConfig = @{
		# OPTIONAL
		name = <System.String>
	}
	# OPTIONAL
	newComputeConfig = @{
		# OPTIONAL
		vnetName = <System.String>
		# OPTIONAL
		subnetName = <System.String>
		# OPTIONAL
		securityGroupName = <System.String>
	}
	# OPTIONAL
	existingComputeConfig = @{
		# OPTIONAL
		vnetId = <System.String>
		# OPTIONAL
		subnetId = <System.String>
	}
	# OPTIONAL
	newStorageAccountConfig = @{
		# OPTIONAL
		name = <System.String>
		# OPTIONAL
		tier = <StorageAccountTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountTier]) for enum values.
		# OPTIONAL
		sku = <StorageAccountSku> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountSku]) for enum values.
		# OPTIONAL
		storages = @(
			@{
				# OPTIONAL
				name = <System.String>
				# OPTIONAL
				tier = <StorageAccountTier> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountTier]) for enum values.
				# OPTIONAL
				sku = <StorageAccountSku> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.StorageAccountSku]) for enum values.
				# OPTIONAL
				containerImmutabilityStatus = <ColossusStorageContainerImmutabilityStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColossusStorageContainerImmutabilityStatus]) for enum values.
				# OPTIONAL
				versioningEnabled = <System.Boolean>
			}
		)
	}
	# OPTIONAL
	existingStorageAccountConfig = @{
		# OPTIONAL
		id = <System.String>
	}
}
"@
    Write-Message "New-RscMutationAzureO365 -SetupExocompute" @"
    Sets up Exocompute for an O365 subscription.
"@ "[GraphQL: setupAzureO365Exocompute]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationCassandra -RecoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -RecoverSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -RecoverSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryData = @{
		# OPTIONAL
		destinationManagementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# OPTIONAL
		destinationSourceName = <System.String>
		# OPTIONAL
		keyspaceConfig = <System.String>
		# OPTIONAL
		maxDiskUsage = <System.String>
		# OPTIONAL
		restoreDbUserPwd = <System.String>
		# OPTIONAL
		restoreDbUsername = <System.String>
		# OPTIONAL
		startTimestamp = <System.Int32>
		# OPTIONAL
		targetEncryptionKey = <System.String>
		# OPTIONAL
		targetQuery = <System.String>
		# OPTIONAL
		sourceType = <MosaicRetrieveRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRetrieveRequestSourceType]) for enum values.
		# REQUIRED
		destinationPath = <System.String>
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# REQUIRED
		parameterEncoded = <System.Boolean>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		versionTime = <System.Int32>
	}
}
"@
    Write-Message "New-RscMutationCassandra -RecoverSource" @"
    Recover a cassandra source.
"@ "[GraphQL: recoverCassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCassandra -CreateSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -CreateSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -CreateSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# OPTIONAL
		cassandraYaml = @(
			<System.String>
		)
		# OPTIONAL
		dseYaml = @(
			<System.String>
		)
		# OPTIONAL
		enableSsl = <System.Boolean>
		# OPTIONAL
		httpsCertificate = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		jmxPassword = <System.String>
		# OPTIONAL
		jmxUser = <System.String>
		# OPTIONAL
		parameterEncoded = <System.Boolean>
		# OPTIONAL
		sourceAuthKey = <System.String>
		# OPTIONAL
		sourceAuthKeyfile = <System.String>
		# OPTIONAL
		sourceAuthPassphrase = <System.String>
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sourceHttpsPort = <System.String>
		# OPTIONAL
		sourcePassword = <System.String>
		# OPTIONAL
		sourcePort = <System.String>
		# OPTIONAL
		sourceRpcPort = <System.String>
		# OPTIONAL
		sourceSshPort = <System.String>
		# OPTIONAL
		sourceUser = <System.String>
		# OPTIONAL
		sslCaCerts = <System.String>
		# OPTIONAL
		sslCertfile = <System.String>
		# OPTIONAL
		sslKeyfile = <System.String>
		# REQUIRED
		sourceType = <SourceSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = <SourceSslCertReqs> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			<System.String>
		)
		# REQUIRED
		sourceName = <System.String>
	}
}
"@
    Write-Message "New-RscMutationCassandra -CreateSource" @"
    Create a cassandra source.
"@ "[GraphQL: createCassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCassandra -UpdateSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -UpdateSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -UpdateSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# OPTIONAL
		cassandraYaml = @(
			<System.String>
		)
		# OPTIONAL
		dseYaml = @(
			<System.String>
		)
		# OPTIONAL
		enableSsl = <System.Boolean>
		# OPTIONAL
		httpsCertificate = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		jmxPassword = <System.String>
		# OPTIONAL
		jmxUser = <System.String>
		# OPTIONAL
		parameterEncoded = <System.Boolean>
		# OPTIONAL
		sourceAuthKey = <System.String>
		# OPTIONAL
		sourceAuthKeyfile = <System.String>
		# OPTIONAL
		sourceAuthPassphrase = <System.String>
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sourceHttpsPort = <System.String>
		# OPTIONAL
		sourcePassword = <System.String>
		# OPTIONAL
		sourcePort = <System.String>
		# OPTIONAL
		sourceRpcPort = <System.String>
		# OPTIONAL
		sourceSshPort = <System.String>
		# OPTIONAL
		sourceUser = <System.String>
		# OPTIONAL
		sslCaCerts = <System.String>
		# OPTIONAL
		sslCertfile = <System.String>
		# OPTIONAL
		sslKeyfile = <System.String>
		# REQUIRED
		sourceType = <SourceSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = <SourceSslCertReqs> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			<System.String>
		)
		# REQUIRED
		sourceName = <System.String>
	}
}
"@
    Write-Message "New-RscMutationCassandra -UpdateSource" @"
    Update a cassandra source.
"@ "[GraphQL: updateCassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCassandra -DeleteSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -DeleteSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -DeleteSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	sourceType = <V2DeleteMosaicSourceRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2DeleteMosaicSourceRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceName = <System.String>
}
"@
    Write-Message "New-RscMutationCassandra -DeleteSource" @"
    Delete a cassandra source.
"@ "[GraphQL: deleteCassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCassandra -BulkDeleteSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCassandra -BulkDeleteSources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCassandra -BulkDeleteSources
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	sourceType = <V2BulkDeleteMosaicSourcesRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2BulkDeleteMosaicSourcesRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# REQUIRED
		sourceNames = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscMutationCassandra -BulkDeleteSources" @"
    Bulk Delete cassandra sources.
"@ "[GraphQL: bulkDeleteCassandraSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationCluster -AddNodesToCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -AddNodesToCloud).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -AddNodesToCloud
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	numberOfNodes = <System.Int32>
	# OPTIONAL
	shouldKeepResourcesOnFailure = <System.Boolean>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	vendor = <CcpVendorType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpVendorType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscMutationCluster -AddNodesToCloud" @"
    Add nodes to cloud cluster.
"@ "[GraphQL: addNodesToCloudCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -RegisterCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -RegisterCloud).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -RegisterCloud
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscMutationCluster -RegisterCloud" @"
    Register a cloud cluster.
"@ "[GraphQL: registerCloudCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -UpdateDatabaseLogReportingProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -UpdateDatabaseLogReportingProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -UpdateDatabaseLogReportingProperties
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	properties = @{
		# OPTIONAL
		enableDelayNotification = <System.Boolean>
		# OPTIONAL
		logDelayThresholdInMin = <System.Int64>
		# OPTIONAL
		logDelayNotificationFrequencyInMin = <System.Int64>
	}
}
"@
    Write-Message "New-RscMutationCluster -UpdateDatabaseLogReportingProperties" @"
    Update the database log backup report properties

Supported in v5.3+
Update the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.
"@ "[GraphQL: updateDatabaseLogReportingPropertiesForCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -CreateFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -CreateFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -CreateFailover
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		name = <System.String>
	}
}
"@
    Write-Message "New-RscMutationCluster -CreateFailover" @"
    Create a failover cluster

Supported in v5.2+
Create a failover cluster.
"@ "[GraphQL: createFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -UpdateFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -UpdateFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -UpdateFailover
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		name = <System.String>
	}
}
"@
    Write-Message "New-RscMutationCluster -UpdateFailover" @"
    Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.
"@ "[GraphQL: updateFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -DeleteFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -DeleteFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -DeleteFailover
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationCluster -DeleteFailover" @"
    Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.
"@ "[GraphQL: deleteFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -BulkDeleteFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -BulkDeleteFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -BulkDeleteFailover
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	ids = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationCluster -BulkDeleteFailover" @"
    Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.
"@ "[GraphQL: bulkDeleteFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -CreateK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -CreateK8s).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -CreateK8s
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cdmClusterId = <System.String>
	# REQUIRED
	hostList = @(
		<System.String>
	)
	# REQUIRED
	name = <System.String>
	# REQUIRED
	port = <System.Int32>
	# REQUIRED
	rbsPortRanges = @(
		@{
			# OPTIONAL
			portMin = <System.Int32>
			# OPTIONAL
			portMax = <System.Int32>
		}
	)
	# OPTIONAL
	userDrivenPortRanges = @(
		@{
			# OPTIONAL
			portMin = <System.Int32>
			# OPTIONAL
			portMax = <System.Int32>
		}
	)
	# REQUIRED
	type = <K8sClusterProtoType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.K8sClusterProtoType]) for enum values.
	# OPTIONAL
	proxyUrl = <System.String>
}
"@
    Write-Message "New-RscMutationCluster -CreateK8s" @"
    Add a Kubernetes cluster.
"@ "[GraphQL: createK8sCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -RefreshK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -RefreshK8s).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -RefreshK8s
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	k8sClusterId = <System.String>
}
"@
    Write-Message "New-RscMutationCluster -RefreshK8s" @"
    Refresh resources of a Kubernetes cluster.
"@ "[GraphQL: refreshK8sCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -ArchiveK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -ArchiveK8s).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -ArchiveK8s
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterId = <System.String>
}
"@
    Write-Message "New-RscMutationCluster -ArchiveK8s" @"
    Archive a Kubernetes cluster.
"@ "[GraphQL: archiveK8sCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -RemoveCdm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -RemoveCdm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -RemoveCdm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUUID = <System.String>
# REQUIRED
$inputs.Var.isForce = <System.Boolean>
# OPTIONAL
$inputs.Var.expireInDays = <System.Int64>
"@
    Write-Message "New-RscMutationCluster -RemoveCdm" @"
    
"@ "[GraphQL: removeCdmCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationCluster -RecoverCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationCluster -RecoverCloud).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationCluster -RecoverCloud
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	adminPassword = <System.String>
	# OPTIONAL
	userEmail = <System.String>
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# OPTIONAL
	azureEsResourceGroup = <System.String>
	# OPTIONAL
	azureVmConfig = @{
		# OPTIONAL
		resourceGroup = <System.String>
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		location = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		networkResourceGroup = <System.String>
		# OPTIONAL
		vnetResourceGroup = <System.String>
		# OPTIONAL
		networkSecurityGroup = <System.String>
		# OPTIONAL
		networkSecurityResourceGroup = <System.String>
		# OPTIONAL
		vnet = <System.String>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		vmImage = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		instanceType = <AzureInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureInstanceType]) for enum values.
	}
	# OPTIONAL
	awsVmConfig = @{
		# OPTIONAL
		cdmVersion = <System.String>
		# OPTIONAL
		nodeSizeGb = <System.Int32>
		# OPTIONAL
		subnet = <System.String>
		# OPTIONAL
		tags = <System.String>
		# OPTIONAL
		imageId = <System.String>
		# OPTIONAL
		instanceProfileName = <System.String>
		# OPTIONAL
		cdmProduct = <System.String>
		# OPTIONAL
		vmType = <VmType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VmType]) for enum values.
		# OPTIONAL
		securityGroups = @(
			<System.String>
		)
		# OPTIONAL
		instanceType = <AwsInstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsInstanceType]) for enum values.
	}
	# OPTIONAL
	awsRegion = <System.String>
	# REQUIRED
	shouldDisableAwsApiTermination = <System.Boolean>
	# REQUIRED
	shouldKeepClusterOnFailure = <System.Boolean>
	# OPTIONAL
	ntpServers = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationCluster -RecoverCloud" @"
    Recover a Rubrik Cloud Cluster.
"@ "[GraphQL: recoverCloudCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationDb2 -AddInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -AddInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -AddInstance
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	db2InstanceRequestConfig = @{
		# REQUIRED
		hostIds = @(
			<System.String>
		)
		# REQUIRED
		instanceName = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}
"@
    Write-Message "New-RscMutationDb2 -AddInstance" @"
    Mutation to add a new Db2 instance.
"@ "[GraphQL: addDb2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DeleteInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DeleteInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DeleteInstance
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -DeleteInstance" @"
    Mutation to delete existing Db2 instance.
"@ "[GraphQL: deleteDb2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DiscoverInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DiscoverInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DiscoverInstance
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -DiscoverInstance" @"
    On-demand discovery of a Db2 instance

Supported in v7.0+
Initiates an on-demand job to discover a Db2 instance.
"@ "[GraphQL: discoverDb2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -PatchInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -PatchInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -PatchInstance
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	db2InstanceRequestConfig = @{
		# OPTIONAL
		hostIds = @(
			<System.String>
		)
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		instanceName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -PatchInstance" @"
    Mutation to update an existing Db2 instance.
"@ "[GraphQL: patchDb2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -CreateOnDemandBackup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -CreateOnDemandBackup" @"
    Create on demand database snapshot

Supported in v8.0+
Initiates a job to take an on demand, full snapshot of a specified Db2 database object. Use the GET /db2/db/request/{id} endpoint to monitor the progress of the job.
"@ "[GraphQL: createOnDemandDb2Backup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DownloadSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DownloadSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -DownloadSnapshot" @"
    Download Db2 database snapshot from archive

Supported in v8.0+
Downloads a specific Db2 database snapshot from the specified archival location.
"@ "[GraphQL: downloadDb2Snapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		pointInTime = <DateTime>
		# REQUIRED
		preferredLocationId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -DownloadSnapshotsForPointInTimeRecovery" @"
    Download Db2 database snapshots from archive for a point in time recovery

Supported in v8.0+
Downloads the most recent full snapshot and the log snapshots taken after the full snapshot, required for the point in time recovery of a Db2 database.
"@ "[GraphQL: downloadDb2SnapshotsForPointInTimeRecovery]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -ExpireDownloadedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -ExpireDownloadedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -ExpireDownloadedSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# OPTIONAL
	shouldExpireLogsOnly = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -ExpireDownloadedSnapshots" @"
    Expire downloaded snapshots of a Db2 database

Supported in v8.0+
Requests an asynchronous job to expire all downloaded data and log snapshots. You can specify a begin time or an end time or both to provide a time range to expire only the downloaded data and log snapshots that were taken within the specified time range. The time is relative to when the snapshot was originally taken, not when it was downloaded. You can also configure a flag to expire only the log snapshots.
"@ "[GraphQL: expireDownloadedDb2Snapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -PatchDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -PatchDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -PatchDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	db2DatabaseConfig = @{
		# OPTIONAL
		backupParallelism = <System.Int32>
		# OPTIONAL
		backupSessions = <System.Int32>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -PatchDatabase" @"
    Update a Db2 database

Supported in v9.0+
Updating a Db2 database involves modifying the metadata associated with the Db2 database using the provided input values.
"@ "[GraphQL: patchDb2Database]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -RefreshDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -RefreshDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -RefreshDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -RefreshDatabase" @"
    On-demand refresh of a Db2 database

Supported in v8.1+
Initiates an on-demand job to refresh a Db2 database. Currently, this is allowed only for Db2 HADR databases.
"@ "[GraphQL: refreshDb2Database]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationDb2 -DeleteDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationDb2 -DeleteDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationDb2 -DeleteDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationDb2 -DeleteDatabase" @"
    Delete Db2 database

Supported in v8.1+
Deletes a Db2 database.
"@ "[GraphQL: deleteDb2Database]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationHyperv -RegisterScvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RegisterScvmm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RegisterScvmm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	scvmm = @{
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		runAsAccount = <System.String>
		# REQUIRED
		shouldDeployAgent = <System.Boolean>
	}
}
"@
    Write-Message "New-RscMutationHyperv -RegisterScvmm" @"
    Register HyperV SCVMM to Rubrik Cluster.
"@ "[GraphQL: registerHypervScvmm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -ScvmmUpdate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -ScvmmUpdate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -ScvmmUpdate
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		runAsAccount = <System.String>
		# OPTIONAL
		shouldDeployAgent = <System.Boolean>
	}
}
"@
    Write-Message "New-RscMutationHyperv -ScvmmUpdate" @"
    Update properties for a given HyperV SCVMM.
"@ "[GraphQL: hypervScvmmUpdate]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -ScvmmDelete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -ScvmmDelete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -ScvmmDelete
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -ScvmmDelete" @"
    Delete a given HyperV SCVMM.
"@ "[GraphQL: hypervScvmmDelete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RefreshScvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RefreshScvmm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RefreshScvmm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -RefreshScvmm" @"
    Refresh a given HyperV SCVMM.
"@ "[GraphQL: refreshHypervScvmm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -OnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -OnDemandSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -OnDemandSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -OnDemandSnapshot" @"
    Create on-demand VM snapshot

Supported in v5.0+
Create an on-demand snapshot for the given VM ID.
"@ "[GraphQL: hypervOnDemandSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DeleteAllSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DeleteAllSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DeleteAllSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -DeleteAllSnapshots" @"
    Delete all snapshots of VM

Supported in v5.0+
Delete all snapshots of a virtual machine.
"@ "[GraphQL: hypervDeleteAllSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -ExportVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -ExportVirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -ExportVirtualMachine
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		disableNetwork = <System.Boolean>
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
		# REQUIRED
		path = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -ExportVirtualMachine" @"
    Export VM snapshot

Supported in v5.0+
Export snapshot of a vm.
"@ "[GraphQL: exportHypervVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# REQUIRED
		paths = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -DownloadVirtualMachineSnapshotFiles" @"
    Download files from a Hyper-V VM backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified Hyper-V VM backup. The response returns an asynchrounous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'hyperv/vm/request/{id}'.
"@ "[GraphQL: downloadHypervVirtualMachineSnapshotFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		vmName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -InstantRecoverVirtualMachineSnapshot" @"
    Creates an instant recover request that restores a target VM from the given Rubrik-hosted-snapshot

Supported in v5.0+
The VM will be started with networking enabled. If the VM does not exist anymore, a new VM will be created.
"@ "[GraphQL: instantRecoverHypervVirtualMachineSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVirtualMachineId = <System.String>
		# REQUIRED
		restoreConfig = @(
			@{
				# REQUIRED
				path = <System.String>
				# REQUIRED
				restorePath = <System.String>
			}
		)
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -RestoreVirtualMachineSnapshotFiles" @"
    Restore files from snapshot

Supported in v5.0+
Restore files from a snapshot to the original source location.
"@ "[GraphQL: restoreHypervVirtualMachineSnapshotFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RegisterAgentVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RegisterAgentVirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RegisterAgentVirtualMachine
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -RegisterAgentVirtualMachine" @"
    Register the agent installed in VM

Supported in v5.0+
Register the agent that installed in VM.
"@ "[GraphQL: registerAgentHypervVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DeleteVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DeleteVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DeleteVirtualMachineSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <InternalDeleteHypervVirtualMachineSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteHypervVirtualMachineSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -DeleteVirtualMachineSnapshot" @"
    Delete VM snapshot

Supported in v5.0+
Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.
"@ "[GraphQL: deleteHypervVirtualMachineSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DownloadVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DownloadVirtualMachineSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DownloadVirtualMachineSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -DownloadVirtualMachineSnapshot" @"
    Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
"@ "[GraphQL: downloadHypervVirtualMachineSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -CreateVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -CreateVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -CreateVirtualMachineSnapshotMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		disableNetwork = <System.Boolean>
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -CreateVirtualMachineSnapshotMount" @"
    Create a live mount request

Supported in v5.0+
Create a live mount request with given configuration.
"@ "[GraphQL: createHypervVirtualMachineSnapshotMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		powerStatus = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -UpdateVirtualMachineSnapshotMount" @"
    Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.
"@ "[GraphQL: updateHypervVirtualMachineSnapshotMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -DeleteVirtualMachineSnapshotMount" @"
    Requst to delete a live mount

Supported in v5.0+
Create a request to delete a live mount.
"@ "[GraphQL: deleteHypervVirtualMachineSnapshotMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -RefreshServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -RefreshServer).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -RefreshServer
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationHyperv -RefreshServer" @"
    Refresh Hyper-V host metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Hyper-V host.
"@ "[GraphQL: refreshHypervServer]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -BatchOnDemandBackupVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -BatchOnDemandBackupVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -BatchOnDemandBackupVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	userNote = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		vms = @(
			@{
				# OPTIONAL
				backupConfig = @{
					# OPTIONAL
					slaId = <System.String>
				}
				# OPTIONAL
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationHyperv -BatchOnDemandBackupVm" @"
    Takes bulk on-demand backup of Hyper-V virtual machines

Supported in v9.0+
Takes on-demand backup of multiple specified Hyper-V virtual machines.
"@ "[GraphQL: batchOnDemandBackupHypervVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -BatchExportVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -BatchExportVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -BatchExportVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				exportConfig = @{
					# OPTIONAL
					disableNetwork = <System.Boolean>
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					powerOn = <System.Boolean>
					# OPTIONAL
					removeNetworkDevices = <System.Boolean>
					# OPTIONAL
					vmName = <System.String>
					# REQUIRED
					path = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationHyperv -BatchExportVm" @"
    Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.
"@ "[GraphQL: batchExportHypervVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -BatchMountVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -BatchMountVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -BatchMountVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				mountConfig = @{
					# OPTIONAL
					disableNetwork = <System.Boolean>
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					powerOn = <System.Boolean>
					# OPTIONAL
					removeNetworkDevices = <System.Boolean>
					# OPTIONAL
					vmName = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationHyperv -BatchMountVm" @"
    Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.
"@ "[GraphQL: batchMountHypervVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -BatchInstantRecoverVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -BatchInstantRecoverVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -BatchInstantRecoverVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# REQUIRED
				instantRecoveryConfig = @{
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					vmName = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationHyperv -BatchInstantRecoverVm" @"
    Instantly recovers snapshots from multiple virtual machines

Supported in v7.0+
Instantly recovers a batch of snapshots from a group of specified virtual machines.
"@ "[GraphQL: batchInstantRecoverHypervVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -UpdateVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -UpdateVirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -UpdateVirtualMachine
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		cloudInstantiationSpec = @{
			# REQUIRED
			imageRetentionInSeconds = <System.Int64>
		}
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		virtualDiskIdsExcludedFromSnapshot = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscMutationHyperv -UpdateVirtualMachine" @"
    Update VM

Supported in v5.0+
Update VM with specified properties.
"@ "[GraphQL: updateHypervVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationHyperv -DownloadSnapshotFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationHyperv -DownloadSnapshotFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationHyperv -DownloadSnapshotFromLocation
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	downloadConfig = @{
		# OPTIONAL
		slaId = <System.String>
	}
}
"@
    Write-Message "New-RscMutationHyperv -DownloadSnapshotFromLocation" @"
    Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
"@ "[GraphQL: downloadHypervSnapshotFromLocation]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationLdap -UpdateIntegration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationLdap -UpdateIntegration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationLdap -UpdateIntegration
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.id = <System.String>
# REQUIRED
$inputs.Var.name = <System.String>
# REQUIRED
$inputs.Var.bindUserName = <System.String>
# REQUIRED
$inputs.Var.bindUserPassword = <System.String>
# OPTIONAL
$inputs.Var.baseDn = <System.String>
# OPTIONAL
$inputs.Var.trustedCerts = <System.String>
# OPTIONAL
$inputs.Var.dynamicDnsName = <System.String>
# OPTIONAL
$inputs.Var.ldapServers = @(
	@{
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		port = <System.Int32>
		# OPTIONAL
		useTls = <System.Boolean>
}
)
# OPTIONAL
$inputs.Var.userSearchFilter = <System.String>
# OPTIONAL
$inputs.Var.userNameAttr = <System.String>
# OPTIONAL
$inputs.Var.groupMembershipAttr = <System.String>
# OPTIONAL
$inputs.Var.groupSearchFilter = <System.String>
# OPTIONAL
$inputs.Var.groupMemberAttr = <System.String>
"@
    Write-Message "New-RscMutationLdap -UpdateIntegration" @"
    Mutate LDAP integration.
"@ "[GraphQL: updateLdapIntegration]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationLdap -RemoveIntegration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationLdap -RemoveIntegration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationLdap -RemoveIntegration
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.id = <System.String>
"@
    Write-Message "New-RscMutationLdap -RemoveIntegration" @"
    Remove LDAP integration.
"@ "[GraphQL: removeLdapIntegration]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationLdap -DeletePrincipals
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationLdap -DeletePrincipals).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationLdap -DeletePrincipals
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.principalIds = @(
	<System.String>
)
"@
    Write-Message "New-RscMutationLdap -DeletePrincipals" @"
    
"@ "[GraphQL: deleteLdapPrincipals]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationLdap -SetMfaSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationLdap -SetMfaSetting).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationLdap -SetMfaSetting
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	ldapId = <System.String>
	# OPTIONAL
	isTotpEnforced = <System.Boolean>
}
"@
    Write-Message "New-RscMutationLdap -SetMfaSetting" @"
    Update the MFA settings for the given LDAP integration. Return true when the operation succeeds.
"@ "[GraphQL: setLdapMfaSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationMongo -AddSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -AddSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -AddSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	mongoSourceAddRequestConfig = @{
		# OPTIONAL
		caCertfilePath = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sslKeyfilePath = <System.String>
		# OPTIONAL
		sslCertfilePath = <System.String>
		# REQUIRED
		mongoType = <MongoType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = <MongoSslCertificateRequirement> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
		# REQUIRED
		mongoClientHosts = @(
			@{
				# REQUIRED
				configurationPort = <System.Int32>
				# REQUIRED
				hostId = <System.String>
			}
		)
		# REQUIRED
		sourceName = <System.String>
	}
}
"@
    Write-Message "New-RscMutationMongo -AddSource" @"
    Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.
"@ "[GraphQL: addMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -DeleteSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -DeleteSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -DeleteSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMongo -DeleteSource" @"
    Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.
"@ "[GraphQL: deleteMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -DiscoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -DiscoverSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -DiscoverSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMongo -DiscoverSource" @"
    Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.
"@ "[GraphQL: discoverMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -PatchSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -PatchSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -PatchSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	mongoSourcePatchRequestConfig = @{
		# OPTIONAL
		caCertfilePath = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sslKeyfilePath = <System.String>
		# OPTIONAL
		sslCertfilePath = <System.String>
		# OPTIONAL
		sslCertificateRequired = <MongoSslCertificateRequirement> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
	}
}
"@
    Write-Message "New-RscMutationMongo -PatchSource" @"
    Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.
"@ "[GraphQL: patchMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -RetryAddSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -RetryAddSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -RetryAddSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	mongoSourceRequestConfig = @{
		# OPTIONAL
		caCertfilePath = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sslKeyfilePath = <System.String>
		# OPTIONAL
		sslCertfilePath = <System.String>
		# REQUIRED
		mongoType = <MongoType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoType]) for enum values.
		# OPTIONAL
		sslCertificateRequired = <MongoSslCertificateRequirement> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MongoSslCertificateRequirement]) for enum values.
		# REQUIRED
		mongoClientHosts = @(
			@{
				# REQUIRED
				configurationPort = <System.Int32>
				# REQUIRED
				hostId = <System.String>
			}
		)
		# REQUIRED
		sourceName = <System.String>
	}
}
"@
    Write-Message "New-RscMutationMongo -RetryAddSource" @"
    Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.
"@ "[GraphQL: retryAddMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -AssignSlaToDbCollection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -AssignSlaToDbCollection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -AssignSlaToDbCollection
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	input = @{
		# REQUIRED
		ids = @(
			<System.String>
		)
		# REQUIRED
		slaId = <System.String>
	}
}
"@
    Write-Message "New-RscMutationMongo -AssignSlaToDbCollection" @"
    Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.
"@ "[GraphQL: assignSlaToMongoDbCollection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -RecoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -RecoverSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -RecoverSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	input = @{
		# OPTIONAL
		prefix = <System.String>
		# OPTIONAL
		restoreDbPassword = <System.String>
		# OPTIONAL
		restoreDbUsername = <System.String>
		# OPTIONAL
		shouldDropExistingCollection = <System.Boolean>
		# OPTIONAL
		sourceCollectionIds = @(
			<System.String>
		)
		# OPTIONAL
		sourceDatabaseIds = @(
			<System.String>
		)
		# OPTIONAL
		targetCollectionName = <System.String>
		# OPTIONAL
		targetDatabaseName = <System.String>
		# OPTIONAL
		versionTime = <DateTime>
		# OPTIONAL
		restoreThrottleInBytesPerSecond = <System.Int64>
		# OPTIONAL
		isRestoreWithIndex = <System.Boolean>
		# REQUIRED
		sourceMongoClusterId = <System.String>
		# REQUIRED
		targetMongoClusterId = <System.String>
	}
}
"@
    Write-Message "New-RscMutationMongo -RecoverSource" @"
    Recover a MongoDB source from Rubrik CDM cluster.
"@ "[GraphQL: recoverMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -CreatedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -CreatedbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -CreatedbSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# OPTIONAL
		cassandraYaml = @(
			<System.String>
		)
		# OPTIONAL
		dseYaml = @(
			<System.String>
		)
		# OPTIONAL
		enableSsl = <System.Boolean>
		# OPTIONAL
		httpsCertificate = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		jmxPassword = <System.String>
		# OPTIONAL
		jmxUser = <System.String>
		# OPTIONAL
		parameterEncoded = <System.Boolean>
		# OPTIONAL
		sourceAuthKey = <System.String>
		# OPTIONAL
		sourceAuthKeyfile = <System.String>
		# OPTIONAL
		sourceAuthPassphrase = <System.String>
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sourceHttpsPort = <System.String>
		# OPTIONAL
		sourcePassword = <System.String>
		# OPTIONAL
		sourcePort = <System.String>
		# OPTIONAL
		sourceRpcPort = <System.String>
		# OPTIONAL
		sourceSshPort = <System.String>
		# OPTIONAL
		sourceUser = <System.String>
		# OPTIONAL
		sslCaCerts = <System.String>
		# OPTIONAL
		sslCertfile = <System.String>
		# OPTIONAL
		sslKeyfile = <System.String>
		# REQUIRED
		sourceType = <SourceSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = <SourceSslCertReqs> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			<System.String>
		)
		# REQUIRED
		sourceName = <System.String>
	}
}
"@
    Write-Message "New-RscMutationMongo -CreatedbSource" @"
    Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.
"@ "[GraphQL: createMongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -UpdatedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -UpdatedbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -UpdatedbSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# OPTIONAL
		cassandraYaml = @(
			<System.String>
		)
		# OPTIONAL
		dseYaml = @(
			<System.String>
		)
		# OPTIONAL
		enableSsl = <System.Boolean>
		# OPTIONAL
		httpsCertificate = <System.String>
		# OPTIONAL
		ignoreSecondaries = @(
			<System.String>
		)
		# OPTIONAL
		jmxPassword = <System.String>
		# OPTIONAL
		jmxUser = <System.String>
		# OPTIONAL
		parameterEncoded = <System.Boolean>
		# OPTIONAL
		sourceAuthKey = <System.String>
		# OPTIONAL
		sourceAuthKeyfile = <System.String>
		# OPTIONAL
		sourceAuthPassphrase = <System.String>
		# OPTIONAL
		sourceDriverPassword = <System.String>
		# OPTIONAL
		sourceDriverUser = <System.String>
		# OPTIONAL
		sourceHttpsPort = <System.String>
		# OPTIONAL
		sourcePassword = <System.String>
		# OPTIONAL
		sourcePort = <System.String>
		# OPTIONAL
		sourceRpcPort = <System.String>
		# OPTIONAL
		sourceSshPort = <System.String>
		# OPTIONAL
		sourceUser = <System.String>
		# OPTIONAL
		sslCaCerts = <System.String>
		# OPTIONAL
		sslCertfile = <System.String>
		# OPTIONAL
		sslKeyfile = <System.String>
		# REQUIRED
		sourceType = <SourceSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSourceType]) for enum values.
		# OPTIONAL
		sslCertReqs = <SourceSslCertReqs> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SourceSslCertReqs]) for enum values.
		# REQUIRED
		sourceIp = @(
			<System.String>
		)
		# REQUIRED
		sourceName = <System.String>
	}
}
"@
    Write-Message "New-RscMutationMongo -UpdatedbSource" @"
    Modifies configuration for a registered MongoDB source in NoSQL cluster.
"@ "[GraphQL: updateMongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -DeletedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -DeletedbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -DeletedbSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	sourceType = <V2DeleteMosaicSourceRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2DeleteMosaicSourceRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceName = <System.String>
}
"@
    Write-Message "New-RscMutationMongo -DeletedbSource" @"
    Remove a registered MongoDB source from NoSQL cluster.
"@ "[GraphQL: deleteMongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -BulkDeletedbSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -BulkDeletedbSources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -BulkDeletedbSources
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	sourceType = <V2BulkDeleteMosaicSourcesRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2BulkDeleteMosaicSourcesRequestSourceType]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	sourceData = @{
		# OPTIONAL
		async = <System.Boolean>
		# REQUIRED
		sourceNames = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscMutationMongo -BulkDeletedbSources" @"
    Bulk Delete Sources

Supported in m3.2.0-m4.2.0.
"@ "[GraphQL: bulkDeleteMongodbSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMongo -RecoverdbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMongo -RecoverdbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMongo -RecoverdbSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryData = @{
		# OPTIONAL
		destinationManagementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# OPTIONAL
		destinationSourceName = <System.String>
		# OPTIONAL
		keyspaceConfig = <System.String>
		# OPTIONAL
		maxDiskUsage = <System.String>
		# OPTIONAL
		restoreDbUserPwd = <System.String>
		# OPTIONAL
		restoreDbUsername = <System.String>
		# OPTIONAL
		startTimestamp = <System.Int32>
		# OPTIONAL
		targetEncryptionKey = <System.String>
		# OPTIONAL
		targetQuery = <System.String>
		# OPTIONAL
		sourceType = <MosaicRetrieveRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRetrieveRequestSourceType]) for enum values.
		# REQUIRED
		destinationPath = <System.String>
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# REQUIRED
		parameterEncoded = <System.Boolean>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		versionTime = <System.Int32>
	}
}
"@
    Write-Message "New-RscMutationMongo -RecoverdbSource" @"
    Recover a MongoDB source from NoSQL cluster.
"@ "[GraphQL: recoverMongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationMssql -BrowseDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -BrowseDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -BrowseDatabaseSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		endPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# OPTIONAL
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# OPTIONAL
		startPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# OPTIONAL
		backupType = <MssqlBackupType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlBackupType]) for enum values.
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -BrowseDatabaseSnapshot" @"
    List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.
"@ "[GraphQL: browseMssqlDatabaseSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -ExportDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -ExportDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -ExportDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		allowOverwrite = <System.Boolean>
		# OPTIONAL
		finishRecovery = <System.Boolean>
		# OPTIONAL
		maxDataStreams = <System.Int32>
		# OPTIONAL
		targetDataFilePath = <System.String>
		# OPTIONAL
		targetFilePaths = @(
			@{
				# OPTIONAL
				newFilename = <System.String>
				# OPTIONAL
				newLogicalName = <System.String>
				# REQUIRED
				exportPath = <System.String>
				# REQUIRED
				logicalName = <System.String>
			}
		)
		# OPTIONAL
		targetLogFilePath = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
		# REQUIRED
		targetDatabaseName = <System.String>
		# REQUIRED
		targetInstanceId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -ExportDatabase" @"
    Create a request to export a Microsoft SQL database.
"@ "[GraphQL: exportMssqlDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -RestoreDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -RestoreDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -RestoreDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		finishRecovery = <System.Boolean>
		# OPTIONAL
		maxDataStreams = <System.Int32>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -RestoreDatabase" @"
    Create a request to restore a Microsoft SQL database.
"@ "[GraphQL: restoreMssqlDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -BulkUpdateDbs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -BulkUpdateDbs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -BulkUpdateDbs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbsUpdateProperties = @(
		@{
			# REQUIRED
			databaseId = <System.String>
			# REQUIRED
			updateProperties = @{
				# OPTIONAL
				configuredSlaDomainId = <System.String>
				# OPTIONAL
				maxDataStreams = <System.Int32>
				# OPTIONAL
				postBackupScript = @{
					# REQUIRED
					scriptErrorAction = <ScriptErrorAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
					# REQUIRED
					scriptPath = <System.String>
					# REQUIRED
					timeoutMs = <System.Int64>
				}
				# OPTIONAL
				preBackupScript = @{
					# REQUIRED
					scriptErrorAction = <ScriptErrorAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ScriptErrorAction]) for enum values.
					# REQUIRED
					scriptPath = <System.String>
					# REQUIRED
					timeoutMs = <System.Int64>
				}
				# OPTIONAL
				isPaused = <System.Boolean>
				# OPTIONAL
				shouldForceFull = <System.Boolean>
				# OPTIONAL
				mssqlNonSlaProperties = @{
					# OPTIONAL
					copyOnly = <System.Boolean>
					# OPTIONAL
					logBackupFrequencyInSeconds = <System.Int32>
					# OPTIONAL
					logRetentionHours = <System.Int32>
				}
				# OPTIONAL
				mssqlSlaPatchProperties = @{
					# OPTIONAL
					configuredSlaDomainId = <System.String>
					# OPTIONAL
					useConfiguredDefaultLogRetention = <System.Boolean>
					# OPTIONAL
					mssqlSlaRelatedProperties = @{
						# OPTIONAL
						copyOnly = <System.Boolean>
						# OPTIONAL
						logBackupFrequencyInSeconds = <System.Int32>
						# OPTIONAL
						logRetentionHours = <System.Int32>
						# OPTIONAL
						hasLogConfigFromSla = <System.Boolean>
						# OPTIONAL
						hostLogRetention = <System.Int32>
					}
				}
				# OPTIONAL
				mssqlSlaRelatedProperties = @{
					# OPTIONAL
					copyOnly = <System.Boolean>
					# OPTIONAL
					logBackupFrequencyInSeconds = <System.Int32>
					# OPTIONAL
					logRetentionHours = <System.Int32>
					# OPTIONAL
					hasLogConfigFromSla = <System.Boolean>
					# OPTIONAL
					hostLogRetention = <System.Int32>
				}
			}
		}
	)
}
"@
    Write-Message "New-RscMutationMssql -BulkUpdateDbs" @"
    Update multiple Microsoft SQL databases with the specified properties.
"@ "[GraphQL: bulkUpdateMssqlDbs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -TakeLogBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -TakeLogBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -TakeLogBackup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -TakeLogBackup" @"
    Take an on-demand log backup for a Microsoft SQL database.
"@ "[GraphQL: takeMssqlLogBackup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -CreateOnDemandBackup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		forceFullSnapshot = <System.Boolean>
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -CreateOnDemandBackup" @"
    Take an on-demand backup of a Microsoft SQL Database
"@ "[GraphQL: createOnDemandMssqlBackup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -DeleteDbSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -DeleteDbSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -DeleteDbSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -DeleteDbSnapshots" @"
    Delete snapshots of a Microsoft SQL Database.
"@ "[GraphQL: deleteMssqlDbSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -DeleteLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -DeleteLiveMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -DeleteLiveMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -DeleteLiveMount" @"
    Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.
"@ "[GraphQL: deleteMssqlLiveMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -BulkCreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -BulkCreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -BulkCreateOnDemandBackup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		availabilityGroupIds = @(
			<System.String>
		)
		# OPTIONAL
		databaseIds = @(
			<System.String>
		)
		# OPTIONAL
		forceFullSnapshot = <System.Boolean>
		# OPTIONAL
		hostIds = @(
			<System.String>
		)
		# OPTIONAL
		instanceIds = @(
			<System.String>
		)
		# OPTIONAL
		windowsClusterIds = @(
			<System.String>
		)
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = <System.String>
		}
	}
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -BulkCreateOnDemandBackup" @"
    Take a bulk on-demand backup of a Microsoft SQL Database.
"@ "[GraphQL: bulkCreateOnDemandMssqlBackup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -CreateLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -CreateLiveMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -CreateLiveMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetInstanceId = <System.String>
		# OPTIONAL
		recoveryModel = <MssqlDatabaseRecoveryModel> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseRecoveryModel]) for enum values.
		# REQUIRED
		mountedDatabaseName = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -CreateLiveMount" @"
    Create live mount of a Microsoft SQL Database.
"@ "[GraphQL: createMssqlLiveMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -UpdateLogShippingConfiguration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -UpdateLogShippingConfiguration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -UpdateLogShippingConfiguration
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		makeupReseedLimit = <System.Int32>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -UpdateLogShippingConfiguration" @"
    Update log shipping configuration of a Microsoft SQL Database.
"@ "[GraphQL: updateMssqlLogShippingConfiguration]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			lsnPoint = @{
				# OPTIONAL
				recoveryForkGuid = <System.String>
				# REQUIRED
				lsn = <System.String>
			}
			# OPTIONAL
			timestampMs = <System.Int64>
			# OPTIONAL
			date = <DateTime>
		}
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -DownloadDatabaseFilesFromArchivalLocation" @"
    Download Microsoft SQL Database backup files from archival location.
"@ "[GraphQL: downloadMssqlDatabaseFilesFromArchivalLocation]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -DownloadDatabaseBackupFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -DownloadDatabaseBackupFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -DownloadDatabaseBackupFiles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# REQUIRED
		items = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -DownloadDatabaseBackupFiles" @"
    Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.
"@ "[GraphQL: downloadMssqlDatabaseBackupFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -AssignSlaDomainProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -AssignSlaDomainProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -AssignSlaDomainProperties
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	updateInfo = @{
		# OPTIONAL
		shouldApplyToExistingSnapshots = <System.Boolean>
		# OPTIONAL
		shouldApplyToNonPolicySnapshots = <System.Boolean>
		# OPTIONAL
		mssqlSlaPatchProperties = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			useConfiguredDefaultLogRetention = <System.Boolean>
			# OPTIONAL
			mssqlSlaRelatedProperties = @{
				# OPTIONAL
				copyOnly = <System.Boolean>
				# OPTIONAL
				logBackupFrequencyInSeconds = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				hostLogRetention = <System.Int32>
			}
		}
		# OPTIONAL
		existingSnapshotRetention = <ExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscMutationMssql -AssignSlaDomainProperties" @"
    Assign SLA domain properties to Mssql objects.
"@ "[GraphQL: assignMssqlSlaDomainProperties]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -UpdateDefaultProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -UpdateDefaultProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -UpdateDefaultProperties
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	defaultProperties = @{
		# OPTIONAL
		cbtStatus = <System.Boolean>
		# OPTIONAL
		logBackupFrequencyInSeconds = <System.Int64>
		# OPTIONAL
		logRetentionTimeInHours = <System.Int32>
		# OPTIONAL
		shouldUseDefaultBackupLocation = <System.Boolean>
	}
}
"@
    Write-Message "New-RscMutationMssql -UpdateDefaultProperties" @"
    Update the default properties for Microsoft SQL databases.
"@ "[GraphQL: updateMssqlDefaultProperties]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -CreateLogShippingConfiguration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -CreateLogShippingConfiguration).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -CreateLogShippingConfiguration
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		makeupReseedLimit = <System.Int32>
		# OPTIONAL
		mssqlLogShippingCreateConfig = @{
			# OPTIONAL
			maxDataStreams = <System.Int32>
			# OPTIONAL
			targetDataFilePath = <System.String>
			# OPTIONAL
			targetFilePaths = @(
				@{
					# OPTIONAL
					newFilename = <System.String>
					# OPTIONAL
					newLogicalName = <System.String>
					# REQUIRED
					exportPath = <System.String>
					# REQUIRED
					logicalName = <System.String>
				}
			)
			# OPTIONAL
			targetLogFilePath = <System.String>
			# OPTIONAL
			mssqlLogShippingTargetStateOptions = @{
				# OPTIONAL
				shouldDisconnectStandbyUsers = <System.Boolean>
				# REQUIRED
				state = <MssqlLogShippingOkState> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingOkState]) for enum values.
			}
			# REQUIRED
			targetDatabaseName = <System.String>
			# REQUIRED
			targetInstanceId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -CreateLogShippingConfiguration" @"
    Create log shipping configuration of a Microsoft SQL Database.
"@ "[GraphQL: createMssqlLogShippingConfiguration]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationMssql -AssignSlaDomainPropertiesAsync
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationMssql -AssignSlaDomainPropertiesAsync).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationMssql -AssignSlaDomainPropertiesAsync
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	updateInfo = @{
		# OPTIONAL
		shouldApplyToExistingSnapshots = <System.Boolean>
		# OPTIONAL
		shouldApplyToNonPolicySnapshots = <System.Boolean>
		# OPTIONAL
		mssqlSlaPatchProperties = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			useConfiguredDefaultLogRetention = <System.Boolean>
			# OPTIONAL
			mssqlSlaRelatedProperties = @{
				# OPTIONAL
				copyOnly = <System.Boolean>
				# OPTIONAL
				logBackupFrequencyInSeconds = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				hostLogRetention = <System.Int32>
			}
		}
		# OPTIONAL
		existingSnapshotRetention = <ExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ExistingSnapshotRetention]) for enum values.
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationMssql -AssignSlaDomainPropertiesAsync" @"
    Assign SLA domain properties to Mssql objects.
"@ "[GraphQL: assignMssqlSlaDomainPropertiesAsync]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationNutanix -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -CreateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -CreateCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	nutanixClusterConfig = @{
		# REQUIRED
		caCerts = <System.String>
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		nutanixClusterUuid = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}
"@
    Write-Message "New-RscMutationNutanix -CreateCluster" @"
    Add Nutanix cluster

Supported in v5.0+
Create a Nutanix cluster object by providing an address and account credentials for Prism. Initiates an asynchronous job to establish a connection with the cluster and retrieve all metadata. Use GET /nutanix_cluster/{id}/status to check status.
"@ "[GraphQL: createNutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -RefreshCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -RefreshCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -RefreshCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -RefreshCluster" @"
    Refresh Nutanix cluster metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Nutanix cluster.
"@ "[GraphQL: refreshNutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -UpdateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -UpdateCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -UpdateCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		username = <System.String>
	}
}
"@
    Write-Message "New-RscMutationNutanix -UpdateCluster" @"
    Patch Nutanix cluster

Supported in v5.0+
Patch the host, credentials, and/or CA certs of the specified Nutanix cluster object.
"@ "[GraphQL: updateNutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeleteCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeleteCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -DeleteCluster" @"
    Remove Nutanix cluster

Supported in v5.0+
Initiates an asynchronous job to remove a Nutanix cluster object. The Nutanix cluster cannot have VMs mounted through the Rubrik cluster.
"@ "[GraphQL: deleteNutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -RegisterAgentVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -RegisterAgentVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -RegisterAgentVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -RegisterAgentVm" @"
    v5.0-v8.0: Register the agent installed on the Nutanix VM
v8.1+: Register the agent installed on the Nutanix virtual machine

Supported in v5.0+
v5.0-v5.3: Register the agent installed on the Nutanix VM
v6.0-v8.0: Register the agent installed on the Nutanix VM.
v8.1+: Register the agent installed on the Nutanix virtual machine.
"@ "[GraphQL: registerAgentNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -UpdateVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -UpdateVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -UpdateVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmPatchProperties = @{
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		excludedDiskIds = @(
			<System.String>
		)
		# OPTIONAL
		isPaused = <System.Boolean>
		# OPTIONAL
		postBackupScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		postSnapScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		preBackupScript = @{
			# REQUIRED
			failureHandling = <NutanixVirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixVirtualMachineScriptDetailFailureHandling]) for enum values.
			# REQUIRED
			scriptPath = <System.String>
			# REQUIRED
			timeoutMs = <System.Int64>
		}
		# OPTIONAL
		snapshotConsistencyMandate = <CdmNutanixSnapshotConsistencyMandate> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmNutanixSnapshotConsistencyMandate]) for enum values.
	}
}
"@
    Write-Message "New-RscMutationNutanix -UpdateVm" @"
    v5.0-v8.0: Patch VM
v8.1+: Patch virtual machine

Supported in v5.0+
v5.0-v5.3: Patch VM with specified properties
v6.0-v8.0: Patch VM with specified properties.
v8.1+: Patch virtual machine with specified properties.
"@ "[GraphQL: updateNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -CreateOnDemandBackup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -CreateOnDemandBackup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -CreateOnDemandBackup" @"
    v5.0-v8.0: Create on-demand VM snapshot
v8.1+: Create on-demand virtual machine snapshot

Supported in v5.0+
v5.0-v5.3: Create an on-demand snapshot for the given VM ID
v6.0-v8.0: Create an on-demand snapshot for the given VM ID.
v8.1+: Create an on-demand snapshot for the given virtual machine ID.
"@ "[GraphQL: createOnDemandNutanixBackup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeleteSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeleteSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeleteSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -DeleteSnapshots" @"
    v5.0-v8.0: Delete all snapshots of VM
v8.1+: Delete all snapshots of virtual machine

Supported in v5.0+
Delete all snapshots of a virtual machine.
"@ "[GraphQL: deleteNutanixSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -MountSnapshotV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -MountSnapshotV1).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -MountSnapshotV1
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		containerNaturalId = <System.String>
		# OPTIONAL
		nutanixClusterId = <System.String>
		# OPTIONAL
		shouldMigrateImmediately = <System.Boolean>
		# OPTIONAL
		shouldPowerOn = <System.Boolean>
		# OPTIONAL
		shouldRemoveNetwork = <System.Boolean>
		# OPTIONAL
		targetNetwork = <System.String>
		# OPTIONAL
		vmName = <System.String>
		# OPTIONAL
		keepMacAddresses = <System.Boolean>
		# OPTIONAL
		nicNetworkUuids = @(
			<System.String>
		)
		# REQUIRED
		shouldDisableMigration = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -MountSnapshotV1" @"
    Initiate a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to perform a Live Mount of a Nutanix virtual machine snapshot identified by the snapshot ID.
"@ "[GraphQL: mountNutanixSnapshotV1]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -PatchMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -PatchMountV1).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -PatchMountV1
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		shouldPowerOn = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -PatchMountV1" @"
    Change Nutanix Live Mount power status

Supported in v6.0+
Changes the power status of a mounted Nutanix virtual machine.
"@ "[GraphQL: patchNutanixMountV1]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeleteMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeleteMountV1).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeleteMountV1
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -DeleteMountV1" @"
    Remove a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to remove a Live Mount of a Nutanix virtual machine snapshot identified by the ID of the Live Mount.
"@ "[GraphQL: deleteNutanixMountV1]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -MigrateMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -MigrateMountV1).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -MigrateMountV1
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -MigrateMountV1" @"
    Relocate a Nutanix virtual machine to another storage container

Supported in v6.0+
Initiate a request to migrate the virtual disks of a specified Nutanix Live Mount to another storage container. The destination storage container has been specified when the Live Mount was created. The Live Mount will be deleted when the relocation succeeds.
"@ "[GraphQL: migrateNutanixMountV1]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeleteSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeleteSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeleteSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <InternalDeleteNutanixSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteNutanixSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -DeleteSnapshot" @"
    v5.0-v8.0: Delete VM snapshot
v8.1+: Delete virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.
v8.1+: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected virtual machine.
"@ "[GraphQL: deleteNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -RestoreFilesSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -RestoreFilesSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -RestoreFilesSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVirtualMachineId = <System.String>
		# REQUIRED
		restoreConfig = @(
			@{
				# REQUIRED
				path = <System.String>
				# REQUIRED
				restorePath = <System.String>
			}
		)
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -RestoreFilesSnapshot" @"
    Restore files

Supported in v5.0+
Restore files from a snapshot to the source Nutanix virtual machine.
"@ "[GraphQL: restoreFilesNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DownloadFilesSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DownloadFilesSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DownloadFilesSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		legalHoldDownloadConfig = @{
			# REQUIRED
			isLegalHoldDownload = <System.Boolean>
		}
		# REQUIRED
		paths = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -DownloadFilesSnapshot" @"
    v5.0-v8.0: Download files from a Nutanix VM backup
v8.1+: Download files from a Nutanix virtual machine backup

Supported in v5.0+
v5.0-v8.0: Start an asynchronous job to download multiple files and folders from a specified Nutanix VM backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
v8.1+: Start an asynchronous job to download multiple files and folders from a specified Nutanix virtual machine backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
"@ "[GraphQL: downloadFilesNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -ExportSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -ExportSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -ExportSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		nutanixClusterId = <System.String>
		# OPTIONAL
		powerOn = <System.Boolean>
		# OPTIONAL
		removeNetworkDevices = <System.Boolean>
		# OPTIONAL
		vmName = <System.String>
		# OPTIONAL
		keepMacAddresses = <System.Boolean>
		# OPTIONAL
		nicNetworkUuids = @(
			<System.String>
		)
		# REQUIRED
		containerNaturalId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -ExportSnapshot" @"
    v5.0-v8.0: Export VM snapshot
v8.1+: Export virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Export snapshot of a vm.
v8.1+: Export snapshot of a virtual machine.
"@ "[GraphQL: exportNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DownloadSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DownloadSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -DownloadSnapshot" @"
    Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
"@ "[GraphQL: downloadNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -BatchExportVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -BatchExportVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -BatchExportVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				exportConfig = @{
					# OPTIONAL
					nutanixClusterId = <System.String>
					# OPTIONAL
					powerOn = <System.Boolean>
					# OPTIONAL
					removeNetworkDevices = <System.Boolean>
					# OPTIONAL
					vmName = <System.String>
					# OPTIONAL
					keepMacAddresses = <System.Boolean>
					# OPTIONAL
					nicNetworkUuids = @(
						<System.String>
					)
					# REQUIRED
					containerNaturalId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationNutanix -BatchExportVm" @"
    Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.
"@ "[GraphQL: batchExportNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -BatchMountVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -BatchMountVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -BatchMountVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				mountConfig = @{
					# OPTIONAL
					containerNaturalId = <System.String>
					# OPTIONAL
					nutanixClusterId = <System.String>
					# OPTIONAL
					shouldMigrateImmediately = <System.Boolean>
					# OPTIONAL
					shouldPowerOn = <System.Boolean>
					# OPTIONAL
					shouldRemoveNetwork = <System.Boolean>
					# OPTIONAL
					targetNetwork = <System.String>
					# OPTIONAL
					vmName = <System.String>
					# OPTIONAL
					keepMacAddresses = <System.Boolean>
					# OPTIONAL
					nicNetworkUuids = @(
						<System.String>
					)
					# REQUIRED
					shouldDisableMigration = <System.Boolean>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationNutanix -BatchMountVm" @"
    Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.
"@ "[GraphQL: batchMountNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DownloadVmFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DownloadVmFromLocation).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DownloadVmFromLocation
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	downloadConfig = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -DownloadVmFromLocation" @"
    Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
"@ "[GraphQL: downloadNutanixVmFromLocation]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -CreatePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -CreatePrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -CreatePrismCentral
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	prismCentralConfig = @{
		# REQUIRED
		caCerts = <System.String>
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
	# REQUIRED
	prismElementCdmTuple = @(
		@{
			# REQUIRED
			nutanixClusterId = <System.String>
			# REQUIRED
			cdmClusterId = <System.String>
		}
	)
}
"@
    Write-Message "New-RscMutationNutanix -CreatePrismCentral" @"
    Add Nutanix Prism Central and it's corresponding Prism Elements

Supported in v9.0+
Create a Nutanix Prism Central object and refresh the Prism Elements present in it.
"@ "[GraphQL: createNutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -UpdatePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -UpdatePrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -UpdatePrismCentral
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	patchProperties = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		configuredSlaDomainId = <System.String>
		# OPTIONAL
		hostname = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		username = <System.String>
	}
}
"@
    Write-Message "New-RscMutationNutanix -UpdatePrismCentral" @"
    Patch Nutanix Prism Central

Supported in v9.0+
Patch the host and credentials of Nutanix Prism Central.
"@ "[GraphQL: updateNutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -DeletePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -DeletePrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -DeletePrismCentral
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -DeletePrismCentral" @"
    Remove Nutanix Prism Central

Supported in v9.0+
Initiates an asynchronous job to remove a Nutanix Prism Central object. The Nutanix Clusters attached to the Prism Central cannot have Virtual Machines mounted through the Rubrik cluster.
"@ "[GraphQL: deleteNutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -RefreshPrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -RefreshPrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -RefreshPrismCentral
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -RefreshPrismCentral" @"
    Refresh Nutanix Prism Central metadata

Supported in v9.0+
Initiates a job to refresh the metadata for the specified Nutanix Prism Central and all its associated clusters.
"@ "[GraphQL: refreshNutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationNutanix -BulkOnDemandSnapshotVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationNutanix -BulkOnDemandSnapshotVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationNutanix -BulkOnDemandSnapshotVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		vms = @(
			@{
				# REQUIRED
				backupConfig = @{
					# OPTIONAL
					slaId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationNutanix -BulkOnDemandSnapshotVm" @"
    Take an on-demand snapshot for selected Nutanix virtual machines

Supported in v9.0+
Take bulk backups for multiple Nutanix virtual machines.
"@ "[GraphQL: bulkOnDemandSnapshotNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationO365 -SaaSSetupKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -SaaSSetupKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -SaaSSetupKickoff
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscMutationO365 -SaaSSetupKickoff" @"
    
"@ "[GraphQL: o365SaaSSetupKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -PdlGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -PdlGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -PdlGroups
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	pdlAndWorkloadPairs = @(
		@{
			# REQUIRED
			pdl = <System.String>
			# REQUIRED
			workload = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
		}
	)
}
"@
    Write-Message "New-RscMutationO365 -PdlGroups" @"
    Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation.
"@ "[GraphQL: o365PdlGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -SaasSetupComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -SaasSetupComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -SaasSetupComplete
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	regionName = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	appTypes = @(
		<System.String>
	)
	# OPTIONAL
	kmsSpec = @{
		# OPTIONAL
		cloudType = <O365AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AzureCloudType]) for enum values.
		# OPTIONAL
		tenantId = <System.String>
		# OPTIONAL
		kmsId = <System.String>
		# OPTIONAL
		appId = <System.String>
		# OPTIONAL
		appSecret = <System.String>
		# OPTIONAL
		keyName = <System.String>
		# OPTIONAL
		kekNameColossus = <System.String>
	}
	# REQUIRED
	storeBackupInSameRegionAsData = <System.Boolean>
}
"@
    Write-Message "New-RscMutationO365 -SaasSetupComplete" @"
    Completes a Rubrik-Hosted setup flow.
"@ "[GraphQL: o365SaasSetupComplete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -SetupKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -SetupKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -SetupKickoff
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscMutationO365 -SetupKickoff" @"
    Kicks off an O365 subscription setup flow.
"@ "[GraphQL: o365SetupKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -AddOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -AddOrg).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -AddOrg
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	exocomputeClusterId = <System.String>
	# REQUIRED
	appTypes = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationO365 -AddOrg" @"
    Adds an O365 org to the account.
"@ "[GraphQL: addO365Org]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -OauthConsentKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -OauthConsentKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -OauthConsentKickoff
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	appType = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -OauthConsentKickoff" @"
    Kicks off the OAuth consent flow for an O365 Azure AD App.
"@ "[GraphQL: o365OauthConsentKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -OauthConsentComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -OauthConsentComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -OauthConsentComplete
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	tenantId = <System.String>
	# REQUIRED
	code = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	redirectUrl = <System.String>
	# REQUIRED
	resourceNaturalId = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -OauthConsentComplete" @"
    Completes the OAuth consent flow for an O365 Azure AD App.
"@ "[GraphQL: o365OauthConsentComplete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -CreateAppKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -CreateAppKickoff).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -CreateAppKickoff
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	appType = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -CreateAppKickoff" @"
    Kicks off the creation flow for an O365 Azure AD App.
"@ "[GraphQL: createO365AppKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -CreateAppComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -CreateAppComplete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -CreateAppComplete
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appClientId = <System.String>
	# REQUIRED
	stateToken = <System.String>
	# REQUIRED
	tenantId = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -CreateAppComplete" @"
    Completes the creation flow for an O365 Azure AD App.
"@ "[GraphQL: createO365AppComplete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -InsertCustomerApp
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -InsertCustomerApp).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -InsertCustomerApp
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	appType = <System.String>
	# REQUIRED
	appClientId = <System.String>
	# REQUIRED
	appClientSecret = <System.String>
	# REQUIRED
	subscriptionId = <System.String>
	# OPTIONAL
	base64AppCertificate = <System.String>
	# OPTIONAL
	base64AppPrivateKey = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -InsertCustomerApp" @"
    Inserts a Customer-hosted O365 Azure AD App.
"@ "[GraphQL: insertCustomerO365App]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -UpdateAppAuthStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -UpdateAppAuthStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -UpdateAppAuthStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	o365OrgId = <System.String>
	# REQUIRED
	o365AppId = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -UpdateAppAuthStatus" @"
    Update O365 App authentication status to applicable app version.
"@ "[GraphQL: updateO365AppAuthStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -UpdateAppPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -UpdateAppPermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -UpdateAppPermissions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	o365AppType = <O365AppType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AppType]) for enum values.
	# REQUIRED
	o365AppId = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -UpdateAppPermissions" @"
    Update O365 Azure app permission in Azure AD portal.
"@ "[GraphQL: updateO365AppPermissions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -DeleteAzureApp
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -DeleteAzureApp).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -DeleteAzureApp
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.o365AppClientId = <System.String>
# REQUIRED
$inputs.Var.o365AppType = <System.String>
"@
    Write-Message "New-RscMutationO365 -DeleteAzureApp" @"
    Deletes an O365 Azure AD App from the account.
"@ "[GraphQL: deleteO365AzureApp]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupMailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupMailbox
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.mailboxIds = @(
	<System.String>
)
"@
    Write-Message "New-RscMutationO365 -BackupMailbox" @"
    Backup mailbox workload.
"@ "[GraphQL: backupO365Mailbox]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupOnedrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupOnedrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupOnedrive
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationO365 -BackupOnedrive" @"
    Take on-demand snapshot for Onedrive.
"@ "[GraphQL: backupO365Onedrive]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupSharepointDrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupSharepointDrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupSharepointDrive
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationO365 -BackupSharepointDrive" @"
    Take on-demand snapshot for Sharepoint drive.
"@ "[GraphQL: backupO365SharepointDrive]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupSharepointList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupSharepointList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupSharepointList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuid = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -BackupSharepointList" @"
    Take on-demand snapshot for SharePoint list.
"@ "[GraphQL: backupO365SharepointList]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupSharePointSite
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupSharePointSite).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupSharePointSite
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	siteFid = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -BackupSharePointSite" @"
    Take on-demand snapshot for a SharePoint site.
"@ "[GraphQL: backupO365SharePointSite]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -BackupTeam
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -BackupTeam).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -BackupTeam
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscMutationO365 -BackupTeam" @"
    Take on-demand snapshot for Teams.
"@ "[GraphQL: backupO365Team]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RestoreTeamsFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RestoreTeamsFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RestoreTeamsFiles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filesToRestore = @(
		@{
			# REQUIRED
			fileId = <System.String>
			# REQUIRED
			fileName = <System.String>
			# REQUIRED
			fileSnapshotsToRestore = @(
				@{
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
					# REQUIRED
					fileSize = <System.Int64>
				}
			)
			# OPTIONAL
			channelInfo = @{
				# REQUIRED
				TeamID = <System.String>
				# OPTIONAL
				ChannelID = <System.String>
				# OPTIONAL
				ChannelName = <System.String>
				# OPTIONAL
				ChannelFolderName = <System.String>
				# OPTIONAL
				ChannelNaturalId = <System.String>
				# REQUIRED
				channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
		}
	)
	# REQUIRED
	foldersToRestore = @(
		@{
			# REQUIRED
			folderId = <System.String>
			# REQUIRED
			folderName = <System.String>
			# REQUIRED
			folderSize = <System.Int64>
			# REQUIRED
			snapshotId = <System.String>
			# REQUIRED
			snapshotNum = <System.Int32>
			# OPTIONAL
			channelInfo = @{
				# REQUIRED
				TeamID = <System.String>
				# OPTIONAL
				ChannelID = <System.String>
				# OPTIONAL
				ChannelName = <System.String>
				# OPTIONAL
				ChannelFolderName = <System.String>
				# OPTIONAL
				ChannelNaturalId = <System.String>
				# REQUIRED
				channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
		}
	)
	# OPTIONAL
	destTeamsChannelInfo = @{
		# REQUIRED
		TeamID = <System.String>
		# OPTIONAL
		ChannelID = <System.String>
		# OPTIONAL
		ChannelName = <System.String>
		# OPTIONAL
		ChannelFolderName = <System.String>
		# OPTIONAL
		ChannelNaturalId = <System.String>
		# REQUIRED
		channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldCreateDestChannel = <System.Boolean>
	# REQUIRED
	actionType = <O365RestoreActionType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
	# REQUIRED
	channelRecoveryType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# REQUIRED
	recoverWithLatestPermissions = <System.Boolean>
	# REQUIRED
	snapshotSequenceNum = <System.Int32>
}
"@
    Write-Message "New-RscMutationO365 -RestoreTeamsFiles" @"
    Restore Team files.
"@ "[GraphQL: restoreO365TeamsFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RestoreTeamsConversations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RestoreTeamsConversations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RestoreTeamsConversations
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	teamUuid = <System.String>
	# OPTIONAL
	destTeamsChannelInfo = @{
		# REQUIRED
		TeamID = <System.String>
		# OPTIONAL
		ChannelID = <System.String>
		# OPTIONAL
		ChannelName = <System.String>
		# OPTIONAL
		ChannelFolderName = <System.String>
		# OPTIONAL
		ChannelNaturalId = <System.String>
		# REQUIRED
		channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldCreateDestChannel = <System.Boolean>
	# OPTIONAL
	channelInfoForFullRestore = @{
		# REQUIRED
		naturalId = <System.String>
		# REQUIRED
		name = <System.String>
		# REQUIRED
		folderId = <System.String>
		# REQUIRED
		membershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	}
	# REQUIRED
	shouldRestoreFileAttachments = <System.Boolean>
	# REQUIRED
	teamChannels = @(
		@{
			# REQUIRED
			naturalId = <System.String>
			# REQUIRED
			name = <System.String>
			# REQUIRED
			folderId = <System.String>
			# REQUIRED
			membershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
		}
	)
	# OPTIONAL
	teamsConversationsSearchFilter = @{
		# OPTIONAL
		postedTime = @{
			# OPTIONAL
			fromTime = <DateTime>
			# OPTIONAL
			untilTime = <DateTime>
		}
		# OPTIONAL
		channelNaturalId = <System.String>
		# OPTIONAL
		postedBy = <System.String>
		# OPTIONAL
		snapshotId = <System.String>
		# OPTIONAL
		parentId = <System.String>
		# OPTIONAL
		convId = <System.String>
		# OPTIONAL
		snapshotNum = <System.Int32>
		# OPTIONAL
		includeArchived = <System.Boolean>
		# OPTIONAL
		fetchAllPostSenders = <System.String>
		# OPTIONAL
		skipPostsAttachments = <System.Boolean>
	}
	# REQUIRED
	refreshTokenEncrypted = <System.String>
	# REQUIRED
	o365AppId = <System.String>
	# REQUIRED
	channelRecoveryType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
	# REQUIRED
	recoverWithLatestPermissions = <System.Boolean>
	# REQUIRED
	snapshotSequenceNum = <System.Int32>
}
"@
    Write-Message "New-RscMutationO365 -RestoreTeamsConversations" @"
    Restore Team conversations.
"@ "[GraphQL: restoreO365TeamsConversations]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RestoreSnappable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RestoreSnappable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RestoreSnappable
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
	# REQUIRED
	sourceSnappableUuid = <System.String>
	# REQUIRED
	destinationSnappableUuid = <System.String>
	# REQUIRED
	restoreConfig = @{
		# OPTIONAL
		SharePointDriveRestoreConfig = @{
			# REQUIRED
			driveRestoreConfig = @{
				# REQUIRED
				filesToRestore = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				foldersToRestore = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				restoreFolderPath = <System.String>
			}
			# OPTIONAL
			docLibName = <System.String>
			# OPTIONAL
			parentSiteUuid = <System.String>
		}
		# OPTIONAL
		sharePointListRestoreConfig = @{
			# REQUIRED
			itemsToRestore = @(
				@{
					# REQUIRED
					itemId = <System.String>
					# REQUIRED
					itemName = <System.String>
					# REQUIRED
					itemSnapshotsToRestore = @(
						@{
							# REQUIRED
							snapshotId = <System.String>
							# REQUIRED
							snapshotNum = <System.Int32>
						}
					)
				}
			)
			# REQUIRED
			foldersToRestore = @(
				@{
					# REQUIRED
					folderId = <System.String>
					# REQUIRED
					folderName = <System.String>
					# REQUIRED
					folderSize = <System.Int64>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			restoreFolderPath = <System.String>
			# OPTIONAL
			listName = <System.String>
			# OPTIONAL
			parentSiteUuid = <System.String>
		}
		# OPTIONAL
		sharePointFullRestoreConfig = @{
			# OPTIONAL
			spObjectToRestore = @{
				# REQUIRED
				objectSharepointId = <System.String>
				# REQUIRED
				objectName = <System.String>
				# OPTIONAL
				objectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
				# REQUIRED
				snapshotId = <System.String>
				# REQUIRED
				snapshotNum = <System.Int32>
			}
			# OPTIONAL
			spItemsToRestore = @{
				# REQUIRED
				sharepointId = <System.String>
				# OPTIONAL
				snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
				# REQUIRED
				listItems = @(
					@{
						# REQUIRED
						itemId = <System.String>
						# REQUIRED
						itemName = <System.String>
						# REQUIRED
						itemSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
							}
						)
					}
				)
				# REQUIRED
				folderItems = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				fileItems = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				arePageLibraryItems = <System.Boolean>
			}
			# OPTIONAL
			targetObjectUuid = <System.String>
			# OPTIONAL
			targetObjectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
			# REQUIRED
			shouldCreateNewObject = <System.Boolean>
			# OPTIONAL
			newObjectType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
			# OPTIONAL
			newObjectName = <System.String>
		}
		# OPTIONAL
		OneDriveRestoreConfig = @{
			# REQUIRED
			filesToRestore = @(
				@{
					# REQUIRED
					fileId = <System.String>
					# REQUIRED
					fileName = <System.String>
					# REQUIRED
					fileSnapshotsToRestore = @(
						@{
							# REQUIRED
							snapshotId = <System.String>
							# REQUIRED
							snapshotNum = <System.Int32>
							# REQUIRED
							fileSize = <System.Int64>
						}
					)
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			foldersToRestore = @(
				@{
					# REQUIRED
					folderId = <System.String>
					# REQUIRED
					folderName = <System.String>
					# REQUIRED
					folderSize = <System.Int64>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
					# OPTIONAL
					channelInfo = @{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
						# REQUIRED
						channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
					}
				}
			)
			# REQUIRED
			restoreFolderPath = <System.String>
		}
		# OPTIONAL
		TeamsRestoreConfig = @{
			# OPTIONAL
			filesRestoreConfig = @{
				# REQUIRED
				filesToRestore = @(
					@{
						# REQUIRED
						fileId = <System.String>
						# REQUIRED
						fileName = <System.String>
						# REQUIRED
						fileSnapshotsToRestore = @(
							@{
								# REQUIRED
								snapshotId = <System.String>
								# REQUIRED
								snapshotNum = <System.Int32>
								# REQUIRED
								fileSize = <System.Int64>
							}
						)
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				foldersToRestore = @(
					@{
						# REQUIRED
						folderId = <System.String>
						# REQUIRED
						folderName = <System.String>
						# REQUIRED
						folderSize = <System.Int64>
						# REQUIRED
						snapshotId = <System.String>
						# REQUIRED
						snapshotNum = <System.Int32>
						# OPTIONAL
						channelInfo = @{
							# REQUIRED
							TeamID = <System.String>
							# OPTIONAL
							ChannelID = <System.String>
							# OPTIONAL
							ChannelName = <System.String>
							# OPTIONAL
							ChannelFolderName = <System.String>
							# OPTIONAL
							ChannelNaturalId = <System.String>
							# REQUIRED
							channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
						}
					}
				)
				# REQUIRED
				restoreFolderPath = <System.String>
			}
			# OPTIONAL
			conversationsRestoreConfig = @{
				# OPTIONAL
				SearchFilter = @{
					# OPTIONAL
					PostedTime = @{
						# OPTIONAL
						FromTime = <System.Int64>
						# OPTIONAL
						UntilTime = <System.Int64>
					}
					# OPTIONAL
					PostedBy = <System.String>
					# OPTIONAL
					SnapshotId = <System.String>
				}
				# OPTIONAL
				ChannelInfoForFullRestore = @{
					# REQUIRED
					TeamID = <System.String>
					# OPTIONAL
					ChannelID = <System.String>
					# OPTIONAL
					ChannelName = <System.String>
					# OPTIONAL
					ChannelFolderName = <System.String>
					# OPTIONAL
					ChannelFolderId = <System.String>
					# OPTIONAL
					ChannelNaturalId = <System.String>
				}
				# REQUIRED
				RefreshTokenEncrypted = <System.String>
				# REQUIRED
				O365AppID = <System.String>
				# REQUIRED
				ChannelsToRestore = @(
					@{
						# REQUIRED
						TeamID = <System.String>
						# OPTIONAL
						ChannelID = <System.String>
						# OPTIONAL
						ChannelName = <System.String>
						# OPTIONAL
						ChannelFolderName = <System.String>
						# OPTIONAL
						ChannelFolderId = <System.String>
						# OPTIONAL
						ChannelNaturalId = <System.String>
					}
				)
				# REQUIRED
				ShouldRestoreFileAttachments = <System.Boolean>
			}
			# OPTIONAL
			destChannelInfo = @{
				# REQUIRED
				TeamID = <System.String>
				# OPTIONAL
				ChannelID = <System.String>
				# OPTIONAL
				ChannelName = <System.String>
				# OPTIONAL
				ChannelFolderName = <System.String>
				# OPTIONAL
				ChannelNaturalId = <System.String>
				# REQUIRED
				channelMembershipType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			}
			# REQUIRED
			shouldCreateDestChannel = <System.Boolean>
			# REQUIRED
			channelType = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
			# REQUIRED
			restoreLatestPermissions = <System.Boolean>
			# REQUIRED
			snapshotSequenceNum = <System.Int32>
		}
		# OPTIONAL
		MailboxRestoreConfig = @{
			# OPTIONAL
			SnapshotUUID = <System.String>
			# REQUIRED
			RestoreConfigs = @(
				@{
					# REQUIRED
					SnapshotUUID = <System.String>
					# OPTIONAL
					EmailID = <System.String>
					# OPTIONAL
					FolderID = <System.String>
				}
			)
		}
		# OPTIONAL
		calendarRestoreConfig = @{
			# REQUIRED
			eventsToRestore = @(
				@{
					# REQUIRED
					eventId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
			# REQUIRED
			calendarsToRestore = @(
				@{
					# REQUIRED
					calendarId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
			# REQUIRED
			calendarGroupsToRestore = @(
				@{
					# REQUIRED
					calendarGroupId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
				}
			)
		}
		# OPTIONAL
		contactsRestoreConfig = @{
			# REQUIRED
			contactsToRestore = @(
				@{
					# REQUIRED
					contactId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
				}
			)
			# REQUIRED
			contactFoldersToRestore = @(
				@{
					# REQUIRED
					contactFolderId = <System.String>
					# REQUIRED
					snapshotId = <System.String>
					# REQUIRED
					snapshotNum = <System.Int32>
				}
			)
		}
	}
	# REQUIRED
	actionType = <O365RestoreActionType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
}
"@
    Write-Message "New-RscMutationO365 -RestoreSnappable" @"
    Restores an O365 snappable.
"@ "[GraphQL: restoreO365Snappable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RefreshOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RefreshOrg).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RefreshOrg
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "New-RscMutationO365 -RefreshOrg" @"
    Refreshes an O365 org.
"@ "[GraphQL: refreshO365Org]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -DeleteOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -DeleteOrg).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -DeleteOrg
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "New-RscMutationO365 -DeleteOrg" @"
    Deletes an O365 org from the account.
"@ "[GraphQL: deleteO365Org]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -RestoreMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -RestoreMailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -RestoreMailbox
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.restoreConfig = @{
	# OPTIONAL
	orgUuid = <System.String>
	# REQUIRED
	mailboxUuid = <System.String>
	# OPTIONAL
	snapshotUuid = <System.String>
	# REQUIRED
	restoreConfigs = @(
		@{
			# REQUIRED
			SnapshotUUID = <System.String>
			# OPTIONAL
			EmailID = <System.String>
			# OPTIONAL
			FolderID = <System.String>
		}
	)
	# REQUIRED
	actionType = <O365RestoreActionType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365RestoreActionType]) for enum values.
}
"@
    Write-Message "New-RscMutationO365 -RestoreMailbox" @"
    Restores an Exchange mailbox.
"@ "[GraphQL: restoreO365Mailbox]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -ExportMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -ExportMailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -ExportMailbox
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.exportConfig = @{
	# OPTIONAL
	orgUuid = <System.String>
	# REQUIRED
	fromMailboxUuid = <System.String>
	# REQUIRED
	toMailboxUuid = <System.String>
	# OPTIONAL
	snapshotUuid = <System.String>
	# REQUIRED
	exportConfigs = @(
		@{
			# REQUIRED
			SnapshotUUID = <System.String>
			# OPTIONAL
			EmailID = <System.String>
			# OPTIONAL
			FolderID = <System.String>
		}
	)
}
"@
    Write-Message "New-RscMutationO365 -ExportMailbox" @"
    Exports an Exchange mailbox.
"@ "[GraphQL: exportO365Mailbox]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -SetServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -SetServiceAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -SetServiceAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.username = <System.String>
# REQUIRED
$inputs.Var.appPassword = <System.String>
# REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "New-RscMutationO365 -SetServiceAccount" @"
    Sets the service account for the org.
"@ "[GraphQL: setO365ServiceAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -EnableSharePoint
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -EnableSharePoint).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -EnableSharePoint
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	exocomputeClusterId = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -EnableSharePoint" @"
    Enables SharePoint protection in the exocompute cluster.
"@ "[GraphQL: enableO365SharePoint]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -EnableTeams
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -EnableTeams).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -EnableTeams
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.exocomputeClusterId = <System.String>
"@
    Write-Message "New-RscMutationO365 -EnableTeams" @"
    Enables Teams protection in the exocompute cluster.
"@ "[GraphQL: enableO365Teams]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -DeleteServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -DeleteServiceAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -DeleteServiceAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "New-RscMutationO365 -DeleteServiceAccount" @"
    Deletes the service account for an org.
"@ "[GraphQL: deleteO365ServiceAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationO365 -UpdateOrgCustomName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationO365 -UpdateOrgCustomName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationO365 -UpdateOrgCustomName
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgUuid = <System.String>
	# REQUIRED
	customName = <System.String>
}
"@
    Write-Message "New-RscMutationO365 -UpdateOrgCustomName" @"
    Update the custom name for an O365 Organization.
"@ "[GraphQL: updateO365OrgCustomName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationOracle -BulkUpdateHosts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -BulkUpdateHosts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -BulkUpdateHosts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			configuredSlaDomainIdDeprecated = <System.String>
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = <System.String>
					# REQUIRED
					order = <System.Int32>
				}
			)
			# OPTIONAL
			shouldDistributeBackupsAutomatically = <System.Boolean>
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = <System.Int32>
				# OPTIONAL
				hostMount = <System.String>
				# OPTIONAL
				logBackupFrequencyInMinutes = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				numChannels = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				shouldEnableHighFileCountSupport = <System.Boolean>
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = <System.Boolean>
				# OPTIONAL
				sectionSizeInGb = <System.Int32>
			}
		}
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscMutationOracle -BulkUpdateHosts" @"
    Update Oracle Hosts

Supported in v5.2+
Update properties to Oracle Host objects.
"@ "[GraphQL: bulkUpdateOracleHosts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -RefreshDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -RefreshDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -RefreshDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -RefreshDatabase" @"
    Refresh an Oracle database

Supported in v6.0+
Starts an asynchronous job to refresh the Oracle database metadata by querying the database instances on all the underlying hosts.
"@ "[GraphQL: refreshOracleDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -UpdateDataGuardGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -UpdateDataGuardGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -UpdateDataGuardGroup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		preferredDgMemberUniqueNames = @(
			<System.String>
		)
		# OPTIONAL
		shouldBackupFromPrimaryOnly = <System.Boolean>
		# OPTIONAL
		oracleUpdateCommon = @{
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hasLogConfigFromSla = <System.Boolean>
			# OPTIONAL
			shouldEnableHighFileCountSupport = <System.Boolean>
			# OPTIONAL
			shouldUseSecureThriftForDataTransfer = <System.Boolean>
			# OPTIONAL
			sectionSizeInGb = <System.Int32>
		}
	}
}
"@
    Write-Message "New-RscMutationOracle -UpdateDataGuardGroup" @"
    Update an Oracle Data Guard group

Supported in v6.0+
Update properties of an Oracle Data Guard group object.
"@ "[GraphQL: updateOracleDataGuardGroup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -DeleteAllDatabaseSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -DeleteAllDatabaseSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -DeleteAllDatabaseSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -DeleteAllDatabaseSnapshots" @"
    Delete Oracle database snapshots

Supported in v5.0+
Delete all snapshots for a specified Oracle database object. For the operation to succeed the referenced database must not be assigned to an SLA Domain.
"@ "[GraphQL: deleteAllOracleDatabaseSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -TakeOnDemandDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -TakeOnDemandDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -TakeOnDemandDatabaseSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		forceFullSnapshot = <System.Boolean>
		# OPTIONAL
		baseOnDemandSnapshotConfig = @{
			# OPTIONAL
			slaId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -TakeOnDemandDatabaseSnapshot" @"
    On-demand backup of an Oracle database

Supported in v5.0+
Create an asynchronous job for an on-demand snapshot of an Oracle database. The response includes an ID for the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
"@ "[GraphQL: takeOnDemandOracleDatabaseSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -TakeOnDemandLogSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -TakeOnDemandLogSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -TakeOnDemandLogSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -TakeOnDemandLogSnapshot" @"
    On-demand log backup for an Oracle database log

Supported in v5.0+
Create an asynchronous job for an on-demand backup of an Oracle database log. The response includes an ID for the asynchronous job request.  To see the status of the request, poll /oracle/request/{id}.
"@ "[GraphQL: takeOnDemandOracleLogSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -BulkUpdateRacs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -BulkUpdateRacs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -BulkUpdateRacs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			configuredSlaDomainIdDeprecated = <System.String>
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = <System.String>
					# REQUIRED
					order = <System.Int32>
				}
			)
			# OPTIONAL
			shouldDistributeBackupsAutomatically = <System.Boolean>
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = <System.Int32>
				# OPTIONAL
				hostMount = <System.String>
				# OPTIONAL
				logBackupFrequencyInMinutes = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				numChannels = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				shouldEnableHighFileCountSupport = <System.Boolean>
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = <System.Boolean>
				# OPTIONAL
				sectionSizeInGb = <System.Int32>
			}
		}
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscMutationOracle -BulkUpdateRacs" @"
    Update Oracle RACs

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle RAC.
"@ "[GraphQL: bulkUpdateOracleRacs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -ExportTablespace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -ExportTablespace).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -ExportTablespace
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		exposeAllLogs = <System.Boolean>
		# REQUIRED
		auxiliaryDestinationPath = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
		# REQUIRED
		tablespaceName = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -ExportTablespace" @"
    Export an Oracle tablespace

Supported in v5.0+
Request an asynchronous job to export an Oracle tablespace from a specified snapshot or timestamp.
"@ "[GraphQL: exportOracleTablespace]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -ValidateAcoFile
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -ValidateAcoFile).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -ValidateAcoFile
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	acoContentsBase64 = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	isLiveMount = <System.Boolean>
	# REQUIRED
	dbId = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -ValidateAcoFile" @"
    Validate Oracle ACO file

Supported in v6.0+
Validate the provided Oracle ACO (Advanced Cloning Options) file.
"@ "[GraphQL: validateOracleAcoFile]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -ValidateDatabaseBackups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -ValidateDatabaseBackups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -ValidateDatabaseBackups
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		numChannels = <System.Int32>
		# OPTIONAL
		sgaMaxSizeInMb = <System.Int64>
		# OPTIONAL
		targetMountPath = <System.String>
		# OPTIONAL
		targetOracleHome = <System.String>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
		# REQUIRED
		targetOracleHostOrRacId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -ValidateDatabaseBackups" @"
    Validate Oracle database backups

Supported in v5.3+
Queue a job to validate Oracle backups for a database snapshot or a specified timestamp.
"@ "[GraphQL: validateOracleDatabaseBackups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -BulkUpdateDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -BulkUpdateDatabases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -BulkUpdateDatabases
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	bulkUpdateProperties = @{
		# OPTIONAL
		oracleUpdate = @{
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			hostMount = <System.String>
			# OPTIONAL
			logBackupFrequencyInMinutes = <System.Int32>
			# OPTIONAL
			logRetentionHours = <System.Int32>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			hostLogRetentionHours = <System.Int32>
			# OPTIONAL
			configuredSlaDomainIdDeprecated = <System.String>
			# OPTIONAL
			nodeOrder = @(
				@{
					# REQUIRED
					nodeName = <System.String>
					# REQUIRED
					order = <System.Int32>
				}
			)
			# OPTIONAL
			shouldDistributeBackupsAutomatically = <System.Boolean>
			# OPTIONAL
			oracleUpdateCommon = @{
				# OPTIONAL
				hostLogRetentionHours = <System.Int32>
				# OPTIONAL
				hostMount = <System.String>
				# OPTIONAL
				logBackupFrequencyInMinutes = <System.Int32>
				# OPTIONAL
				logRetentionHours = <System.Int32>
				# OPTIONAL
				numChannels = <System.Int32>
				# OPTIONAL
				hasLogConfigFromSla = <System.Boolean>
				# OPTIONAL
				shouldEnableHighFileCountSupport = <System.Boolean>
				# OPTIONAL
				shouldUseSecureThriftForDataTransfer = <System.Boolean>
				# OPTIONAL
				sectionSizeInGb = <System.Int32>
			}
		}
		# REQUIRED
		ids = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscMutationOracle -BulkUpdateDatabases" @"
    Update Oracle Databases

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle Databases.
"@ "[GraphQL: bulkUpdateOracleDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -InstantRecoverSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -InstantRecoverSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -InstantRecoverSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		numChannels = <System.Int32>
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -InstantRecoverSnapshot" @"
    Instant recovery of a database

Supported in v5.0+
Creates an instant recover request that restores a target database from the given snapshot.
"@ "[GraphQL: instantRecoverOracleSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -MountDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -MountDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -MountDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	request = @{
		# REQUIRED
		config = @{
			# OPTIONAL
			shouldMountFilesOnly = <System.Boolean>
			# OPTIONAL
			targetMountPath = <System.String>
			# OPTIONAL
			advancedRecoveryConfigBase64 = <System.String>
			# OPTIONAL
			customPfilePath = <System.String>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			postScriptPath = <System.String>
			# OPTIONAL
			preScriptPath = <System.String>
			# OPTIONAL
			shouldStopRecoveryOnPreScriptFailure = <System.Boolean>
			# OPTIONAL
			pdbsToLiveMount = @(
				<System.String>
			)
			# OPTIONAL
			targetRacHostIds = @(
				<System.String>
			)
			# OPTIONAL
			lmDbName = <System.String>
			# OPTIONAL
			targetRacPrimaryHostId = <System.String>
			# OPTIONAL
			shouldAllowRenameToSource = <System.Boolean>
			# REQUIRED
			recoveryPoint = @{
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				timestampMs = <System.Int64>
			}
			# REQUIRED
			targetOracleHostOrRacId = <System.String>
		}
		# REQUIRED
		id = <System.String>
	}
	# OPTIONAL
	advancedRecoveryConfigMap = @(
		@{
			# OPTIONAL
			key = <System.String>
			# OPTIONAL
			value = <System.String>
		}
	)
}
"@
    Write-Message "New-RscMutationOracle -MountDatabase" @"
    Live Mount an Oracle database snapshot

Supported in v5.0+
Create an asynchronous job to Live Mount an Oracle database from a snapshot.
"@ "[GraphQL: mountOracleDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -ExportDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -ExportDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -ExportDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	request = @{
		# REQUIRED
		config = @{
			# OPTIONAL
			restoreFilesPath = <System.String>
			# OPTIONAL
			shouldRestoreFilesOnly = <System.Boolean>
			# OPTIONAL
			targetMountPath = <System.String>
			# OPTIONAL
			advancedRecoveryConfigBase64 = <System.String>
			# OPTIONAL
			archiveLogPath = <System.String>
			# OPTIONAL
			cloneDbName = <System.String>
			# OPTIONAL
			customPfilePath = <System.String>
			# OPTIONAL
			numChannels = <System.Int32>
			# OPTIONAL
			postScriptPath = <System.String>
			# OPTIONAL
			preScriptPath = <System.String>
			# OPTIONAL
			shouldStopRecoveryOnPreScriptFailure = <System.Boolean>
			# OPTIONAL
			pdbsToClone = @(
				<System.String>
			)
			# OPTIONAL
			shouldSkipDropDbInUndo = <System.Boolean>
			# OPTIONAL
			shouldAllowRenameToSource = <System.Boolean>
			# REQUIRED
			recoveryPoint = @{
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				timestampMs = <System.Int64>
			}
			# REQUIRED
			targetOracleHostOrRacId = <System.String>
		}
		# REQUIRED
		id = <System.String>
	}
	# OPTIONAL
	advancedRecoveryConfigMap = @(
		@{
			# OPTIONAL
			key = <System.String>
			# OPTIONAL
			value = <System.String>
		}
	)
}
"@
    Write-Message "New-RscMutationOracle -ExportDatabase" @"
    Export an Oracle database

Supported in v5.0+
Request an asynchronous job to export an Oracle database from a specified snapshot or timestamp.
"@ "[GraphQL: exportOracleDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -CreatePdbRestore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -CreatePdbRestore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -CreatePdbRestore
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		pdbsToRestore = @(
			<System.String>
		)
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -CreatePdbRestore" @"
    Restore PDBs on an Oracle database

Supported in v8.0+
Initiates an asynchronous request to restore PDBs on an Oracle database from a specified snapshot or timestamp.
"@ "[GraphQL: createOraclePdbRestore]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -DownloadDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -DownloadDatabaseSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -DownloadDatabaseSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -DownloadDatabaseSnapshot" @"
    Download Oracle snapshot from cloud

Supported in v5.0+
Create an asynchronous job to download an Oracle database snapshot and associated logs using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
"@ "[GraphQL: downloadOracleDatabaseSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -DeleteMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -DeleteMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -DeleteMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -DeleteMount" @"
    Delete an Oracle database Live Mount

Supported in v5.0+
Request an asynchronous job to delete a specified Live Mount of an Oracle database snapshot. Poll the job status by using /oracle/request/{id}.
"@ "[GraphQL: deleteOracleMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationOracle -RestoreLogs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationOracle -RestoreLogs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationOracle -RestoreLogs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetMountPath = <System.String>
		# REQUIRED
		oracleLogRecoveryRange = @{
			# OPTIONAL
			oracleTimeRange = @{
				# OPTIONAL
				endTime = <DateTime>
				# OPTIONAL
				startTime = <DateTime>
			}
		}
		# REQUIRED
		shouldMountFilesOnly = <System.Boolean>
		# REQUIRED
		targetOracleHostOrRacId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationOracle -RestoreLogs" @"
    Restore archive logs of an Oracle database

Supported in v6.0+
v6.0: Create an asynchronous job to restore archive logs of an Oracle database.
v7.0+: Starts an asynchronous job to restore archive logs of an Oracle database.
"@ "[GraphQL: restoreOracleLogs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationSla -CreateGlobal
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -CreateGlobal).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -CreateGlobal
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	snapshotSchedule = @{
		# OPTIONAL
		minute = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		hourly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		daily = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		weekly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfWeek = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
		}
		# OPTIONAL
		monthly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfMonth = <DayOfMonth> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
		}
		# OPTIONAL
		quarterly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfQuarter = <DayOfQuarter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
			# OPTIONAL
			quarterStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
		# OPTIONAL
		yearly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfYear = <DayOfYear> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
			# OPTIONAL
			yearStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
	}
	# OPTIONAL
	replicationSpecInput = @{
		# OPTIONAL
		replicationType = <ReplicationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationType]) for enum values.
		# OPTIONAL
		specificReplicationSpecInput = @{
			# OPTIONAL
			unidirectionalSpecInput = @{
				# OPTIONAL
				replicationTargetId = <System.String>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			bidirectionalSpecInput = @{
				# OPTIONAL
				replicationSpec1 = @{
					# OPTIONAL
					replicationTargetId = <System.String>
					# OPTIONAL
					retention = <System.Int32>
					# OPTIONAL
					retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
				# OPTIONAL
				replicationSpec2 = @{
					# OPTIONAL
					replicationTargetId = <System.String>
					# OPTIONAL
					retention = <System.Int32>
					# OPTIONAL
					retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
			# OPTIONAL
			cloudRegionSpecInput = @{
				# OPTIONAL
				replicationTargetRegion = <System.String>
				# OPTIONAL
				cloudProvider = <CloudProvider> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cloudLocationSpecInput = @{
				# OPTIONAL
				replicationTargetId = <System.String>
				# OPTIONAL
				cloudProvider = <CloudProvider> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retentionDuration = @{
					# OPTIONAL
					duration = <System.Int32>
					# OPTIONAL
					unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
		}
	}
	# OPTIONAL
	localRetentionLimit = @{
		# OPTIONAL
		duration = <System.Int32>
		# OPTIONAL
		unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	}
	# OPTIONAL
	firstFullBackupWindows = @(
		@{
			# OPTIONAL
			durationInHours = <System.Int32>
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = <System.Int32>
				# OPTIONAL
				minute = <System.Int32>
			}
		}
	)
	# OPTIONAL
	backupWindows = @(
		@{
			# OPTIONAL
			durationInHours = <System.Int32>
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = <System.Int32>
				# OPTIONAL
				minute = <System.Int32>
			}
		}
	)
	# OPTIONAL
	logConfig = @{
		# OPTIONAL
		slaLogFrequencyConfig = @{
			# OPTIONAL
			retention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	objectSpecificConfigsInput = @{
		# OPTIONAL
		sapHanaConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		awsRdsConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		vmwareVmConfigInput = @{
			# OPTIONAL
			logRetentionSeconds = <System.Int64>
		}
		# OPTIONAL
		azureSqlDatabaseDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		azureSqlManagedInstanceDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		db2ConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mssqlConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		oracleConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			hostLogRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mongoConfigInput = @{
			# OPTIONAL
			logFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		azureBlobConfigInput = @{
			# OPTIONAL
			continuousBackupRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		awsNativeS3SlaConfigInput = @{
			# OPTIONAL
			archivalLocationId = <System.String>
			# OPTIONAL
			continuousBackupRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		managedVolumeSlaConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	archivalSpecs = @(
		@{
			# OPTIONAL
			archivalGroupId = <System.String>
			# OPTIONAL
			threshold = <System.Int32>
			# OPTIONAL
			thresholdUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			# OPTIONAL
			archivalTieringSpecInput = @{
				# OPTIONAL
				isInstantTieringEnabled = <System.Boolean>
				# OPTIONAL
				minAccessibleDurationInSeconds = <System.Int64>
				# OPTIONAL
				coldStorageClass = <ColdStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
				# OPTIONAL
				shouldTierExistingSnapshots = <System.Boolean>
			}
			# OPTIONAL
			frequencies = @(
				<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			)
			# OPTIONAL
			archivalLocationToClusterMapping = @(
				@{
					# OPTIONAL
					clusterUuid = <System.String>
					# OPTIONAL
					locationId = <System.String>
				}
			)
		}
	)
	# OPTIONAL
	replicationSpecsV2 = @(
		@{
			# OPTIONAL
			clusterUuid = <System.String>
			# OPTIONAL
			storageSettingId = <System.String>
			# OPTIONAL
			retentionDuration = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			awsAccount = <System.String>
			# OPTIONAL
			azureSubscription = <System.String>
			# OPTIONAL
			replicationLocalRetentionDuration = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cascadingArchivalSpecs = @(
				@{
					# OPTIONAL
					archivalLocationId = <System.String>
					# OPTIONAL
					archivalThreshold = @{
						# OPTIONAL
						duration = <System.Int32>
						# OPTIONAL
						unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					}
					# OPTIONAL
					archivalTieringSpecInput = @{
						# OPTIONAL
						isInstantTieringEnabled = <System.Boolean>
						# OPTIONAL
						minAccessibleDurationInSeconds = <System.Int64>
						# OPTIONAL
						coldStorageClass = <ColdStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
						# OPTIONAL
						shouldTierExistingSnapshots = <System.Boolean>
					}
					# OPTIONAL
					frequency = @(
						<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					)
				}
			)
			# OPTIONAL
			awsRegion = <AwsNativeRegionForReplication> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegionForReplication]) for enum values.
			# OPTIONAL
			azureRegion = <AzureNativeRegionForReplication> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegionForReplication]) for enum values.
		}
	)
	# OPTIONAL
	objectTypes = @(
		<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
	)
	# OPTIONAL
	isRetentionLockedSla = <System.Boolean>
}
"@
    Write-Message "New-RscMutationSla -CreateGlobal" @"
    Create SLA Domain.
"@ "[GraphQL: createGlobalSla]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationSla -UpdateGlobal
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -UpdateGlobal).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -UpdateGlobal
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	id = <System.String>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	snapshotSchedule = @{
		# OPTIONAL
		minute = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		hourly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		daily = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		weekly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfWeek = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
		}
		# OPTIONAL
		monthly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfMonth = <DayOfMonth> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
		}
		# OPTIONAL
		quarterly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfQuarter = <DayOfQuarter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
			# OPTIONAL
			quarterStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
		# OPTIONAL
		yearly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = <System.Int32>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfYear = <DayOfYear> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
			# OPTIONAL
			yearStartMonth = <Month> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
	}
	# OPTIONAL
	stateVersion = <System.Int64>
	# OPTIONAL
	replicationSpecInput = @{
		# OPTIONAL
		replicationType = <ReplicationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ReplicationType]) for enum values.
		# OPTIONAL
		specificReplicationSpecInput = @{
			# OPTIONAL
			unidirectionalSpecInput = @{
				# OPTIONAL
				replicationTargetId = <System.String>
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			bidirectionalSpecInput = @{
				# OPTIONAL
				replicationSpec1 = @{
					# OPTIONAL
					replicationTargetId = <System.String>
					# OPTIONAL
					retention = <System.Int32>
					# OPTIONAL
					retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
				# OPTIONAL
				replicationSpec2 = @{
					# OPTIONAL
					replicationTargetId = <System.String>
					# OPTIONAL
					retention = <System.Int32>
					# OPTIONAL
					retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
			# OPTIONAL
			cloudRegionSpecInput = @{
				# OPTIONAL
				replicationTargetRegion = <System.String>
				# OPTIONAL
				cloudProvider = <CloudProvider> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retention = <System.Int32>
				# OPTIONAL
				retentionUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cloudLocationSpecInput = @{
				# OPTIONAL
				replicationTargetId = <System.String>
				# OPTIONAL
				cloudProvider = <CloudProvider> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudProvider]) for enum values.
				# OPTIONAL
				retentionDuration = @{
					# OPTIONAL
					duration = <System.Int32>
					# OPTIONAL
					unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
				}
			}
		}
	}
	# OPTIONAL
	localRetentionLimit = @{
		# OPTIONAL
		duration = <System.Int32>
		# OPTIONAL
		unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	}
	# OPTIONAL
	firstFullBackupWindows = @(
		@{
			# OPTIONAL
			durationInHours = <System.Int32>
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = <System.Int32>
				# OPTIONAL
				minute = <System.Int32>
			}
		}
	)
	# OPTIONAL
	backupWindows = @(
		@{
			# OPTIONAL
			durationInHours = <System.Int32>
			# OPTIONAL
			startTimeAttributes = @{
				# OPTIONAL
				dayOfWeek = @{
					# OPTIONAL
					day = <DayOfWeek> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
				}
				# OPTIONAL
				hour = <System.Int32>
				# OPTIONAL
				minute = <System.Int32>
			}
		}
	)
	# OPTIONAL
	logConfig = @{
		# OPTIONAL
		slaLogFrequencyConfig = @{
			# OPTIONAL
			retention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	objectSpecificConfigsInput = @{
		# OPTIONAL
		sapHanaConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		awsRdsConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		vmwareVmConfigInput = @{
			# OPTIONAL
			logRetentionSeconds = <System.Int64>
		}
		# OPTIONAL
		azureSqlDatabaseDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		azureSqlManagedInstanceDbConfigInput = @{
			# OPTIONAL
			logRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		db2ConfigInput = @{
			# OPTIONAL
			incrementalFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			differentialFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mssqlConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		oracleConfigInput = @{
			# OPTIONAL
			frequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			hostLogRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		mongoConfigInput = @{
			# OPTIONAL
			logFrequency = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		azureBlobConfigInput = @{
			# OPTIONAL
			continuousBackupRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		awsNativeS3SlaConfigInput = @{
			# OPTIONAL
			archivalLocationId = <System.String>
			# OPTIONAL
			continuousBackupRetentionInDays = <System.Int32>
		}
		# OPTIONAL
		managedVolumeSlaConfigInput = @{
			# OPTIONAL
			logRetention = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
	}
	# OPTIONAL
	shouldApplyToExistingSnapshots = @{
		# OPTIONAL
		value = <System.Boolean>
	}
	# OPTIONAL
	shouldApplyToNonPolicySnapshots = @{
		# OPTIONAL
		value = <System.Boolean>
	}
	# OPTIONAL
	userNote = <System.String>
	# OPTIONAL
	archivalSpecs = @(
		@{
			# OPTIONAL
			archivalGroupId = <System.String>
			# OPTIONAL
			threshold = <System.Int32>
			# OPTIONAL
			thresholdUnit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			# OPTIONAL
			archivalTieringSpecInput = @{
				# OPTIONAL
				isInstantTieringEnabled = <System.Boolean>
				# OPTIONAL
				minAccessibleDurationInSeconds = <System.Int64>
				# OPTIONAL
				coldStorageClass = <ColdStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
				# OPTIONAL
				shouldTierExistingSnapshots = <System.Boolean>
			}
			# OPTIONAL
			frequencies = @(
				<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			)
			# OPTIONAL
			archivalLocationToClusterMapping = @(
				@{
					# OPTIONAL
					clusterUuid = <System.String>
					# OPTIONAL
					locationId = <System.String>
				}
			)
		}
	)
	# OPTIONAL
	replicationSpecsV2 = @(
		@{
			# OPTIONAL
			clusterUuid = <System.String>
			# OPTIONAL
			storageSettingId = <System.String>
			# OPTIONAL
			retentionDuration = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			awsAccount = <System.String>
			# OPTIONAL
			azureSubscription = <System.String>
			# OPTIONAL
			replicationLocalRetentionDuration = @{
				# OPTIONAL
				duration = <System.Int32>
				# OPTIONAL
				unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			cascadingArchivalSpecs = @(
				@{
					# OPTIONAL
					archivalLocationId = <System.String>
					# OPTIONAL
					archivalThreshold = @{
						# OPTIONAL
						duration = <System.Int32>
						# OPTIONAL
						unit = <RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					}
					# OPTIONAL
					archivalTieringSpecInput = @{
						# OPTIONAL
						isInstantTieringEnabled = <System.Boolean>
						# OPTIONAL
						minAccessibleDurationInSeconds = <System.Int64>
						# OPTIONAL
						coldStorageClass = <ColdStorageClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ColdStorageClass]) for enum values.
						# OPTIONAL
						shouldTierExistingSnapshots = <System.Boolean>
					}
					# OPTIONAL
					frequency = @(
						<RetentionUnit> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
					)
				}
			)
			# OPTIONAL
			awsRegion = <AwsNativeRegionForReplication> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegionForReplication]) for enum values.
			# OPTIONAL
			azureRegion = <AzureNativeRegionForReplication> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegionForReplication]) for enum values.
		}
	)
	# OPTIONAL
	objectTypes = @(
		<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
	)
	# OPTIONAL
	isRetentionLockedSla = <System.Boolean>
}
"@
    Write-Message "New-RscMutationSla -UpdateGlobal" @"
    Update SLA Domain.
"@ "[GraphQL: updateGlobalSla]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationSla -Assign
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -Assign).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -Assign
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	slaDomainAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
	# OPTIONAL
	slaOptionalId = <System.String>
	# REQUIRED
	objectIds = @(
		<System.String>
	)
	# OPTIONAL
	applicableWorkloadType = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
	# OPTIONAL
	shouldApplyToExistingSnapshots = <System.Boolean>
	# OPTIONAL
	shouldApplyToNonPolicySnapshots = <System.Boolean>
	# OPTIONAL
	existingSnapshotRetention = <GlobalExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationSla -Assign" @"
    Endpoint to assign SLA Domain.
"@ "[GraphQL: assignSla]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationSla -AssignsForSnappableHierarchies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -AssignsForSnappableHierarchies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -AssignsForSnappableHierarchies
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.objectIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.applicableSnappableTypes = @(
	<WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$inputs.Var.shouldApplyToExistingSnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldApplyToNonPolicySnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.globalExistingSnapshotRetention = <GlobalExistingSnapshotRetention> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalExistingSnapshotRetention]) for enum values.
# OPTIONAL
$inputs.Var.userNote = <System.String>
"@
    Write-Message "New-RscMutationSla -AssignsForSnappableHierarchies" @"
    Assign SLA Domain to workloads with multiple hierarchies.
"@ "[GraphQL: assignSlasForSnappableHierarchies]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationSla -AssignRetentionToSnappables
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -AssignRetentionToSnappables).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -AssignRetentionToSnappables
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.objectIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.applicableSnappableType = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$inputs.Var.shouldApplyToNonPolicySnapshots = <System.Boolean>
# OPTIONAL
$inputs.Var.userNote = <System.String>
"@
    Write-Message "New-RscMutationSla -AssignRetentionToSnappables" @"
    Endpoint to assign retention SLA Domain to workloads.
"@ "[GraphQL: assignRetentionSLAToSnappables]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationSla -AssignRetentionToSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -AssignRetentionToSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -AssignRetentionToSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.globalSlaOptionalFid = <System.String>
# REQUIRED
$inputs.Var.globalSlaAssignType = <SlaAssignTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaAssignTypeEnum]) for enum values.
# REQUIRED
$inputs.Var.snapshotFids = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.userNote = <System.String>
"@
    Write-Message "New-RscMutationSla -AssignRetentionToSnapshots" @"
    Endpoint to assign retention SLA Domain to snapshots.
"@ "[GraphQL: assignRetentionSLAToSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationSla -Pause
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -Pause).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -Pause
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	slaId = <System.String>
	# REQUIRED
	clusterUuids = @(
		<System.String>
	)
	# REQUIRED
	pauseSla = <System.Boolean>
}
"@
    Write-Message "New-RscMutationSla -Pause" @"
    Pause or resume SLA Domain on the given Rubrik clusters.
"@ "[GraphQL: pauseSla]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationSla -GetPendingAssignments
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -GetPendingAssignments).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -GetPendingAssignments
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	pendingAssignmentsRequest = @{
		# REQUIRED
		objectIds = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscMutationSla -GetPendingAssignments" @"
    Get pending SLA Domain assignments on selected managed objects

Supported in v5.2+
Retrieve the details of pending SLA Domain assignments on the given managed objects. For objects with pending assignments, return the SLA Domain that is pending. For objects without pending assignments, return the current SLA Domain information. Explicitly list invalid object IDs.
"@ "[GraphQL: getPendingSlaAssignments]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationSla -ExportManagedVolumeSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationSla -ExportManagedVolumeSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationSla -ExportManagedVolumeSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	params = @{
		# OPTIONAL
		shouldDownloadToLocal = <System.Boolean>
		# OPTIONAL
		managedVolumeSlaExportConfig = @{
			# OPTIONAL
			managedVolumeExportConfig = @{
				# OPTIONAL
				subnet = <System.String>
				# OPTIONAL
				managedVolumePatchConfig = @{
					# OPTIONAL
					hostPatterns = @(
						<System.String>
					)
					# OPTIONAL
					nodeHint = @(
						<System.String>
					)
					# OPTIONAL
					smbDomainName = <System.String>
					# OPTIONAL
					smbValidIps = @(
						<System.String>
					)
					# OPTIONAL
					smbValidUsers = @(
						<System.String>
					)
				}
				# OPTIONAL
				shareType = <ManagedVolumeShareType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedVolumeShareType]) for enum values.
			}
			# REQUIRED
			hostId = <System.String>
			# REQUIRED
			hostMountPaths = @(
				<System.String>
			)
		}
	}
}
"@
    Write-Message "New-RscMutationSla -ExportManagedVolumeSnapshot" @"
    Create a request to export a snapshot and mount it on a host

Supported in v5.3+
Export a managed volume snapshot as a share and mount it on a given host.
"@ "[GraphQL: exportSlaManagedVolumeSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationVcenter -Create
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -Create).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -Create
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	vcenterDetail = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		computeVisibilityFilter = @(
			@{
				# OPTIONAL
				isVmwareMetroStorageCluster = <System.Boolean>
				# REQUIRED
				hostGroupFilter = @(
					<System.String>
				)
				# REQUIRED
				id = <System.String>
			}
		)
		# OPTIONAL
		shouldEnableHotAddProxyForOnPrem = <System.Boolean>
		# OPTIONAL
		orgNetworkId = <System.String>
		# OPTIONAL
		conflictResolutionAuthz = <VcenterConfigV2ConflictResolutionAuthz> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigV2ConflictResolutionAuthz]) for enum values.
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}
"@
    Write-Message "New-RscMutationVcenter -Create" @"
    Add a vCenter server.
"@ "[GraphQL: createVsphereVcenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -Delete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -Delete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -Delete
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVcenter -Delete" @"
    Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.
"@ "[GraphQL: vsphereDeleteVcenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -Refresh
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -Refresh).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -Refresh
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	fid = <System.String>
	# OPTIONAL
	shouldDiagnose = <System.Boolean>
}
"@
    Write-Message "New-RscMutationVcenter -Refresh" @"
    Refresh vCenter Server metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified vCenter Server.
"@ "[GraphQL: refreshVsphereVcenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -Update
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	updateProperties = @{
		# OPTIONAL
		caCerts = <System.String>
		# OPTIONAL
		computeVisibilityFilter = @(
			@{
				# OPTIONAL
				isVmwareMetroStorageCluster = <System.Boolean>
				# REQUIRED
				hostGroupFilter = @(
					<System.String>
				)
				# REQUIRED
				id = <System.String>
			}
		)
		# OPTIONAL
		shouldEnableHotAddProxyForOnPrem = <System.Boolean>
		# OPTIONAL
		conflictResolutionAuthz = <VcenterConfigConflictResolutionAuthz> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VcenterConfigConflictResolutionAuthz]) for enum values.
		# REQUIRED
		hostname = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}
"@
    Write-Message "New-RscMutationVcenter -Update" @"
    Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.
"@ "[GraphQL: updateVcenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -UpdateHotAddNetwork
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -UpdateHotAddNetwork).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -UpdateHotAddNetwork
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	hotAddNetworkInfo = @{
		# OPTIONAL
		staticIpInfo = @{
			# OPTIONAL
			dnsServers = @(
				<System.String>
			)
			# OPTIONAL
			gateway = <System.String>
			# REQUIRED
			ipAddresses = @(
				<System.String>
			)
			# REQUIRED
			subnetMask = <System.String>
		}
		# REQUIRED
		networkId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVcenter -UpdateHotAddNetwork" @"
    Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
"@ "[GraphQL: updateVcenterHotAddNetwork]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVcenter -UpdateHotAddBandwidth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVcenter -UpdateHotAddBandwidth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVcenter -UpdateHotAddBandwidth
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	hotAddBandwidthInfo = @{
		# REQUIRED
		exportLimit = <System.Int32>
		# REQUIRED
		ingestLimit = <System.Int32>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVcenter -UpdateHotAddBandwidth" @"
    Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
"@ "[GraphQL: updateVcenterHotAddBandwidth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationVsphere -OnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -OnDemandSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -OnDemandSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		slaId = <System.String>
	}
	# REQUIRED
	id = <System.String>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationVsphere -OnDemandSnapshot" @"
    
"@ "[GraphQL: vsphereOnDemandSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -BulkOnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -BulkOnDemandSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -BulkOnDemandSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		slaId = <System.String>
		# REQUIRED
		vms = @(
			<System.String>
		)
	}
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationVsphere -BulkOnDemandSnapshot" @"
    Trigger a bulk on demand snapshot.
"@ "[GraphQL: vsphereBulkOnDemandSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -DeleteLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -DeleteLiveMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -DeleteLiveMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphere -DeleteLiveMount" @"
    Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.
"@ "[GraphQL: deleteVsphereLiveMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		mountExportSnapshotJobCommonOptions = @{
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
		# REQUIRED
		datastoreName = <System.String>
		# REQUIRED
		hostIpAddress = <System.String>
		# REQUIRED
		hostPassword = <System.String>
		# REQUIRED
		hostUsername = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphere -ExportSnapshotToStandaloneHostV2" @"
    Export snapshot of a virtual machine to standalone ESXi server.
"@ "[GraphQL: vsphereExportSnapshotToStandaloneHostV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -DownloadVirtualMachineFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -DownloadVirtualMachineFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -DownloadVirtualMachineFiles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		fileNamesToDownload = @(
			<System.String>
		)
		# REQUIRED
		vmId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphere -DownloadVirtualMachineFiles" @"
    Download Virtual Machine files from a snapshot

Supported in v9.0+
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.
"@ "[GraphQL: downloadVsphereVirtualMachineFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -CreateAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -CreateAdvancedTag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -CreateAdvancedTag
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = <System.String>
		# REQUIRED
		condition = <System.String>
		# REQUIRED
		name = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphere -CreateAdvancedTag" @"
    Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.
"@ "[GraphQL: createVsphereAdvancedTag]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -DeleteAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -DeleteAdvancedTag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -DeleteAdvancedTag
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterId = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphere -DeleteAdvancedTag" @"
    Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.
"@ "[GraphQL: deleteVsphereAdvancedTag]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphere -UpdateAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphere -UpdateAdvancedTag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphere -UpdateAdvancedTag
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterId = <System.String>
	# REQUIRED
	filterInfo = @{
		# OPTIONAL
		description = <System.String>
		# REQUIRED
		condition = <System.String>
		# REQUIRED
		name = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphere -UpdateAdvancedTag" @"
    Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.
"@ "[GraphQL: updateVsphereAdvancedTag]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscMutationVsphereVm -RecoverFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -RecoverFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -RecoverFiles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotFid = <System.String>
	# REQUIRED
	restoreConfig = @{
		# OPTIONAL
		restoreFilesConfig = @(
			@{
				# OPTIONAL
				path = <System.String>
				# OPTIONAL
				restorePath = <System.String>
			}
		)
		# OPTIONAL
		domainName = <System.String>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		shouldIgnoreErrors = <System.Boolean>
		# OPTIONAL
		shouldSaveCredentials = <System.Boolean>
		# OPTIONAL
		shouldUseAgent = <System.Boolean>
		# OPTIONAL
		shouldRestoreXAttrs = <System.Boolean>
		# OPTIONAL
		deltaTypeFilter = @(
			<DeltaType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
		)
		# OPTIONAL
		nextSnapshotFid = <System.String>
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -RecoverFiles" @"
    Restores multiple files/directories from snapshot.
"@ "[GraphQL: vsphereVmRecoverFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -RecoverFilesNew
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -RecoverFilesNew).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -RecoverFilesNew
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# OPTIONAL
		domainName = <System.String>
		# OPTIONAL
		ignoreErrors = <System.Boolean>
		# OPTIONAL
		password = <System.String>
		# OPTIONAL
		shouldSaveCredentials = <System.Boolean>
		# OPTIONAL
		username = <System.String>
		# OPTIONAL
		destObjectId = <System.String>
		# OPTIONAL
		shouldRestoreXAttrs = <System.Boolean>
		# OPTIONAL
		shouldUseAgent = <System.Boolean>
		# OPTIONAL
		guestCredentialId = <System.String>
		# REQUIRED
		restoreConfig = @(
			@{
				# OPTIONAL
				restorePathPair = @{
					# OPTIONAL
					restorePath = <System.String>
					# REQUIRED
					path = <System.String>
				}
			}
		)
	}
	# OPTIONAL
	deltaRequest = @{
		# REQUIRED
		nextSnapshotFid = <System.String>
		# REQUIRED
		deltaTypeFilter = @(
			<DeltaType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
		)
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -RecoverFilesNew" @"
    Restores multiple files/directories from snapshot.
"@ "[GraphQL: vsphereVmRecoverFilesNew]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -RegisterAgent
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -RegisterAgent).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -RegisterAgent
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -RegisterAgent" @"
    Register Rubrik Backup Service

Supported in v5.0+
Register the Rubrik Backup Service that is running on a specified host with the specified Rubrik cluster.
"@ "[GraphQL: vsphereVmRegisterAgent]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -DownloadSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -DownloadSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -DownloadSnapshot" @"
    Download snapshot from archive

Supported in v5.0+
Provides a method for retrieving a snapshot, that is not available locally, from an archival location.
"@ "[GraphQL: vsphereVmDownloadSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ExportSnapshotV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ExportSnapshotV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ExportSnapshotV2
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		unregisterVm = <System.Boolean>
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
		shouldUseHotAddProxy = <System.Boolean>
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
		folderId = <System.String>
		# REQUIRED
		datastoreId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -ExportSnapshotV2" @"
    Create a vSphere Export from a snapshot or a point-in-time.
"@ "[GraphQL: vsphereVmExportSnapshotV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ExportSnapshotV3
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ExportSnapshotV3).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ExportSnapshotV3
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		clusterId = <System.String>
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
		hostId = <System.String>
		# OPTIONAL
		resourcePoolId = <System.String>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		shouldUseHotAddProxy = <System.Boolean>
		# OPTIONAL
		storageLocationId = <System.String>
		# OPTIONAL
		unregisterVm = <System.Boolean>
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
		folderId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -ExportSnapshotV3" @"
    Create a vSphere Export from a snapshot or a point-in-time with datastore cluster and virtual disk mapping support.
"@ "[GraphQL: vsphereVmExportSnapshotV3]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -BatchExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -BatchExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -BatchExport
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				config = @{
					# OPTIONAL
					hostId = <System.String>
					# OPTIONAL
					shouldRecoverTags = <System.Boolean>
					# OPTIONAL
					unregisterVm = <System.Boolean>
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
					shouldUseHotAddProxy = <System.Boolean>
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
					folderId = <System.String>
					# REQUIRED
					datastoreId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -BatchExport" @"
    Create a mass export for a group of virtual machines.
"@ "[GraphQL: vsphereVmBatchExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -BatchExportV3
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -BatchExportV3).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -BatchExportV3
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				config = @{
					# OPTIONAL
					clusterId = <System.String>
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
					hostId = <System.String>
					# OPTIONAL
					resourcePoolId = <System.String>
					# OPTIONAL
					shouldRecoverTags = <System.Boolean>
					# OPTIONAL
					shouldUseHotAddProxy = <System.Boolean>
					# OPTIONAL
					storageLocationId = <System.String>
					# OPTIONAL
					unregisterVm = <System.Boolean>
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
					folderId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -BatchExportV3" @"
    Create a batch export for a group of virtual machines with datastore cluster support.
"@ "[GraphQL: vsphereVmBatchExportV3]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateInPlaceRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateInPlaceRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateInPlaceRecovery
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldKeepVsphereSnapshotAfterRecovery = <System.Boolean>
		# OPTIONAL
		requiredRecoveryParameters = @{
			# OPTIONAL
			recoveryPoint = <DateTime>
			# OPTIONAL
			snapshotId = <System.String>
		}
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -InitiateInPlaceRecovery" @"
    Trigger an in-place recovery from a snapshot or point-in-time.
"@ "[GraphQL: vsphereVmInitiateInPlaceRecovery]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		hostId = <System.String>
		# OPTIONAL
		shouldRecoverTags = <System.Boolean>
		# OPTIONAL
		unregisterVm = <System.Boolean>
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
		shouldUseHotAddProxy = <System.Boolean>
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
		folderId = <System.String>
		# REQUIRED
		datastoreId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -ExportSnapshotWithDownloadFromCloud" @"
    Download a snapshot from an archival location, then export a virtual machine using the downloaded snapshot

Supported in v5.3+
Download a snapshot from an archival location and then export a virtual machine using the downloaded snapshot.
"@ "[GraphQL: vsphereVmExportSnapshotWithDownloadFromCloud]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -BatchInPlaceRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -BatchInPlaceRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -BatchInPlaceRecovery
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# REQUIRED
				config = @{
					# OPTIONAL
					shouldKeepVsphereSnapshotAfterRecovery = <System.Boolean>
					# OPTIONAL
					requiredRecoveryParameters = @{
						# OPTIONAL
						recoveryPoint = <DateTime>
						# OPTIONAL
						snapshotId = <System.String>
					}
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -BatchInPlaceRecovery" @"
    Supported in v6.0+. Export a snapshot each from a set of virtual machines.
"@ "[GraphQL: vsphereVmBatchInPlaceRecovery]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -DeleteSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -DeleteSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -DeleteSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <DeleteVmwareSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeleteVmwareSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -DeleteSnapshot" @"
    Designate a snapshot as expired and available for garbage collection. The snapshot must be an on-demand snapshot or a snapshot from a virtual machine that is not assigned to an SLA Domain.
"@ "[GraphQL: vsphereVmDeleteSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateInstantRecoveryV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateInstantRecoveryV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateInstantRecoveryV2
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
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
}
"@
    Write-Message "New-RscMutationVsphereVm -InitiateInstantRecoveryV2" @"
    Instantly recover a vSphere virtual machine from a snapshot or point-in-time.
"@ "[GraphQL: vsphereVmInitiateInstantRecoveryV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateBatchInstantRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateBatchInstantRecovery).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateBatchInstantRecovery
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
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
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -InitiateBatchInstantRecovery" @"
    Initiate a mass instant recovery for a group of VMs.
"@ "[GraphQL: vsphereVmInitiateBatchInstantRecovery]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateDiskMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateDiskMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateDiskMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		targetVmId = <System.String>
		# OPTIONAL
		vlan = <System.Int32>
		# OPTIONAL
		vmdkIds = @(
			<System.String>
		)
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -InitiateDiskMount" @"
    Attaching disks from a snapshot to an existing virtual machine

Supported in v5.0+
Requests a snapshot mount to attach disks to an existing virtual machine.
"@ "[GraphQL: vsphereVmInitiateDiskMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateLiveMountV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateLiveMountV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateLiveMountV2
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	config = @{
		# OPTIONAL
		createDatastoreOnly = <System.Boolean>
		# OPTIONAL
		dataStoreName = <System.String>
		# OPTIONAL
		hostId = <System.String>
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
		folderId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -InitiateLiveMountV2" @"
    Create a vSphere Live Mount from a snapshot or point-in-time.
"@ "[GraphQL: vsphereVmInitiateLiveMountV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -InitiateBatchLiveMountV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -InitiateBatchLiveMountV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -InitiateBatchLiveMountV2
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	config = @{
		# REQUIRED
		snapshots = @(
			@{
				# OPTIONAL
				snapshotAfterDate = <DateTime>
				# OPTIONAL
				snapshotBeforeDate = <DateTime>
				# OPTIONAL
				snapshotId = <System.String>
				# OPTIONAL
				vmNamePrefix = <System.String>
				# REQUIRED
				config = @{
					# OPTIONAL
					createDatastoreOnly = <System.Boolean>
					# OPTIONAL
					dataStoreName = <System.String>
					# OPTIONAL
					hostId = <System.String>
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
					folderId = <System.String>
				}
				# REQUIRED
				vmId = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -InitiateBatchLiveMountV2" @"
    Initiate a mass live mount for a group of VMs.
"@ "[GraphQL: vsphereVmInitiateBatchLiveMountV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -PowerOnOffLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -PowerOnOffLiveMount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -PowerOnOffLiveMount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# OPTIONAL
		shouldForce = <System.Boolean>
		# REQUIRED
		powerStatus = <System.Boolean>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -PowerOnOffLiveMount" @"
    Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.
"@ "[GraphQL: vsphereVmPowerOnOffLiveMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ListEsxiDatastores
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ListEsxiDatastores).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ListEsxiDatastores
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	loginInfo = @{
		# REQUIRED
		ip = <System.String>
		# REQUIRED
		password = <System.String>
		# REQUIRED
		username = <System.String>
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -ListEsxiDatastores" @"
    List ESXi datastores

Supported in v5.0+
Retrieve a list of the datastores for a specified ESXi host.
"@ "[GraphQL: vsphereVmListEsxiDatastores]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -MountRelocate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -MountRelocate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -MountRelocate
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
		# REQUIRED
		datastoreId = <System.String>
	}
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -MountRelocate" @"
    Relocate a virtual machine to another datastore

Supported in v5.0+
Run storage VMotion to relocate a specified Live Mount into another data store.
"@ "[GraphQL: vsphereVmMountRelocate]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -MountRelocateV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -MountRelocateV2).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -MountRelocateV2
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	config = @{
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
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -MountRelocateV2" @"
    Create a Live Mount migration to a datastore or datastore cluster with virtual disk mapping support.
"@ "[GraphQL: vsphereVmMountRelocateV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -ExcludeVmDisks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -ExcludeVmDisks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -ExcludeVmDisks
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @(
	@{
		# REQUIRED
		virtualDiskFid = <System.String>
		# OPTIONAL
		excludeFromSnapshots = <System.Boolean>
}
)
"@
    Write-Message "New-RscMutationVsphereVm -ExcludeVmDisks" @"
    Exclude or include virtual disks during snapshot.
"@ "[GraphQL: vsphereExcludeVmDisks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -DownloadSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -DownloadSnapshotFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -DownloadSnapshotFiles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotFid = <System.String>
	# REQUIRED
	paths = @(
		<System.String>
	)
	# OPTIONAL
	deltaTypeFilter = @(
		<DeltaType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeltaType]) for enum values.
	)
	# OPTIONAL
	nextSnapshotFid = <System.String>
	# OPTIONAL
	isLegalHoldDownload = <System.Boolean>
	# OPTIONAL
	userNote = <System.String>
}
"@
    Write-Message "New-RscMutationVsphereVm -DownloadSnapshotFiles" @"
    Download files from snapshot.
"@ "[GraphQL: vsphereVmDownloadSnapshotFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscMutationVsphereVm -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscMutationVsphereVm -Update).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscMutationVsphereVm -Update
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	vmUpdateProperties = @{
		# OPTIONAL
		guestCredential = @{
			# REQUIRED
			password = <System.String>
			# REQUIRED
			username = <System.String>
		}
		# OPTIONAL
		shouldRefreshCacheAfterUpdate = <System.Boolean>
		# OPTIONAL
		guestCredentialId = <System.String>
		# OPTIONAL
		virtualMachineUpdate = @{
			# OPTIONAL
			cloudInstantiationSpec = @{
				# REQUIRED
				imageRetentionInSeconds = <System.Int64>
			}
			# OPTIONAL
			configuredSlaDomainId = <System.String>
			# OPTIONAL
			isArrayIntegrationEnabled = <System.Boolean>
			# OPTIONAL
			isVmPaused = <System.Boolean>
			# OPTIONAL
			maxNestedVsphereSnapshots = <System.Int32>
			# OPTIONAL
			postBackupScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			postSnapScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			preBackupScript = @{
				# REQUIRED
				failureHandling = <VirtualMachineScriptDetailFailureHandling> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineScriptDetailFailureHandling]) for enum values.
				# REQUIRED
				scriptPath = <System.String>
				# REQUIRED
				timeoutMs = <System.Int64>
			}
			# OPTIONAL
			throttlingSettings = @{
				# OPTIONAL
				cpuUtilizationThreshold = <System.Int32>
				# OPTIONAL
				datastoreIoLatencyThreshold = <System.Int32>
				# OPTIONAL
				ioLatencyThreshold = <System.Int32>
			}
			# OPTIONAL
			snapshotConsistencyMandate = <VirtualMachineUpdateSnapshotConsistencyMandate> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VirtualMachineUpdateSnapshotConsistencyMandate]) for enum values.
		}
	}
}
"@
    Write-Message "New-RscMutationVsphereVm -Update" @"
    Update VM

Supported in v5.0+
Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.
"@ "[GraphQL: updateVsphereVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryAccount -Settings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Settings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Settings
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryAccount -Settings" @"
    This endpoint is deprecated.
"@ "[GraphQL: accountSettings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAccount -SWithExocomputeMappings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -SWithExocomputeMappings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -SWithExocomputeMappings
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudVendor = <CloudVendor> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudVendor]) for enum values.
# REQUIRED
$inputs.Var.features = @(
	<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$inputs.Var.exocomputeAccountIdsFilter = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryAccount -SWithExocomputeMappings" @"
    Retrieves the list of all accounts with their Exocompute account mapping, if exists.
"@ "[GraphQL: allAccountsWithExocomputeMappings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Products
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Products).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Products
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.nameFilter = @(
	<ProductName> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductName]) for enum values.
)
# REQUIRED
$inputs.Var.typeFilter = @(
	<ProductType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductType]) for enum values.
)
# REQUIRED
$inputs.Var.stateFilter = @(
	<ProductState> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ProductState]) for enum values.
)
# OPTIONAL
$inputs.Var.startDateArg = <DateTime>
# OPTIONAL
$inputs.Var.endDateArg = <DateTime>
"@
    Write-Message "New-RscQueryAccount -Products" @"
    
"@ "[GraphQL: allAccountProducts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Id
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Id).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Id
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryAccount -Id" @"
    Account ID.
"@ "[GraphQL: accountId]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAccount -Owners
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAccount -Owners).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAccount -Owners
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryAccount -Owners" @"
    List of account owners.
"@ "[GraphQL: allAccountOwners]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryActivitySeries -ActivitySeries
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryActivitySeries -ActivitySeries).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryActivitySeries -ActivitySeries
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	activitySeriesId = <System.String>
	# OPTIONAL
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryActivitySeries -ActivitySeries" @"
    Retrieve an activity series.
"@ "[GraphQL: activitySeries]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryActivitySeries -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryActivitySeries -List).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryActivitySeries -List
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <ActivitySeriesSortField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ActivitySeriesSortField]) for enum values.
# OPTIONAL
$inputs.Var.filters = @{
	# OPTIONAL
	lastActivityStatus = @(
		<EventStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventStatus]) for enum values.
	)
	# OPTIONAL
	lastActivityType = @(
		<EventType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventType]) for enum values.
	)
	# OPTIONAL
	severity = @(
		<EventSeverity> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventSeverity]) for enum values.
	)
	# OPTIONAL
	objectName = <System.String>
	# OPTIONAL
	objectType = @(
		<EventObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventObjectType]) for enum values.
	)
	# OPTIONAL
	startTimeGt = <DateTime>
	# OPTIONAL
	startTimeLt = <DateTime>
	# OPTIONAL
	lastUpdatedTimeGt = <DateTime>
	# OPTIONAL
	lastUpdatedTimeLt = <DateTime>
	# OPTIONAL
	clusterId = @(
		<System.String>
	)
	# OPTIONAL
	clusterType = @(
		<EventClusterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.EventClusterType]) for enum values.
	)
	# OPTIONAL
	objectFid = @(
		<System.String>
	)
	# OPTIONAL
	ancestorId = <System.String>
	# OPTIONAL
	searchTerm = <System.String>
	# OPTIONAL
	orgIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscQueryActivitySeries -List" @"
    
"@ "[GraphQL: activitySeriesConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryAws -NativeRoot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRoot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRoot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryAws -NativeRoot" @"
    Root of AWS native hierarchy.
"@ "[GraphQL: awsNativeRoot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsNativeAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
"@
    Write-Message "New-RscQueryAws -NativeAccount" @"
    Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.
"@ "[GraphQL: awsNativeAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEc2Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEc2Instance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEc2Instance
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.ec2InstanceRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -NativeEc2Instance" @"
    Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.
"@ "[GraphQL: awsNativeEc2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEbsVolume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEbsVolume).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEbsVolume
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.ebsVolumeRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -NativeEbsVolume" @"
    Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.
"@ "[GraphQL: awsNativeEbsVolume]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeS3Bucket
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeS3Bucket).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeS3Bucket
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.s3BucketRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -NativeS3Bucket" @"
    Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.
"@ "[GraphQL: awsNativeS3Bucket]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeAccounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeAccounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeAccountSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeAccountSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.accountFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	cloudTypeFilter = @{
		# REQUIRED
		cloudTypes = @(
			<AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
		)
	}
}
# OPTIONAL
$inputs.Var.authorizedOperationFilter = <Operation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# REQUIRED
$inputs.Var.awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
"@
    Write-Message "New-RscQueryAws -NativeAccounts" @"
    Paginated list of all AWS Native accounts.
"@ "[GraphQL: awsNativeAccounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEc2InstancesByName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEc2InstancesByName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEc2InstancesByName
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEc2InstanceSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$inputs.Var.ec2InstanceName = <System.String>
"@
    Write-Message "New-RscQueryAws -NativeEc2InstancesByName" @"
    Paginated list of all AWS EC2 Instances by name or substring of name.
"@ "[GraphQL: awsNativeEc2InstancesByName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEc2Instances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEc2Instances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEc2Instances
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEc2InstanceSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.descendantTypeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.ec2InstanceFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	fileRecoveryStatusFilter = @{
		# REQUIRED
		statuses = @(
			<AwsNativeFileRecoveryStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	typeFilter = @{
		# REQUIRED
		ec2InstanceTypes = @(
			<AwsNativeEc2InstanceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEc2InstanceType]) for enum values.
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	appProtectionStatusFilter = @{
		# REQUIRED
		isProtectionSetup = <System.Boolean>
	}
	# OPTIONAL
	rbsStatusFilter = @{
		# REQUIRED
		status = <CloudInstanceRbsConnectionStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscQueryAws -NativeEc2Instances" @"
    Paginated list of all AWS EC2 Instances.
"@ "[GraphQL: awsNativeEc2Instances]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEbsVolumesByName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEbsVolumesByName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEbsVolumesByName
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEbsVolumeSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# REQUIRED
$inputs.Var.ebsVolumeName = <System.String>
"@
    Write-Message "New-RscQueryAws -NativeEbsVolumesByName" @"
    Paginated list of all AWS EBS Volumes by name or substring of name.
"@ "[GraphQL: awsNativeEbsVolumesByName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeEbsVolumes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeEbsVolumes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeEbsVolumes
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeEbsVolumeSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.ebsVolumeFilters = @{
	# OPTIONAL
	nameOrIdSubstringFilter = @{
		# REQUIRED
		nameOrIdSubstring = <System.String>
	}
	# OPTIONAL
	fileRecoveryStatusFilter = @{
		# REQUIRED
		statuses = @(
			<AwsNativeFileRecoveryStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeFileRecoveryStatus]) for enum values.
		)
	}
	# OPTIONAL
	typeFilter = @{
		# REQUIRED
		ebsVolumeTypes = @(
			<AwsNativeEbsVolumeType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeEbsVolumeType]) for enum values.
		)
	}
	# OPTIONAL
	attachedInstanceFilter = @{
		# REQUIRED
		ec2InstanceIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscQueryAws -NativeEbsVolumes" @"
    Paginated list of all AWS EBS Volumes.
"@ "[GraphQL: awsNativeEbsVolumes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllVpcsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllVpcsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllVpcsByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAws -AllVpcsByRegion" @"
    List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.
"@ "[GraphQL: allVpcsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllVpcs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllVpcs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllVpcs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.awsAccountRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -AllVpcs" @"
    List of all Virtual Private Clouds (VPCs) in the AWS Native account.
"@ "[GraphQL: allVpcsFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snapshotId = <System.String>
"@
    Write-Message "New-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable" @"
    Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.
"@ "[GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllAvailabilityZonesByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllAvailabilityZonesByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllAvailabilityZonesByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAws -AllAvailabilityZonesByRegion" @"
    List of Availability Zones (AZs) in the specified region on the specified AWS Native account.
"@ "[GraphQL: allAvailabilityZonesByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllKmsEncryptionKeysByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllKmsEncryptionKeysByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllKmsEncryptionKeysByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAws -AllKmsEncryptionKeysByRegion" @"
    List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.
"@ "[GraphQL: allKmsEncryptionKeysByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -IsS3BucketNameAvailable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -IsS3BucketNameAvailable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -IsS3BucketNameAvailable
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.bucketName = <System.String>
# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -IsS3BucketNameAvailable" @"
    Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.
"@ "[GraphQL: isAwsS3BucketNameAvailable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllS3Buckets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllS3Buckets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllS3Buckets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -AllS3Buckets" @"
    List of all S3 bucket names across regions for the AWS Native account.
"@ "[GraphQL: allS3BucketsFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllS3BucketsDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllS3BucketsDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllS3BucketsDetails
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# OPTIONAL
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAws -AllS3BucketsDetails" @"
    List of all S3 bucket details across regions for the AWS Native account.
"@ "[GraphQL: allS3BucketsDetailsFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRdsInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRdsInstance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRdsInstance
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.rdsInstanceRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -NativeRdsInstance" @"
    Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.
"@ "[GraphQL: awsNativeRdsInstance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRdsInstances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRdsInstances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRdsInstances
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AwsNativeRdsInstanceSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsInstanceSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.rdsInstanceFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	accountFilter = @{
		# REQUIRED
		accountIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	vpcFilter = @{
		# REQUIRED
		vpcIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	dbEngineFilter = @{
		# REQUIRED
		dbEngines = @(
			<AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
		)
	}
	# OPTIONAL
	dbInstanceClassFilter = @{
		# REQUIRED
		dbInstanceClasses = @(
			<AwsNativeRdsDbInstanceClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
		)
	}
	# OPTIONAL
	orgFilter = @{
		# REQUIRED
		orgIds = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscQueryAws -NativeRdsInstances" @"
    Paginated list of AWS RDS Instances on AWS Native account.
"@ "[GraphQL: awsNativeRdsInstances]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRdsPointInTimeRestoreWindow
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRdsPointInTimeRestoreWindow).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRdsPointInTimeRestoreWindow
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsInstanceName = <System.String>
# OPTIONAL
$inputs.Var.rdsDatabaseRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -NativeRdsPointInTimeRestoreWindow" @"
    Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.
"@ "[GraphQL: awsNativeRdsPointInTimeRestoreWindow]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -RdsInstanceDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -RdsInstanceDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -RdsInstanceDetails
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsInstanceName = <System.String>
# OPTIONAL
$inputs.Var.rdsDatabaseRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAws -RdsInstanceDetails" @"
    Details of the RDS Instance in the AWS Native account.
"@ "[GraphQL: rdsInstanceDetailsFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# REQUIRED
$inputs.Var.dbClass = <AwsNativeRdsDbInstanceClass> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbInstanceClass]) for enum values.
# OPTIONAL
$inputs.Var.databaseInstanceClass = <System.String>
# OPTIONAL
$inputs.Var.primaryAz = <System.String>
# OPTIONAL
$inputs.Var.storageType = <AwsNativeRdsStorageType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsStorageType]) for enum values.
# REQUIRED
$inputs.Var.isMultiAz = <System.Boolean>
# OPTIONAL
$inputs.Var.kmsKeyId = <System.String>
# OPTIONAL
$inputs.Var.iops = <System.Int32>
"@
    Write-Message "New-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid" @"
    Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance.
"@ "[GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllOptionGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllOptionGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllOptionGroupsByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# REQUIRED
$inputs.Var.majorEngineVersion = <System.String>
"@
    Write-Message "New-RscQueryAws -AllOptionGroupsByRegion" @"
    List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
"@ "[GraphQL: allOptionGroupsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllDbParameterGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllDbParameterGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllDbParameterGroupsByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# REQUIRED
$inputs.Var.dbEngineVersion = <System.String>
# OPTIONAL
$inputs.Var.rdsType = <AwsNativeRdsType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsType]) for enum values.
"@
    Write-Message "New-RscQueryAws -AllDbParameterGroupsByRegion" @"
    List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
"@ "[GraphQL: allDbParameterGroupsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllDbSubnetGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllDbSubnetGroupsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllDbSubnetGroupsByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAws -AllDbSubnetGroupsByRegion" @"
    All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.
"@ "[GraphQL: allDbSubnetGroupsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -ValidateNativeRdsInstanceNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ValidateNativeRdsInstanceNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ValidateNativeRdsInstanceNameForExport
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsInstanceName = <System.String>
"@
    Write-Message "New-RscQueryAws -ValidateNativeRdsInstanceNameForExport" @"
    Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.
"@ "[GraphQL: validateAwsNativeRdsInstanceNameForExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -ValidateNativeRdsClusterNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ValidateNativeRdsClusterNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ValidateNativeRdsClusterNameForExport
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsClusterName = <System.String>
"@
    Write-Message "New-RscQueryAws -ValidateNativeRdsClusterNameForExport" @"
    Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.
"@ "[GraphQL: validateAwsNativeRdsClusterNameForExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -NativeRdsExportDefaults
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -NativeRdsExportDefaults).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -NativeRdsExportDefaults
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.rdsInstanceRubrikId = <System.String>
# OPTIONAL
$inputs.Var.snapshotId = <System.String>
# REQUIRED
$inputs.Var.isPointInTime = <System.Boolean>
"@
    Write-Message "New-RscQueryAws -NativeRdsExportDefaults" @"
    Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.
"@ "[GraphQL: awsNativeRdsExportDefaults]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllEc2KeyPairsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllEc2KeyPairsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllEc2KeyPairsByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAws -AllEc2KeyPairsByRegion" @"
    List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.
"@ "[GraphQL: allEc2KeyPairsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
	# REQUIRED
	destinationRegionId = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
	# REQUIRED
	destinationAwsAccountRubrikId = <System.String>
}
"@
    Write-Message "New-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport" @"
    Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.
"@ "[GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.dbEngine = <AwsNativeRdsDbEngine> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRdsDbEngine]) for enum values.
# OPTIONAL
$inputs.Var.dbEngineVersion = <System.String>
"@
    Write-Message "New-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses" @"
    List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.
"@ "[GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -ComputeSettings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ComputeSettings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ComputeSettings
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.computeSettingId = <System.String>
"@
    Write-Message "New-RscQueryAws -ComputeSettings" @"
    Retrieve aws compute settings.
"@ "[GraphQL: awsComputeSettings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllComputeSettings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllComputeSettings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllComputeSettings
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.sortBy = <AwsCloudComputeSettingQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <AwsCloudComputeSettingFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudComputeSettingFilterField]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
"@
    Write-Message "New-RscQueryAws -AllComputeSettings" @"
    List all aws compute settings.
"@ "[GraphQL: allAwsComputeSettings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllCloudAccountsWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllCloudAccountsWithFeatures).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllCloudAccountsWithFeatures
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsCloudAccountsArg = @{
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	statusFilters = @(
		<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
	)
	# OPTIONAL
	awsAdminAccountFilter = <System.String>
	# OPTIONAL
	columnSearchFilter = <System.String>
}
"@
    Write-Message "New-RscQueryAws -AllCloudAccountsWithFeatures" @"
    List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.
"@ "[GraphQL: allAwsCloudAccountsWithFeatures]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountWithFeatures).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountWithFeatures
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.awsCloudAccountArg = @{
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}
"@
    Write-Message "New-RscQueryAws -CloudAccountWithFeatures" @"
    List of AWS cloud accounts and the features for each account, classified by ID.
"@ "[GraphQL: awsCloudAccountWithFeatures]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountListVpcs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountListVpcs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountListVpcs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
"@
    Write-Message "New-RscQueryAws -CloudAccountListVpcs" @"
    Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.
"@ "[GraphQL: awsCloudAccountListVpcs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountListSubnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountListSubnets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountListSubnets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
# REQUIRED
$inputs.Var.vpcID = <System.String>
"@
    Write-Message "New-RscQueryAws -CloudAccountListSubnets" @"
    Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).
"@ "[GraphQL: awsCloudAccountListSubnets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -CloudAccountListSecurityGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -CloudAccountListSecurityGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -CloudAccountListSecurityGroups
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
# REQUIRED
$inputs.Var.vpcID = <System.String>
"@
    Write-Message "New-RscQueryAws -CloudAccountListSecurityGroups" @"
    Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).
"@ "[GraphQL: awsCloudAccountListSecurityGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllExocomputeConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllExocomputeConfigs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsNativeAccountIdOrNamePrefix = <System.String>
"@
    Write-Message "New-RscQueryAws -AllExocomputeConfigs" @"
    List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.
"@ "[GraphQL: allAwsExocomputeConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllCloudAccountConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllCloudAccountConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllCloudAccountConfigs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsCloudAccountsArg = @{
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	# REQUIRED
	statusFilters = @(
		<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
	)
	# OPTIONAL
	awsAdminAccountFilter = <System.String>
	# OPTIONAL
	columnSearchFilter = <System.String>
}
"@
    Write-Message "New-RscQueryAws -AllCloudAccountConfigs" @"
    List of all AWS cloud account configurations with the given search query.
"@ "[GraphQL: allAwsCloudAccountConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -TrustPolicy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -TrustPolicy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -TrustPolicy
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	awsNativeAccounts = @(
		@{
			# OPTIONAL
			externalId = <System.String>
			# REQUIRED
			id = <System.String>
		}
	)
}
"@
    Write-Message "New-RscQueryAws -TrustPolicy" @"
    Retrieves the AWS trust policy that will be attached with each role (cross-account, exocompute, etc.) in the customer's environment.
"@ "[GraphQL: awsTrustPolicy]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllPermissionPolicies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllPermissionPolicies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllPermissionPolicies
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudType = <AwsCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsCloudType]) for enum values.
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# OPTIONAL
	featureSpecificDetails = @{
		# OPTIONAL
		ec2RecoveryRolePath = <System.String>
	}
}
"@
    Write-Message "New-RscQueryAws -AllPermissionPolicies" @"
    Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role.
"@ "[GraphQL: allAwsPermissionPolicies]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -ArtifactsToDelete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -ArtifactsToDelete).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -ArtifactsToDelete
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	awsNativeId = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
}
"@
    Write-Message "New-RscQueryAws -ArtifactsToDelete" @"
    Retrieves the AWS artifacts that need to be deleted when an account is being deleted.
"@ "[GraphQL: awsArtifactsToDelete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllRegions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
"@
    Write-Message "New-RscQueryAws -AllRegions" @"
    All valid AWS regions for this cloud account.
"@ "[GraphQL: allAwsRegions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllCdmVersions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllCdmVersions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllCdmVersions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	region = <System.String>
}
"@
    Write-Message "New-RscQueryAws -AllCdmVersions" @"
    Get all Rubrik CDM versions in the AWS marketplace.
"@ "[GraphQL: allAwsCdmVersions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAws -AllInstanceProfileNames
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAws -AllInstanceProfileNames).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAws -AllInstanceProfileNames
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.region = <System.String>
"@
    Write-Message "New-RscQueryAws -AllInstanceProfileNames" @"
    All Rubrik CC-ES instance profiles in the AWS account.
"@ "[GraphQL: allAwsInstanceProfileNames]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryAzure -NativeRoot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeRoot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeRoot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryAzure -NativeRoot" @"
    Root of Azure native hierarchy.
"@ "[GraphQL: azureNativeRoot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeSubscription).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeSubscription
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -NativeSubscription" @"
    Retrieves an Azure Native Subscription. Refers to the logical entity that provides entitlement to deploy and consume Azure resources.
"@ "[GraphQL: azureNativeSubscription]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeSubscriptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeSubscriptions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeSubscriptions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeSubscriptionSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeSubscriptionSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.subscriptionFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
}
# OPTIONAL
$inputs.Var.authorizedOperationFilter = <Operation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Operation]) for enum values.
# OPTIONAL
$inputs.Var.workloadHierarchy = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
# OPTIONAL
$inputs.Var.azureNativeProtectionFeature = <AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
"@
    Write-Message "New-RscQueryAzure -NativeSubscriptions" @"
    Retrieves a paginated list of all Azure Native Subscriptions.
"@ "[GraphQL: azureNativeSubscriptions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeResourceGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeResourceGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeResourceGroup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.resourceGroupId = <System.String>
"@
    Write-Message "New-RscQueryAzure -NativeResourceGroup" @"
    Retrieves an Azure Native Resource Group. Refers to a collection of resources in which multiple Azure services can reside.
"@ "[GraphQL: azureNativeResourceGroup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeResourceGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeResourceGroups
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeCommonResourceGroupSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeCommonResourceGroupSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.commonResourceGroupFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
}
# OPTIONAL
$inputs.Var.protectedObjectTypes = @(
	<WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$inputs.Var.azureNativeProtectionFeatures = @(
	<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
)
"@
    Write-Message "New-RscQueryAzure -NativeResourceGroups" @"
    Retrieves a paginated list of all Azure Native Resource Groups.
"@ "[GraphQL: azureNativeResourceGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeVirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeVirtualMachine
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureVirtualMachineRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -NativeVirtualMachine" @"
    Retrieves an Azure Virtual Machine that refers to the Azure infrastructure as a service (IaaS) used to deploy persistent VMs. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/.
"@ "[GraphQL: azureNativeVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeVirtualMachines
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeVirtualMachines).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeVirtualMachines
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeVirtualMachineSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeVirtualMachineSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.descendantTypeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.virtualMachineFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	vmSizeFilter = @{
		# REQUIRED
		vmSizes = @(
			<System.String>
		)
	}
	# OPTIONAL
	vnetFilter = @{
		# REQUIRED
		vnetNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	exocomputeConnectedFilter = @{
		# REQUIRED
		isConnected = <System.Boolean>
	}
	# OPTIONAL
	fileIndexingFilter = @{
		# REQUIRED
		statuses = @(
			<AzureNativeFileIndexingStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
		)
	}
	# OPTIONAL
	appProtectionStatusFilter = @{
		# REQUIRED
		isProtectionSetup = <System.Boolean>
	}
	# OPTIONAL
	rbsStatusFilter = @{
		# REQUIRED
		status = <CloudInstanceRbsConnectionStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudInstanceRbsConnectionStatus]) for enum values.
	}
}
"@
    Write-Message "New-RscQueryAzure -NativeVirtualMachines" @"
    Retrieves a paginated list of all Azure Virtual Machines (VMs).
"@ "[GraphQL: azureNativeVirtualMachines]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeManagedDisk
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeManagedDisk).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeManagedDisk
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureManagedDiskRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -NativeManagedDisk" @"
    Retrieves an Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview.
"@ "[GraphQL: azureNativeManagedDisk]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -NativeManagedDisks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -NativeManagedDisks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -NativeManagedDisks
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureNativeDiskSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeDiskSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.diskFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	diskTypeFilter = @{
		# REQUIRED
		diskTypes = @(
			<System.String>
		)
	}
	# OPTIONAL
	attachedVmFilter = @{
		# REQUIRED
		virtualMachineIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	exocomputeConnectedFilter = @{
		# REQUIRED
		isConnected = <System.Boolean>
	}
	# OPTIONAL
	fileIndexingFilter = @{
		# REQUIRED
		statuses = @(
			<AzureNativeFileIndexingStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeFileIndexingStatus]) for enum values.
		)
	}
}
"@
    Write-Message "New-RscQueryAzure -NativeManagedDisks" @"
    Retrieves a paginated list of all Azure Native Managed Disks.
"@ "[GraphQL: azureNativeManagedDisks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeVirtualNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeVirtualNetworks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeVirtualNetworks
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.azureSubscriptionRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -AllNativeVirtualNetworks" @"
    Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview.
"@ "[GraphQL: allAzureNativeVirtualNetworks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAzure -AllNativeSubnetsByRegionFromAzure" @"
    Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.
"@ "[GraphQL: allAzureNativeSubnetsByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure" @"
    Retrieves all security groups in the specified region and subscription. Security groups enable you to configure network security as a natural extension of an application's structure, allowing you to group virtual machines and define network security policies based on those groups. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/application-security-groups.
"@ "[GraphQL: allAzureNativeSecurityGroupsByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllDiskEncryptionSetsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllDiskEncryptionSetsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllDiskEncryptionSetsByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAzure -AllDiskEncryptionSetsByRegion" @"
    List of all Azure Disk Encryption Sets in a region.
"@ "[GraphQL: allAzureDiskEncryptionSetsByRegion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure" @"
    Retrieves all availability sets in the specified region, resource group, and subscription. An availability set is a logical grouping of VMs to facilitate redundancy and availability. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/availability-set-overview.
"@ "[GraphQL: allAzureNativeAvailabilitySetsByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.vmSnapshotId = <System.String>
"@
    Write-Message "New-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure" @"
    Retrieves all supported virtual machine (VM) sizes when exporting a particular snapshot. Not all VM sizes are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
"@ "[GraphQL: allAzureNativeExportCompatibleVmSizesByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "New-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure" @"
    Retrieves all supported disk types when exporting a specific snapshot. Not all disk types are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types.
"@ "[GraphQL: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeVirtualMachineSizes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeVirtualMachineSizes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeVirtualMachineSizes
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.azureSubscriptionRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -AllNativeVirtualMachineSizes" @"
    Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
"@ "[GraphQL: allAzureNativeVirtualMachineSizes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.diskSnapshotId = <System.String>
"@
    Write-Message "New-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable" @"
    Specifies whether the Managed Disk snapshot is restorable or not. A managed disk is restorable when the restore settings of the Managed Disk are configured on the Azure portal and on the Rubrik platform. When the value is true, the managed disk snapshot is restorable.
"@ "[GraphQL: isAzureNativeManagedDiskSnapshotRestorable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -IsStorageAccountNameAvailable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -IsStorageAccountNameAvailable).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -IsStorageAccountNameAvailable
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.storageAccountName = <System.String>
"@
    Write-Message "New-RscQueryAzure -IsStorageAccountNameAvailable" @"
    Specifies whether the given storage account name is valid and available in Azure to be assigned to a new storage account. When the value is true, the specified account name is available in Azure.
"@ "[GraphQL: isAzureStorageAccountNameAvailable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeStorageAccountsFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeStorageAccountsFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeStorageAccountsFromAzure
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -AllNativeStorageAccountsFromAzure" @"
    Retrieves list of all storage Accounts in a subscription.
"@ "[GraphQL: allAzureNativeStorageAccountsFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlDatabaseRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -SqlDatabase" @"
    Retrieves an Azure SQL Database. Refers to the fully managed SQL database built for the cloud. For more information, see https://azure.microsoft.com/en-us/products/azure-sql/database/.
"@ "[GraphQL: azureSqlDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabases
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlDatabaseSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlDatabaseSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlDatabaseFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
	# OPTIONAL
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscQueryAzure -SqlDatabases" @"
    Retrieves a paginated list of all Azure SQL Databases.
"@ "[GraphQL: azureSqlDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabaseServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabaseServer).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabaseServer
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -SqlDatabaseServer" @"
    Retrieves an Azure SQL Database Server. Refers to the server that contains the Azure SQL Databases. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/logical-servers.
"@ "[GraphQL: azureSqlDatabaseServer]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabaseServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabaseServers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabaseServers
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlDatabaseServerSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlDatabaseServerSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlDatabaseServerFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
}
"@
    Write-Message "New-RscQueryAzure -SqlDatabaseServers" @"
    Retrieves a paginated list of all Azure SQL Database Servers.
"@ "[GraphQL: azureSqlDatabaseServers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlManagedInstanceDatabaseRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -SqlManagedInstanceDatabase" @"
    Retrieves an Azure SQL Managed Instance Database. Refers to the database engine compatible with the latest SQL Server (Enterprise Edition) database engine. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/sql-managed-instance-paas-overview.
"@ "[GraphQL: azureSqlManagedInstanceDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceDatabases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceDatabases
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlManagedInstanceDatabaseSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceDatabaseSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlManagedInstanceDatabaseFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	relicFilter = @{
		# REQUIRED
		relic = <System.Boolean>
	}
	# OPTIONAL
	serverFilter = @{
		# REQUIRED
		serverNames = @(
			<System.String>
		)
	}
}
"@
    Write-Message "New-RscQueryAzure -SqlManagedInstanceDatabases" @"
    Retrieves a paginated list of all Azure SQL Managed Instance Databases.
"@ "[GraphQL: azureSqlManagedInstanceDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceServer).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceServer
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlManagedInstanceServerRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -SqlManagedInstanceServer" @"
    Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of.
"@ "[GraphQL: azureSqlManagedInstanceServer]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceServers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceServers
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <AzureSqlManagedInstanceServerSortFields> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureSqlManagedInstanceServerSortFields]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.azureSqlManagedInstanceServerFilters = @{
	# OPTIONAL
	nameSubstringFilter = @{
		# REQUIRED
		nameSubstring = <System.String>
	}
	# OPTIONAL
	effectiveSlaFilter = @{
		# REQUIRED
		effectiveSlaIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	resourceGroupFilter = @{
		# REQUIRED
		resourceGroupNames = @(
			<System.String>
		)
	}
	# OPTIONAL
	subscriptionFilter = @{
		# REQUIRED
		subscriptionIds = @(
			<System.String>
		)
	}
	# OPTIONAL
	regionFilter = @{
		# REQUIRED
		regions = @(
			<AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
		)
	}
	# OPTIONAL
	tagFilter = @{
		# REQUIRED
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
	}
}
"@
    Write-Message "New-RscQueryAzure -SqlManagedInstanceServers" @"
    Retrieves a paginated list of all Azure SQL Managed Instance Servers.
"@ "[GraphQL: azureSqlManagedInstanceServers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
"@
    Write-Message "New-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure" @"
    Point-in-Time (PiT) restore window of the Azure SQL Database instance in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://azure.microsoft.com/en-in/blog/azure-sql-database-point-in-time-restore/.
"@ "[GraphQL: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlManagedInstanceName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
"@
    Write-Message "New-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure" @"
    Point-in-Time (PiT) restore window of the Azure SQL Managed Instance database in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/point-in-time-restore?tabs=azure-portal.
"@ "[GraphQL: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport" @"
    Validates the name used for an Sql Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.
"@ "[GraphQL: validateAzureNativeSqlDatabaseDbNameForExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
# REQUIRED
$inputs.Var.azureSqlManagedInstanceServerRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport" @"
    Validates the name used for an Managed Instance Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.
"@ "[GraphQL: validateAzureNativeSqlManagedInstanceDbNameForExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllSqlDatabaseServerElasticPools
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllSqlDatabaseServerElasticPools).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllSqlDatabaseServerElasticPools
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>
"@
    Write-Message "New-RscQueryAzure -AllSqlDatabaseServerElasticPools" @"
    Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview.
"@ "[GraphQL: allAzureSqlDatabaseServerElasticPools]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snapshotId = <System.String>
"@
    Write-Message "New-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent" @"
    Checks if an Azure SQL Database Snapshot or an Azure SQL Managed Instance Database Snapshot is a persistent snapshot.
"@ "[GraphQL: isAzureNativeSqlDatabaseSnapshotPersistent]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllKeyVaultsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllKeyVaultsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllKeyVaultsByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureKeyVaultsInput = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	region = <AzureRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureRegion]) for enum values.
	# OPTIONAL
	userAssignedManagedIdentityPrincipalId = <System.String>
}
"@
    Write-Message "New-RscQueryAzure -AllKeyVaultsByRegion" @"
    List of all Azure Key Vaults in a region.
"@ "[GraphQL: allAzureKeyVaultsByRegion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllEncryptionKeys
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllEncryptionKeys).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllEncryptionKeys
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureEncryptionKeysInput = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	keyVaultName = <System.String>
	# REQUIRED
	resourceGroupName = <System.String>
}
"@
    Write-Message "New-RscQueryAzure -AllEncryptionKeys" @"
    List of all Encryption Keys in an Azure Key Vault.
"@ "[GraphQL: allAzureEncryptionKeys]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountTenant
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountTenant).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountTenant
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.subscriptionStatusFilters = @(
	<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# REQUIRED
$inputs.Var.subscriptionSearchText = <System.String>
# OPTIONAL
$inputs.Var.subscriptionIdsFilter = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryAzure -CloudAccountTenant" @"
    Retrieves the details of the Azure tenant and all the subscriptions of the tenant, for a feature.
"@ "[GraphQL: azureCloudAccountTenant]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountTenantWithExoConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountTenantWithExoConfigs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountTenantWithExoConfigs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.subscriptionStatusFilters = @(
	<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
# REQUIRED
$inputs.Var.subscriptionSearchText = <System.String>
# OPTIONAL
$inputs.Var.subscriptionIdsFilter = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryAzure -CloudAccountTenantWithExoConfigs" @"
    Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature.
"@ "[GraphQL: azureCloudAccountTenantWithExoConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCloudAccountTenants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCloudAccountTenants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCloudAccountTenants
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.features = @(
	<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.includeSubscriptionDetails = <System.Boolean>
"@
    Write-Message "New-RscQueryAzure -AllCloudAccountTenants" @"
    Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, and subscription name.
"@ "[GraphQL: allAzureCloudAccountTenants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountSubscriptionWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountSubscriptionWithFeatures).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountSubscriptionWithFeatures
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
"@
    Write-Message "New-RscQueryAzure -CloudAccountSubscriptionWithFeatures" @"
    Retrieves the details of the Azure cloud account.
"@ "[GraphQL: azureCloudAccountSubscriptionWithFeatures]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.subscriptionStatusFilters = @(
	<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
"@
    Write-Message "New-RscQueryAzure -AllCloudAccountSubscriptionsByFeature" @"
    Retrieves a list of all Azure Subscriptions with feature details such as feature, status, and regions.
"@ "[GraphQL: allAzureCloudAccountSubscriptionsByFeature]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllSubscriptionWithExocomputeMappings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllSubscriptionWithExocomputeMappings).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllSubscriptionWithExocomputeMappings
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.features = @(
	<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
)
# OPTIONAL
$inputs.Var.exocomputeSubscriptionIdsFilter = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryAzure -AllSubscriptionWithExocomputeMappings" @"
    Retrieves a list of all Azure subscriptions with Exocompute subscription mapping.
"@ "[GraphQL: allAzureSubscriptionWithExocomputeMappings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllResourceGroupsFrom
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllResourceGroupsFrom).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllResourceGroupsFrom
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureSubscriptionNativeId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
"@
    Write-Message "New-RscQueryAzure -AllResourceGroupsFrom" @"
    Retrieves a list og all resource groups in the specified account.
"@ "[GraphQL: allResourceGroupsFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -DoesNativeResourceGroupExist
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -DoesNativeResourceGroupExist).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -DoesNativeResourceGroupExist
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureSubscriptionNativeId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
"@
    Write-Message "New-RscQueryAzure -DoesNativeResourceGroupExist" @"
    Checks if a resource group with the specified name exists in the specified account.
"@ "[GraphQL: doesAzureNativeResourceGroupExist]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	sessionId = <System.String>
	# REQUIRED
	resourceGroupInputs = @(
		@{
			# REQUIRED
			subscriptionNativeId = <System.String>
			# REQUIRED
			resourceGroupName = <System.String>
		}
	)
}
"@
    Write-Message "New-RscQueryAzure -AllNativeResourceGroupsInfoIfExist" @"
    Retrieves a list of resource groups with the specified names which exist in the specified account.
"@ "[GraphQL: allAzureNativeResourceGroupsInfoIfExist]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCloudAccountMissingPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCloudAccountMissingPermissions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCloudAccountMissingPermissions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.sessionId = <System.String>
# REQUIRED
$inputs.Var.subscriptionIds = @(
	<System.String>
)
# REQUIRED
$inputs.Var.cloudAccountAction = <CloudAccountAction> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountAction]) for enum values.
"@
    Write-Message "New-RscQueryAzure -AllCloudAccountMissingPermissions" @"
    Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account.
"@ "[GraphQL: allAzureCloudAccountMissingPermissions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CloudAccountPermissionConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CloudAccountPermissionConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CloudAccountPermissionConfig
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
"@
    Write-Message "New-RscQueryAzure -CloudAccountPermissionConfig" @"
    Retrieves the configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Polaris features that the customer wants to be enabled on the cloud account.
"@ "[GraphQL: azureCloudAccountPermissionConfig]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllExocomputeConfigsInAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllExocomputeConfigsInAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllExocomputeConfigsInAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.azureExocomputeSearchQuery = <System.String>
# OPTIONAL
$inputs.Var.cloudAccountIDs = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryAzure -AllExocomputeConfigsInAccount" @"
    Retrieves a list of Azure Exocompute configurations filtered by a cloud account ID or a search query.
"@ "[GraphQL: allAzureExocomputeConfigsInAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCloudAccountSubnetsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCloudAccountSubnetsByRegion).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCloudAccountSubnetsByRegion
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
"@
    Write-Message "New-RscQueryAzure -AllCloudAccountSubnetsByRegion" @"
    Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.
"@ "[GraphQL: allAzureCloudAccountSubnetsByRegion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	azureExocomputeRegionConfigs = @(
		@{
			# REQUIRED
			region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
			# REQUIRED
			subnetNativeId = <System.String>
			# REQUIRED
			isRscManaged = <System.Boolean>
			# OPTIONAL
			podSubnetNativeId = <System.String>
		}
	)
}
"@
    Write-Message "New-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations" @"
    Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space.
"@ "[GraphQL: validateAzureCloudAccountExocomputeConfigurations]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllArmTemplatesByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllArmTemplatesByFeature).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllArmTemplatesByFeature
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	customerTenantDomainName = <System.String>
	# REQUIRED
	features = @(
		<CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
	)
	# REQUIRED
	operationType = <CloudAccountOperation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountOperation]) for enum values.
	# REQUIRED
	cloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
	# OPTIONAL
	featuresToInclude = @(
		@{
			# OPTIONAL
			permissionsGroups = @(
				<PermissionsGroup> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PermissionsGroup]) for enum values.
			)
			# REQUIRED
			featureType = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
		}
	)
}
"@
    Write-Message "New-RscQueryAzure -AllArmTemplatesByFeature" @"
    Retrieve ARM templates for role definition and role assignment.
"@ "[GraphQL: allAzureArmTemplatesByFeature]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.unmappingValidationType = <UnmappingValidationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
"@
    Write-Message "New-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap" @"
    Checks if we can unmap the archival location from the subscription.
"@ "[GraphQL: checkAzurePersistentStorageSubscriptionCanUnmap]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -Subscriptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -Subscriptions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -Subscriptions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
"@
    Write-Message "New-RscQueryAzure -Subscriptions" @"
    Gets the subscriptions for the given Azure tenant.
"@ "[GraphQL: azureSubscriptions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -Regions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -Regions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -Regions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
"@
    Write-Message "New-RscQueryAzure -Regions" @"
    Gets the Azure regions for the given subscription.
"@ "[GraphQL: azureRegions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -ResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -ResourceGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -ResourceGroups
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
"@
    Write-Message "New-RscQueryAzure -ResourceGroups" @"
    Gets the Azure resource groups for the given subscription.
"@ "[GraphQL: azureResourceGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -VNets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -VNets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -VNets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>
"@
    Write-Message "New-RscQueryAzure -VNets" @"
    Gets the VNets for the given subscription.
"@ "[GraphQL: azureVNets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -Subnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -Subnets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -Subnets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.vNetId = <System.String>
"@
    Write-Message "New-RscQueryAzure -Subnets" @"
    Gets the subnets for the given subscription.
"@ "[GraphQL: azureSubnets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -StorageAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -StorageAccounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -StorageAccounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>
"@
    Write-Message "New-RscQueryAzure -StorageAccounts" @"
    Gets the storage accounts for the given subscription.
"@ "[GraphQL: azureStorageAccounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllHostedRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllHostedRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllHostedRegions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryAzure -AllHostedRegions" @"
    Lists all Azure regions supported by the Rubrik-Hosted SaaS protection.
"@ "[GraphQL: allHostedAzureRegions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllResourceGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllResourceGroups
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureRegion = <System.String>
"@
    Write-Message "New-RscQueryAzure -AllResourceGroups" @"
    Get resource groups for a service principal in Azure.
"@ "[GraphQL: allAzureResourceGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllVnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllVnets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllVnets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.vnetRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}
"@
    Write-Message "New-RscQueryAzure -AllVnets" @"
    Get VNets for a given account in Azure.
"@ "[GraphQL: allAzureVnets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllSubnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllSubnets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllSubnets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.subnetRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
	# OPTIONAL
	vnetName = <System.String>
}
"@
    Write-Message "New-RscQueryAzure -AllSubnets" @"
    Get subnets for a given account in Azure.
"@ "[GraphQL: allAzureSubnets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllCdmVersions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllCdmVersions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllCdmVersions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cdmVersionRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	location = <System.String>
}
"@
    Write-Message "New-RscQueryAzure -AllCdmVersions" @"
    Get all Rubrik CDM versions in the Azure marketplace.
"@ "[GraphQL: allAzureCdmVersions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllRegions).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllRegions
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
"@
    Write-Message "New-RscQueryAzure -AllRegions" @"
    Get all available regions for Azure.
"@ "[GraphQL: allAzureRegions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllNsgs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllNsgs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllNsgs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.nsgRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}
"@
    Write-Message "New-RscQueryAzure -AllNsgs" @"
    Get all available network security groups for Azure.
"@ "[GraphQL: allAzureNsgs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllStorageAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllStorageAccounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllStorageAccounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.storageAccountsRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}
"@
    Write-Message "New-RscQueryAzure -AllStorageAccounts" @"
    List all storage accounts from Azure.
"@ "[GraphQL: allAzureStorageAccounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzure -AllManagedIdentities
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzure -AllManagedIdentities).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzure -AllManagedIdentities
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.managedIdentitiesRequest = @{
	# REQUIRED
	cloudAccountId = <System.String>
}
"@
    Write-Message "New-RscQueryAzure -AllManagedIdentities" @"
    List all managed identities for Azure resources.
"@ "[GraphQL: allAzureManagedIdentities]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryAzureO365 -Exocompute
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -Exocompute).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -Exocompute
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.exocomputeClusterId = <System.String>
"@
    Write-Message "New-RscQueryAzureO365 -Exocompute" @"
    Gets the exocompute details of the given cluster.
"@ "[GraphQL: azureO365Exocompute]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckStorageAccountName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckStorageAccountName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckStorageAccountName
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.storage_account_name = <System.String>
"@
    Write-Message "New-RscQueryAzureO365 -CheckStorageAccountName" @"
    Checks the storage account name.
"@ "[GraphQL: azureO365CheckStorageAccountName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckStorageAccountAccessibility
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckStorageAccountAccessibility).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckStorageAccountAccessibility
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.storage_account_name = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>
"@
    Write-Message "New-RscQueryAzureO365 -CheckStorageAccountAccessibility" @"
    Checks the accessibility of the storage account.
"@ "[GraphQL: azureO365CheckStorageAccountAccessibility]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckSubscriptionQuota
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckSubscriptionQuota).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckSubscriptionQuota
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>
"@
    Write-Message "New-RscQueryAzureO365 -CheckSubscriptionQuota" @"
    Checks the Azure subscription quota.
"@ "[GraphQL: azureO365CheckSubscriptionQuota]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckResourceGroupName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckResourceGroupName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckResourceGroupName
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>
"@
    Write-Message "New-RscQueryAzureO365 -CheckResourceGroupName" @"
    Checks the resource group name.
"@ "[GraphQL: azureO365CheckResourceGroupName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckVirtualNetworkName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckVirtualNetworkName).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckVirtualNetworkName
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
"@
    Write-Message "New-RscQueryAzureO365 -CheckVirtualNetworkName" @"
    Checks the virtual network name.
"@ "[GraphQL: azureO365CheckVirtualNetworkName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -ValidateUserRoles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -ValidateUserRoles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -ValidateUserRoles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
"@
    Write-Message "New-RscQueryAzureO365 -ValidateUserRoles" @"
    Validates the user roles in the subscription.
"@ "[GraphQL: azureO365ValidateUserRoles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckNSGOutboundRules
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckNSGOutboundRules).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckNSGOutboundRules
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
# REQUIRED
$inputs.Var.subnet_name = <System.String>
"@
    Write-Message "New-RscQueryAzureO365 -CheckNSGOutboundRules" @"
    Checks the NSG Outbound rules of the Azure resources.
"@ "[GraphQL: azureO365CheckNSGOutboundRules]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -CheckNetworkSubnet
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -CheckNetworkSubnet).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -CheckNetworkSubnet
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
# REQUIRED
$inputs.Var.subnet_name = <System.String>
# REQUIRED
$inputs.Var.strict_addr_check = <System.Boolean>
"@
    Write-Message "New-RscQueryAzureO365 -CheckNetworkSubnet" @"
    Checks the network subnet of the Azure resources.
"@ "[GraphQL: azureO365CheckNetworkSubnet]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.vnet_name = <System.String>
# REQUIRED
$inputs.Var.subnet_name = <System.String>
# REQUIRED
$inputs.Var.strict_addr_check = <System.Boolean>
"@
    Write-Message "New-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr" @"
    Retrieves the unused addresses available in a subnet.
"@ "[GraphQL: azureO365GetNetworkSubnetUnusedAddr]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryAzureO365 -GetAzureHostType
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryAzureO365 -GetAzureHostType).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryAzureO365 -GetAzureHostType
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryAzureO365 -GetAzureHostType" @"
    Retrieves the AzureHostType of the account.
"@ "[GraphQL: azureO365GetAzureHostType]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryCassandra -Sources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -Sources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -Sources
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryCassandra -Sources" @"
    Paginated list of cassandra sources.
"@ "[GraphQL: cassandraSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -Keyspaces
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -Keyspaces).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -Keyspaces
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryCassandra -Keyspaces" @"
    Paginated list of cassandra keyspaces.
"@ "[GraphQL: cassandraKeyspaces]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -ColumnFamilies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -ColumnFamilies).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -ColumnFamilies
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryCassandra -ColumnFamilies" @"
    Paginated list of cassandra column families.
"@ "[GraphQL: cassandraColumnFamilies]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -ColumnFamilyRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -ColumnFamilyRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -ColumnFamilyRecoverableRange
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryRangeRequestData = @{
		# OPTIONAL
		sourceType = <MosaicRecoverableRangeRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRecoverableRangeRequestSourceType]) for enum values.
		# REQUIRED
		databaseName = <System.String>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		tableName = <System.String>
	}
}
"@
    Write-Message "New-RscQueryCassandra -ColumnFamilyRecoverableRange" @"
    Get Recoverable Range of a Cassandra Column Family.
"@ "[GraphQL: cassandraColumnFamilyRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -ColumnFamilySchema
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -ColumnFamilySchema).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -ColumnFamilySchema
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	schemaRequestData = @{
		# REQUIRED
		databaseName = <System.String>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		tableName = <System.String>
		# REQUIRED
		versionTimestamp = <System.String>
	}
}
"@
    Write-Message "New-RscQueryCassandra -ColumnFamilySchema" @"
    Get Schema of a Cassandra Column Family.
"@ "[GraphQL: cassandraColumnFamilySchema]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -Source
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -Source).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -Source
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryCassandra -Source" @"
    Details of a cassandra source.
"@ "[GraphQL: cassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -Keyspace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -Keyspace).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -Keyspace
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryCassandra -Keyspace" @"
    Details of a cassandra keyspace.
"@ "[GraphQL: cassandraKeyspace]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCassandra -ColumnFamily
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCassandra -ColumnFamily).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCassandra -ColumnFamily
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryCassandra -ColumnFamily" @"
    Details of a cassandra column family.
"@ "[GraphQL: cassandraColumnFamily]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryCluster -Nodes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Nodes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Nodes
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -Nodes" @"
    Get list of nodes in this Rubrik cluster

Supported in v5.0+
Returns the list of all Rubrik nodes.
"@ "[GraphQL: clusterNodes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -List).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -List
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	id = @(
		<System.String>
	)
	# OPTIONAL
	name = @(
		<System.String>
	)
	# OPTIONAL
	type = @(
		<ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	objectType = @(
		<ObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = <DateTime>
	# OPTIONAL
	registrationTime_lt = <DateTime>
	# OPTIONAL
	minSoftwareVersion = <System.String>
	# OPTIONAL
	clusterLocation = @(
		<System.String>
	)
	# OPTIONAL
	excludeEmptyCluster = <System.Boolean>
	# OPTIONAL
	productType = @(
		<ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
	# OPTIONAL
	registeredMode = @(
		<ClusterRegistrationMode> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
	)
	# OPTIONAL
	product = <Product> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
	# OPTIONAL
	orgId = @(
		<System.String>
	)
	# OPTIONAL
	productFilters = @(
		@{
			# REQUIRED
			productType = <ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
			# OPTIONAL
			minSoftwareVersion = <System.String>
		}
	)
	# OPTIONAL
	excludeId = @(
		<System.String>
	)
	# OPTIONAL
	systemStatus = @(
		<ClusterSystemStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		<ClusterStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	isInFatalOrDisconnectedState = <System.Boolean>
}
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <ClusterSortByEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSortByEnum]) for enum values.
"@
    Write-Message "New-RscQueryCluster -List" @"
    List of the available cluster objects.
"@ "[GraphQL: clusterConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Cluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "New-RscQueryCluster -Cluster" @"
    A cluster object.
"@ "[GraphQL: cluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -WithUpgradesInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -WithUpgradesInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -WithUpgradesInfo
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.upgradeFilter = @{
	# OPTIONAL
	id = @(
		<System.String>
	)
	# OPTIONAL
	name = @(
		<System.String>
	)
	# OPTIONAL
	type = @(
		<ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = <DateTime>
	# OPTIONAL
	registrationTime_lt = <DateTime>
	# OPTIONAL
	minSoftwareVersion = <System.String>
	# OPTIONAL
	downloadedVersion = @(
		<System.String>
	)
	# OPTIONAL
	installedVersion = @(
		<System.String>
	)
	# OPTIONAL
	upgradeJobStatus = @(
		<ClusterJobStatusTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterJobStatusTypeEnum]) for enum values.
	)
	# OPTIONAL
	clusterLocation = @(
		<System.String>
	)
	# OPTIONAL
	versionStatus = @(
		<VersionStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VersionStatus]) for enum values.
	)
	# OPTIONAL
	prechecksStatus = @(
		<PrechecksStatusTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.PrechecksStatusTypeEnum]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		<ClusterStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	upgradeScheduled = <System.Boolean>
	# OPTIONAL
	productType = @(
		<ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
}
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <UpgradeInfoSortByEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UpgradeInfoSortByEnum]) for enum values.
"@
    Write-Message "New-RscQueryCluster -WithUpgradesInfo" @"
    
"@ "[GraphQL: clusterWithUpgradesInfo]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Dns
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Dns).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Dns
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "New-RscQueryCluster -Dns" @"
    Rubrik cluster DNS information.
"@ "[GraphQL: clusterDns]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Proxy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Proxy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Proxy
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "New-RscQueryCluster -Proxy" @"
    Rubrik cluster proxy information.
"@ "[GraphQL: clusterProxy]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -NtpServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -NtpServers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -NtpServers
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -NtpServers" @"
    Get NTP Servers

Supported in v5.0+
Retrieve a list of the NTP servers assigned to the Rubrik cluster. Encryption keys are not reported.
"@ "[GraphQL: clusterNtpServers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -NetworkInterfaces
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -NetworkInterfaces).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -NetworkInterfaces
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	interface = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -NetworkInterfaces" @"
    Get network interfaces for a Rubrik Cluster cluster

Supported in v5.0+
Retrieves network interfaces(including VLANs) on bond0/bond1.
"@ "[GraphQL: clusterNetworkInterfaces]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -FloatingIps
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -FloatingIps).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -FloatingIps
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -FloatingIps" @"
    Get a list of a cluster's always-available Ips

Supported in v5.0+
Get a list of a cluster's always-available Ips.
"@ "[GraphQL: clusterFloatingIps]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Vlans
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Vlans).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Vlans
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	vlan = <System.Int32>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -Vlans" @"
    Rubrik cluster VLAN information.
"@ "[GraphQL: clusterVlans]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -DefaultGateway
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -DefaultGateway).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -DefaultGateway
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -DefaultGateway" @"
    Get current default gateway

Supported in v5.0+
Get current default gateway.
"@ "[GraphQL: clusterDefaultGateway]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -WebSignedCertificate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -WebSignedCertificate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -WebSignedCertificate
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -WebSignedCertificate" @"
    Get the signed certificate for Web server

Supported in v5.2+
If the web server uses a signed certificate, fetch it.
"@ "[GraphQL: clusterWebSignedCertificate]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Ipmi
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Ipmi).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Ipmi
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -Ipmi" @"
    Get IPMI details

Supported in v5.0+
get IPMI details of availability and enabled access in the cluster.
"@ "[GraphQL: clusterIpmi]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Certificates
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Certificates).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Certificates
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	description = <System.String>
	# OPTIONAL
	expiration = <System.String>
	# OPTIONAL
	hasKey = <System.Boolean>
	# OPTIONAL
	includeExpired = <System.Boolean>
	# OPTIONAL
	isTrusted = <System.Boolean>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	sortBy = <V1QueryCertificatesRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V1QueryCertificatesRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryCertificatesRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -Certificates" @"
    Get all certificates

Supported in v5.1+
Get all certificates.
"@ "[GraphQL: clusterCertificates]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -WebCertsAndIpmis
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -WebCertsAndIpmis).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -WebCertsAndIpmis
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuids = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscQueryCluster -WebCertsAndIpmis" @"
    Get web server certificate and IPMI details for multiple clusters.
"@ "[GraphQL: allClusterWebCertsAndIpmis]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -OperationJobProgress
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -OperationJobProgress).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -OperationJobProgress
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	clusterUuid = <System.String>
	# REQUIRED
	jobType = <CcpJobType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpJobType]) for enum values.
}
"@
    Write-Message "New-RscQueryCluster -OperationJobProgress" @"
    Get updates on the job progress of the Rubrik cluster operation.
"@ "[GraphQL: clusterOperationJobProgress]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Ipv6Mode
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Ipv6Mode).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Ipv6Mode
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -Ipv6Mode" @"
    Rubrik cluster IPv6 mode.
"@ "[GraphQL: clusterIpv6Mode]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Csr
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Csr).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Csr
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -Csr" @"
    Get the cluster certificate signing request

Supported in v7.0+
Returns the certificate signing request generated from the private key of the Rubrik cluster.
"@ "[GraphQL: clusterCsr]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -TypeList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -TypeList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -TypeList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryCluster -TypeList" @"
    
"@ "[GraphQL: clusterTypeList]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -GroupByList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -GroupByList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -GroupByList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# REQUIRED
$inputs.Var.groupBy = <ClusterGroupByEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterGroupByEnum]) for enum values.
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	id = @(
		<System.String>
	)
	# OPTIONAL
	name = @(
		<System.String>
	)
	# OPTIONAL
	type = @(
		<ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
	)
	# OPTIONAL
	objectType = @(
		<ObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ObjectTypeEnum]) for enum values.
	)
	# OPTIONAL
	registrationTime_gt = <DateTime>
	# OPTIONAL
	registrationTime_lt = <DateTime>
	# OPTIONAL
	minSoftwareVersion = <System.String>
	# OPTIONAL
	clusterLocation = @(
		<System.String>
	)
	# OPTIONAL
	excludeEmptyCluster = <System.Boolean>
	# OPTIONAL
	productType = @(
		<ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
	)
	# OPTIONAL
	registeredMode = @(
		<ClusterRegistrationMode> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterRegistrationMode]) for enum values.
	)
	# OPTIONAL
	product = <Product> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Product]) for enum values.
	# OPTIONAL
	orgId = @(
		<System.String>
	)
	# OPTIONAL
	productFilters = @(
		@{
			# REQUIRED
			productType = <ClusterProductEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterProductEnum]) for enum values.
			# OPTIONAL
			minSoftwareVersion = <System.String>
		}
	)
	# OPTIONAL
	excludeId = @(
		<System.String>
	)
	# OPTIONAL
	systemStatus = @(
		<ClusterSystemStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterSystemStatus]) for enum values.
	)
	# OPTIONAL
	connectionState = @(
		<ClusterStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterStatus]) for enum values.
	)
	# OPTIONAL
	isInFatalOrDisconnectedState = <System.Boolean>
}
# OPTIONAL
$inputs.Var.timezoneOffset = <System.Single>
"@
    Write-Message "New-RscQueryCluster -GroupByList" @"
    
"@ "[GraphQL: clusterGroupByConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -DatabaseLogReportingProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -DatabaseLogReportingProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -DatabaseLogReportingProperties
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -DatabaseLogReportingProperties" @"
    Get the database log backup report properties

Supported in v5.3+
Get the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.
"@ "[GraphQL: databaseLogReportingPropertiesForCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -DatabaseLogReport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -DatabaseLogReport).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -DatabaseLogReport
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	logBackupDelay = <System.Int32>
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	effectiveSlaDomainId = <System.String>
	# OPTIONAL
	databaseType = <System.String>
	# OPTIONAL
	location = <System.String>
	# OPTIONAL
	sortBy = <V1QueryLogReportRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V1QueryLogReportRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1QueryLogReportRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryCluster -DatabaseLogReport" @"
    Get the database log backup delay information

Supported in v5.3+
v5.3: 
v6.0+: Get the database log backup delay information.
"@ "[GraphQL: databaseLogReportForCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Connected
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Connected).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Connected
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.clusterFilterArg = <ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
"@
    Write-Message "New-RscQueryCluster -Connected" @"
    List all connected clusters.
"@ "[GraphQL: allConnectedClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -ReplicationTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -ReplicationTargets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -ReplicationTargets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "New-RscQueryCluster -ReplicationTargets" @"
    All replication targets for a cluster.
"@ "[GraphQL: allClusterReplicationTargets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -HostFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -HostFailover).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -HostFailover
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryCluster -HostFailover" @"
    Get details of the given host failover cluster.
"@ "[GraphQL: hostFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -K8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -K8s).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -K8s
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryCluster -K8s" @"
    
"@ "[GraphQL: k8sClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -Windows
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -Windows).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -Windows
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryCluster -Windows" @"
    A Windows Cluster.
"@ "[GraphQL: windowsCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -ReportMigrationStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -ReportMigrationStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -ReportMigrationStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.status = @(
	<CdmReportMigrationStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)
# OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
"@
    Write-Message "New-RscQueryCluster -ReportMigrationStatus" @"
    Retrieve details of the Rubrik clusters' reports migration.
"@ "[GraphQL: clusterReportMigrationStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -ReportMigrationCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -ReportMigrationCount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -ReportMigrationCount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.status = @(
	<CdmReportMigrationStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)
"@
    Write-Message "New-RscQueryCluster -ReportMigrationCount" @"
    Retrieve the counts of the Rubrik cluster reports migration.
"@ "[GraphQL: clusterReportMigrationCount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -ReportMigrationJobStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -ReportMigrationJobStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -ReportMigrationJobStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "New-RscQueryCluster -ReportMigrationJobStatus" @"
    Retrieve the status of the cluster report migration job.
"@ "[GraphQL: clusterReportMigrationJobStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -SlaDomains
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -SlaDomains).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -SlaDomains
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
"@
    Write-Message "New-RscQueryCluster -SlaDomains" @"
    Returns paginated list of SLA domains that were created on Rubrik CDM.
"@ "[GraphQL: clusterSlaDomains]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -VerifySlaWithReplicationTo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -VerifySlaWithReplicationTo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -VerifySlaWithReplicationTo
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>
# REQUIRED
$inputs.Var.includeArchived = <System.Boolean>
"@
    Write-Message "New-RscQueryCluster -VerifySlaWithReplicationTo" @"
    Verify for a Rubrik cluster if it is replication target in any SLA Domain.
"@ "[GraphQL: verifySlaWithReplicationToCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -GlobalSlas
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -GlobalSlas).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -GlobalSlas
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>
"@
    Write-Message "New-RscQueryCluster -GlobalSlas" @"
    Global SLA Domains protecting at least one object on the specified Rubrik cluster.
"@ "[GraphQL: allClusterGlobalSlas]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -RegistrationProductInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -RegistrationProductInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -RegistrationProductInfo
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryCluster -RegistrationProductInfo" @"
    Info about the cluster product types the user is entitled to.
"@ "[GraphQL: clusterRegistrationProductInfo]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -IsTotpAckNecessary
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -IsTotpAckNecessary).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -IsTotpAckNecessary
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "New-RscQueryCluster -IsTotpAckNecessary" @"
    Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.
"@ "[GraphQL: isTotpAckNecessaryForCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryCluster -TotpAckStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryCluster -TotpAckStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryCluster -TotpAckStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.listClusterUuid = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryCluster -TotpAckStatus" @"
    Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.
"@ "[GraphQL: allClustersTotpAckStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryDb2 -Instances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -Instances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -Instances
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryDb2 -Instances" @"
    Connection of filtered db2 instances based on specific filters.
"@ "[GraphQL: db2Instances]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -Instance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -Instance
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.id = <System.String>
"@
    Write-Message "New-RscQueryDb2 -Instance" @"
    Details of a db2 instance for a given fid.
"@ "[GraphQL: db2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -Database
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryDb2 -Database" @"
    Details of a db2 database for a given fid.
"@ "[GraphQL: db2Database]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -Databases
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryDb2 -Databases" @"
    Connection of filtered db2 databases based on specific filters.
"@ "[GraphQL: db2Databases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -RecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -RecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -RecoverableRange
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.db2RecoverableRangeFid = <System.String>
"@
    Write-Message "New-RscQueryDb2 -RecoverableRange" @"
    Details of a Db2 recoverable range for a given fid.
"@ "[GraphQL: db2RecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -RecoverableRanges
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <Db2RecoverableRangeSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2RecoverableRangeSortBy]) for enum values.
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	clusterUuid = @(
		<System.String>
	)
	# OPTIONAL
	databaseId = @(
		<System.String>
	)
	# OPTIONAL
	fromTime = <DateTime>
	# OPTIONAL
	toTime = <DateTime>
	# OPTIONAL
	isArchived = <System.Boolean>
}
"@
    Write-Message "New-RscQueryDb2 -RecoverableRanges" @"
    Connection of all recoverable ranges for Db2.
"@ "[GraphQL: db2RecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -LogSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -LogSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -LogSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.db2LogSnapshotFid = <System.String>
"@
    Write-Message "New-RscQueryDb2 -LogSnapshot" @"
    Details of a Db2 log snapshot for a given fid.
"@ "[GraphQL: db2LogSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryDb2 -LogSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryDb2 -LogSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryDb2 -LogSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <Db2LogSnapshotSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Db2LogSnapshotSortBy]) for enum values.
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	workloadId = @(
		<System.String>
	)
	# OPTIONAL
	clusterUuid = @(
		<System.String>
	)
	# OPTIONAL
	fromTime = <DateTime>
	# OPTIONAL
	toTime = <DateTime>
	# OPTIONAL
	isArchived = <System.Boolean>
}
"@
    Write-Message "New-RscQueryDb2 -LogSnapshots" @"
    Connection of all log snapshots for Db2.
"@ "[GraphQL: db2LogSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryHyperv -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -TopLevelDescendants
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryHyperv -TopLevelDescendants" @"
    Paginated list of the highest-level HyperV Objects accessible by the current user.
"@ "[GraphQL: hypervTopLevelDescendants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -VirtualMachines
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -VirtualMachines).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -VirtualMachines
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryHyperv -VirtualMachines" @"
    Paginated list of HyperV Virtual Machines.
"@ "[GraphQL: hypervVirtualMachines]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Scvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Scvmm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Scvmm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryHyperv -Scvmm" @"
    Details of the given Hyper-V SCVMM.
"@ "[GraphQL: hypervScvmm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Cluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryHyperv -Cluster" @"
    Details of the given Hyper-V Cluster.
"@ "[GraphQL: hypervCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Server
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Server).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Server
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryHyperv -Server" @"
    Details of the given Hyper-V Server.
"@ "[GraphQL: hypervServer]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -VirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -VirtualMachine).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -VirtualMachine
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryHyperv -VirtualMachine" @"
    Details of the given Hyper-V Virtual Machine.
"@ "[GraphQL: hypervVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -UniqueServersCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -UniqueServersCount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -UniqueServersCount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryHyperv -UniqueServersCount" @"
    Count of unique HyperV Servers.
"@ "[GraphQL: uniqueHypervServersCount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Scvmms
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Scvmms).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Scvmms
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryHyperv -Scvmms" @"
    Paginated list of HyperV SCVMMs.
"@ "[GraphQL: hypervScvmms]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Servers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Servers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Servers
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	effectiveSlaDomainId = <System.String>
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	primaryClusterId = <System.String>
	# OPTIONAL
	slaAssignment = <InternalQueryHypervHostRequestSlaAssignment> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSlaAssignment]) for enum values.
	# OPTIONAL
	sortBy = <InternalQueryHypervHostRequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <InternalQueryHypervHostRequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalQueryHypervHostRequestSortOrder]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryHyperv -Servers" @"
    Get summary of all the Hyper-V hosts

Supported in v5.0+
Get summary of all the Hyper-V hosts.
"@ "[GraphQL: hypervServers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -Mounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -Mounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -Mounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <HypervLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <HypervLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HypervLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
"@
    Write-Message "New-RscQueryHyperv -Mounts" @"
    HyperV Live Mount Connection.
"@ "[GraphQL: hypervMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -VmDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -VmDetail).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -VmDetail
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryHyperv -VmDetail" @"
    HyperV Virtual Machine detail from CDM.
"@ "[GraphQL: hypervVmDetail]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -HostAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -HostAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -HostAsyncRequestStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryHyperv -HostAsyncRequestStatus" @"
    Get Hyper-V host async request

Supported in v5.0+
Get details about a Hyper-V host related async request.
"@ "[GraphQL: hypervHostAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -ScvmmAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -ScvmmAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -ScvmmAsyncRequestStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryHyperv -ScvmmAsyncRequestStatus" @"
    Get Hyper-V SCVMM async request

Supported in v5.0+
Get details about a Hyper-V SCVMM related async request.
"@ "[GraphQL: hypervScvmmAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryHyperv -VirtualMachineAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryHyperv -VirtualMachineAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryHyperv -VirtualMachineAsyncRequestStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryHyperv -VirtualMachineAsyncRequestStatus" @"
    Get VM async request details

Supported in v5.0+
Get details about a Hyper-V vm related async request.
"@ "[GraphQL: hypervVirtualMachineAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryLdap -IntegrationList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryLdap -IntegrationList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryLdap -IntegrationList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <LdapIntegrationFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LdapIntegrationFieldEnum]) for enum values.
"@
    Write-Message "New-RscQueryLdap -IntegrationList" @"
    Browse LDAP integrations.
"@ "[GraphQL: ldapIntegrationConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryLdap -PrincipalList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryLdap -PrincipalList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryLdap -PrincipalList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <LdapPrincipalFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LdapPrincipalFieldEnum]) for enum values.
# REQUIRED
$inputs.Var.id = <System.String>
# REQUIRED
$inputs.Var.searchText = <System.String>
"@
    Write-Message "New-RscQueryLdap -PrincipalList" @"
    Search LDAP Principals.
"@ "[GraphQL: ldapPrincipalConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryLdap -AuthorizedPrincipalList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryLdap -AuthorizedPrincipalList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryLdap -AuthorizedPrincipalList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.sortBy = <LdapAuthorizedPrincipalFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.LdapAuthorizedPrincipalFieldEnum]) for enum values.
# REQUIRED
$inputs.Var.searchText = <System.String>
# OPTIONAL
$inputs.Var.roleIds = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryLdap -AuthorizedPrincipalList" @"
    Browse LDAP-authorized principals.
"@ "[GraphQL: ldapAuthorizedPrincipalConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryMongo -Sources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Sources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Sources
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryMongo -Sources" @"
    Paginated list of MongoDB sources.
"@ "[GraphQL: mongoSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Databases
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryMongo -Databases" @"
    Paginated list of MongoDB databases.
"@ "[GraphQL: mongoDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Collections
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Collections).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Collections
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryMongo -Collections" @"
    Paginated list of MongoDB collections.
"@ "[GraphQL: mongoCollections]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Source
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Source).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Source
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMongo -Source" @"
    Provides details for the MongoDB source cluster identified by the fid.
"@ "[GraphQL: mongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Database
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMongo -Database" @"
    Provides details for a MongoDB database identified by the fid.
"@ "[GraphQL: mongoDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -Collection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -Collection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -Collection
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMongo -Collection" @"
    Provides details for a MongoDB collection identified by the fid.
"@ "[GraphQL: mongoCollection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -RecoverableRanges
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	source = <System.String>
	# OPTIONAL
	databases = @(
		<System.String>
	)
	# OPTIONAL
	collections = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscQueryMongo -RecoverableRanges" @"
    Provides the point in time range for MongoDB object recovery.
"@ "[GraphQL: mongoRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -BulkRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -BulkRecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -BulkRecoverableRanges
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	source = <System.String>
	# OPTIONAL
	databases = @(
		<System.String>
	)
	# OPTIONAL
	collections = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscQueryMongo -BulkRecoverableRanges" @"
    Provides the bulk recoverable range for MongoDB object recovery, including data and log snapshots.
"@ "[GraphQL: mongoBulkRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbSources).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbSources
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryMongo -DbSources" @"
    Paginated list of MongoDB sources on NoSQL cluster.
"@ "[GraphQL: mongodbSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbDatabases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbDatabases
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryMongo -DbDatabases" @"
    Paginated list of MongoDB databases on NoSQL cluster.
"@ "[GraphQL: mongodbDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbCollections
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbCollections).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbCollections
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryMongo -DbCollections" @"
    Paginated list of MongoDB collections on NoSQL cluster.
"@ "[GraphQL: mongodbCollections]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbSource).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbSource
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMongo -DbSource" @"
    MongoDB source cluster identified by FID on NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster. 
For more info on MongoDB cluster refer to : https://docs.mongodb.com/manual/introduction/
"@ "[GraphQL: mongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbDatabase).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbDatabase
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMongo -DbDatabase" @"
    MongoDB database identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
A database stores one or more collections of documents. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections/
"@ "[GraphQL: mongodbDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbCollection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbCollection).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbCollection
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMongo -DbCollection" @"
    MongoDB collection identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections
"@ "[GraphQL: mongodbCollection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbCollectionRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbCollectionRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbCollectionRecoverableRange
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryRangeRequestData = @{
		# OPTIONAL
		sourceType = <MosaicRecoverableRangeRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicRecoverableRangeRequestSourceType]) for enum values.
		# REQUIRED
		databaseName = <System.String>
		# REQUIRED
		sourceName = <System.String>
		# REQUIRED
		tableName = <System.String>
	}
}
"@
    Write-Message "New-RscQueryMongo -DbCollectionRecoverableRange" @"
    Recoverable Range of a MongoDB collection on NoSQL cluster.
"@ "[GraphQL: mongodbCollectionRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMongo -DbBulkRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMongo -DbBulkRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMongo -DbBulkRecoverableRange
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	recoveryRangeData = @{
		# OPTIONAL
		sourceType = <MosaicBulkRecoverableRangeRequestSourceType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MosaicBulkRecoverableRangeRequestSourceType]) for enum values.
		# REQUIRED
		managementObjects = @{
			# OPTIONAL
			databases = @(
				@{
					# OPTIONAL
					dbName = <System.String>
					# OPTIONAL
					tables = @(
						<System.String>
					)
				}
			)
		}
		# REQUIRED
		sourceName = <System.String>
	}
}
"@
    Write-Message "New-RscQueryMongo -DbBulkRecoverableRange" @"
    Recoverable range for multiple Management Objects on NoSQL cluster.
"@ "[GraphQL: mongodbBulkRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryMssql -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -TopLevelDescendants
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryMssql -TopLevelDescendants" @"
    Paginated list of the highest-level Microsoft SQL Objects accessible by the current user.
"@ "[GraphQL: mssqlTopLevelDescendants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -Databases
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryMssql -Databases" @"
    Paginated list of Microsoft SQL Databases.
"@ "[GraphQL: mssqlDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -AvailabilityGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -AvailabilityGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -AvailabilityGroup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMssql -AvailabilityGroup" @"
    A Microsoft SQL Availability Group.
"@ "[GraphQL: mssqlAvailabilityGroup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -Instance).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -Instance
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMssql -Instance" @"
    A Microsoft SQL Instance.
"@ "[GraphQL: mssqlInstance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -Database
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMssql -Database" @"
    A Microsoft SQL Database.
"@ "[GraphQL: mssqlDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -RecoverableRanges
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryMssql -RecoverableRanges" @"
    List of recoverable ranges for a Microsoft SQL Database.
"@ "[GraphQL: mssqlRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseMissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseMissedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseMissedSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryMssql -DatabaseMissedSnapshots" @"
    List of missed snapshots for a Microsoft SQL Database.
"@ "[GraphQL: mssqlDatabaseMissedSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -CompatibleInstances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -CompatibleInstances).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -CompatibleInstances
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	recoveryTime = <DateTime>
	# REQUIRED
	recoveryType = <V1GetCompatibleMssqlInstancesV1RequestRecoveryType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V1GetCompatibleMssqlInstancesV1RequestRecoveryType]) for enum values.
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryMssql -CompatibleInstances" @"
    Returns all compatible instances for export for the specified recovery time.
"@ "[GraphQL: mssqlCompatibleInstances]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseMissedRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseMissedRecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseMissedRecoverableRanges
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryMssql -DatabaseMissedRecoverableRanges" @"
    List of missed recoverable ranges for a Microsoft SQL Database.
"@ "[GraphQL: mssqlDatabaseMissedRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -AllDatabaseRestoreFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -AllDatabaseRestoreFiles).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -AllDatabaseRestoreFiles
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	lsn = <System.String>
	# OPTIONAL
	recoveryForkGuid = <System.String>
	# OPTIONAL
	time = <DateTime>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryMssql -AllDatabaseRestoreFiles" @"
    Provides a list of database files to be restored for the specified restore or export operation.
"@ "[GraphQL: allMssqlDatabaseRestoreFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseLiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseLiveMounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseLiveMounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <MssqlDatabaseLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <MssqlDatabaseLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
"@
    Write-Message "New-RscQueryMssql -DatabaseLiveMounts" @"
    Paginated list of Microsoft SQL Database live mounts.
"@ "[GraphQL: mssqlDatabaseLiveMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DefaultProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DefaultProperties).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DefaultProperties
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryMssql -DefaultProperties" @"
    The current default properties for Microsoft SQL databases.
"@ "[GraphQL: mssqlDefaultProperties]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -DatabaseRestoreEstimate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -DatabaseRestoreEstimate).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -DatabaseRestoreEstimate
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	lsn = <System.String>
	# OPTIONAL
	recoveryForkGuid = <System.String>
	# OPTIONAL
	time = <DateTime>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryMssql -DatabaseRestoreEstimate" @"
    Returns a size estimate for a restore, export, or mount.
"@ "[GraphQL: mssqlDatabaseRestoreEstimate]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -CdmLogShippingTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -CdmLogShippingTargets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -CdmLogShippingTargets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <MssqlLogShippingTargetSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <MssqlLogShippingTargetFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.MssqlLogShippingTargetFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
"@
    Write-Message "New-RscQueryMssql -CdmLogShippingTargets" @"
    Paginated list of Microsoft SQL log shipping target.
"@ "[GraphQL: cdmMssqlLogShippingTargets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -CdmLogShippingTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -CdmLogShippingTarget).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -CdmLogShippingTarget
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryMssql -CdmLogShippingTarget" @"
    A single Microsoft SQL log shipping target.
"@ "[GraphQL: cdmMssqlLogShippingTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryMssql -LogShippingTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryMssql -LogShippingTargets).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryMssql -LogShippingTargets
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	location = <System.String>
	# OPTIONAL
	offset = <System.Int32>
	# OPTIONAL
	primaryDatabaseId = <System.String>
	# OPTIONAL
	primaryDatabaseName = <System.String>
	# OPTIONAL
	secondaryDatabaseName = <System.String>
	# OPTIONAL
	sortBy = <V2QueryLogShippingConfigurationsV2RequestSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortBy]) for enum values.
	# OPTIONAL
	sortOrder = <V2QueryLogShippingConfigurationsV2RequestSortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestSortOrder]) for enum values.
	# OPTIONAL
	status = <V2QueryLogShippingConfigurationsV2RequestStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.V2QueryLogShippingConfigurationsV2RequestStatus]) for enum values.
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "New-RscQueryMssql -LogShippingTargets" @"
    List of filtered Microsoft SQL log shipping targets.
"@ "[GraphQL: mssqlLogShippingTargets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryNutanix -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -TopLevelDescendants
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryNutanix -TopLevelDescendants" @"
    Paginated list of the highest-level Nutanix Objects accessible by the current user.
"@ "[GraphQL: nutanixTopLevelDescendants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Cluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Cluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryNutanix -Cluster" @"
    A Nutanix Cluster.
"@ "[GraphQL: nutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Clusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Clusters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Clusters
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryNutanix -Clusters" @"
    Paginated list of Nutanix Clusters.
"@ "[GraphQL: nutanixClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -PrismCentrals
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -PrismCentrals).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -PrismCentrals
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryNutanix -PrismCentrals" @"
    Paginated list of Nutanix Prism Central objects.
"@ "[GraphQL: nutanixPrismCentrals]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -PrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -PrismCentral).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -PrismCentral
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryNutanix -PrismCentral" @"
    Details of the given Prism Central.
"@ "[GraphQL: nutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Category
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Category).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Category
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryNutanix -Category" @"
    Details of the given category.
"@ "[GraphQL: nutanixCategory]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -CategoryValue
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -CategoryValue).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -CategoryValue
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryNutanix -CategoryValue" @"
    Details of the given category value.
"@ "[GraphQL: nutanixCategoryValue]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Vm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Vm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Vm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryNutanix -Vm" @"
    A Nutanix Virtual Machine.
"@ "[GraphQL: nutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Vms
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Vms).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Vms
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryNutanix -Vms" @"
    Paginated list of Nutanix Virtual Machines.
"@ "[GraphQL: nutanixVms]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -Mounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -Mounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -Mounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <NutanixLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <NutanixLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.NutanixLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
"@
    Write-Message "New-RscQueryNutanix -Mounts" @"
    Nutanix Live Mount Connection.
"@ "[GraphQL: nutanixMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -ClusterContainers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -ClusterContainers).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -ClusterContainers
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryNutanix -ClusterContainers" @"
    Get list of containers on this cluster

Supported in v5.0+
Query the nutanix cluster to get the list of containers, used for export purposes.
"@ "[GraphQL: nutanixClusterContainers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -ClusterNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -ClusterNetworks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -ClusterNetworks
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryNutanix -ClusterNetworks" @"
    Get list of networks on this cluster

Supported in v8.1+
Retrieves the list of networks by querying the Nutanix cluster. The list of networks is used for restore purposes.
"@ "[GraphQL: nutanixClusterNetworks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -ClusterAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -ClusterAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -ClusterAsyncRequestStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryNutanix -ClusterAsyncRequestStatus" @"
    Get Nutanix cluster async request

Supported in v5.0+
Get details about a Nutanix cluster-related async request.
"@ "[GraphQL: nutanixClusterAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -VmAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -VmAsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -VmAsyncRequestStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryNutanix -VmAsyncRequestStatus" @"
    v5.0-v8.0: Get VM async request details
v8.1+: Get virtual machine async request details

Supported in v5.0+
v5.0-v8.0: Get details about a Nutanix VM-related async request.
v8.1+: Get details about a Nutanix virtual machine-related async request.
"@ "[GraphQL: nutanixVmAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -SearchVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -SearchVm).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -SearchVm
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cursor = <System.String>
	# OPTIONAL
	limit = <System.Int32>
	# REQUIRED
	id = <System.String>
	# REQUIRED
	path = <System.String>
}
"@
    Write-Message "New-RscQueryNutanix -SearchVm" @"
    v5.0-v8.0: Search for file in Nutanix VM
v8.1+: Search for file in Nutanix virtual machine

Supported in v5.0+
Search for a file within the Nutanix Virtual Machine. Search via full path prefix or filename prefix.
"@ "[GraphQL: searchNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -VmMissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -VmMissedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -VmMissedSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryNutanix -VmMissedSnapshots" @"
    v5.0-v8.0: Get details about missed snapshots for a VM
v8.1+: Get details about missed snapshots for a virtual machine

Supported in v5.0+
v5.0-v8.0: Retrieve the time of the day when the snapshots were missed specific to a vm.
v8.1+: Retrieve the time of the day when the snapshots were missed specific to a virtual machine.
"@ "[GraphQL: nutanixVmMissedSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -BrowseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -BrowseSnapshot).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -BrowseSnapshot
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	offset = <System.Int32>
	# REQUIRED
	id = <System.String>
	# REQUIRED
	path = <System.String>
}
"@
    Write-Message "New-RscQueryNutanix -BrowseSnapshot" @"
    v5.0-v8.0: Lists all files in VM snapshot
v8.1+: Lists all files in virtual machine snapshot

Supported in v5.0+
Lists all files and directories in a given path.
"@ "[GraphQL: nutanixBrowseSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryNutanix -SnapshotDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryNutanix -SnapshotDetail).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryNutanix -SnapshotDetail
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryNutanix -SnapshotDetail" @"
    Supported in v5.0+. Get Nutanix virtual machine snapshot details.
 Retrieve detailed information about a snapshot.
"@ "[GraphQL: nutanixSnapshotDetail]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryO365 -Org
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Org).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Org
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryO365 -Org" @"
    Details of the O365Org.
"@ "[GraphQL: o365Org]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -OrgAtSnappableLevel
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -OrgAtSnappableLevel).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -OrgAtSnappableLevel
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
# REQUIRED
$inputs.Var.snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
"@
    Write-Message "New-RscQueryO365 -OrgAtSnappableLevel" @"
    Details of the O365Org at snappable level, given the snappable type.
"@ "[GraphQL: o365OrgAtSnappableLevel]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -AllAdGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -AllAdGroups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -AllAdGroups
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.adGroupSearchFilter = <System.String>
"@
    Write-Message "New-RscQueryO365 -AllAdGroups" @"
    All AD Groups belonging to the O365 organization.
"@ "[GraphQL: allO365AdGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -User
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -User).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -User
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryO365 -User" @"
    Details for the O365 user corresponding to the ID.
"@ "[GraphQL: o365User]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Mailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Mailbox).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Mailbox
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -Mailbox" @"
    Details for the Exchange mailbox corresponding to the snappable ID.
"@ "[GraphQL: o365Mailbox]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Groups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Groups).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Groups
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
# REQUIRED
$inputs.Var.snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
"@
    Write-Message "New-RscQueryO365 -Groups" @"
    List of O365 Groups in the O365Org.
"@ "[GraphQL: o365Groups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Mailboxes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Mailboxes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Mailboxes
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
"@
    Write-Message "New-RscQueryO365 -Mailboxes" @"
    List of Mailboxes in the O365Org.
"@ "[GraphQL: o365Mailboxes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Onedrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Onedrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Onedrive
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -Onedrive" @"
    Details for the OneDrive corresponding to the snappable ID.
"@ "[GraphQL: o365Onedrive]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Onedrives
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Onedrives).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Onedrives
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
"@
    Write-Message "New-RscQueryO365 -Onedrives" @"
    List of Onedrives in the O365Org.
"@ "[GraphQL: o365Onedrives]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Site
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Site).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Site
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -Site" @"
    Details for the SharePoint site corresponding to the snappable ID.
"@ "[GraphQL: o365Site]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Sites
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Sites).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Sites
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
# OPTIONAL
$inputs.Var.excludeChildSites = <System.Boolean>
"@
    Write-Message "New-RscQueryO365 -Sites" @"
    List of sites in the O365Org.
"@ "[GraphQL: o365Sites]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointDrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointDrive).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointDrive
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -SharepointDrive" @"
    Details for the SharePoint drive corresponding to the snappable ID.
"@ "[GraphQL: o365SharepointDrive]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointDrives
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointDrives).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointDrives
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
"@
    Write-Message "New-RscQueryO365 -SharepointDrives" @"
    List of sharepoint drives (document libraries) in the O365Org.
"@ "[GraphQL: o365SharepointDrives]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -SharepointList" @"
    Details for the SharePoint list corresponding to the snappable ID.
"@ "[GraphQL: o365SharepointList]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointLists
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointLists).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointLists
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
"@
    Write-Message "New-RscQueryO365 -SharepointLists" @"
    Paginated list of sharepoint lists in the O365Org.
"@ "[GraphQL: o365SharepointLists]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointSite
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointSite).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointSite
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.siteFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -SharepointSite" @"
    Details for the SharePoint site corresponding to the site ID.
"@ "[GraphQL: o365SharepointSite]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointSites
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointSites).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointSites
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
"@
    Write-Message "New-RscQueryO365 -SharepointSites" @"
    Paginated list of sharepoint sites in the O365Org.
"@ "[GraphQL: o365SharepointSites]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Team
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Team).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Team
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -Team" @"
    Details for the team corresponding to the snappable ID.
"@ "[GraphQL: o365Team]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Teams
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Teams).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Teams
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
"@
    Write-Message "New-RscQueryO365 -Teams" @"
    List of O365 Teams in the O365Org.
"@ "[GraphQL: o365Teams]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -TeamChannels
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -TeamChannels).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -TeamChannels
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.excludeArchived = <System.Boolean>
# REQUIRED
$inputs.Var.channelMembershipTypeFilter = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
# OPTIONAL
$inputs.Var.nameFilter = <System.String>
"@
    Write-Message "New-RscQueryO365 -TeamChannels" @"
    List of Channels for the O365Team.
"@ "[GraphQL: o365TeamChannels]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -TeamConversationsFolderID
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -TeamConversationsFolderID).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -TeamConversationsFolderID
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.snapshotFid = <System.String>
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
"@
    Write-Message "New-RscQueryO365 -TeamConversationsFolderID" @"
    ID for the conversations folder in the Team's Group Mailbox.
"@ "[GraphQL: o365TeamConversationsFolderID]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -TeamPostedBy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -TeamPostedBy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -TeamPostedBy
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
# OPTIONAL
$inputs.Var.nameFilter = <System.String>
"@
    Write-Message "New-RscQueryO365 -TeamPostedBy" @"
    Users who have posted in a team.
"@ "[GraphQL: o365TeamPostedBy]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Calendar
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Calendar).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Calendar
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -Calendar" @"
    Details of the Exchange calendar pertaining to the snappable ID.
"@ "[GraphQL: o365Calendar]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -Orgs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -Orgs).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -Orgs
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$inputs.Var.workloadHierarchy = <WorkloadLevelHierarchy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
"@
    Write-Message "New-RscQueryO365 -Orgs" @"
    All O365 orgs for the account.
"@ "[GraphQL: o365Orgs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointObjectList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointObjectList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointObjectList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$inputs.Var.objectTypeFilter = @(
	<System.String>
)
# REQUIRED
$inputs.Var.includeEntireHierarchy = <System.Boolean>
# REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryO365 -SharepointObjectList" @"
    Returns the sharepoint objects after filtering on the object types and includeEntireHierarchy.
"@ "[GraphQL: o365SharepointObjectList]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -SharepointObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -SharepointObjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -SharepointObjects
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryO365 -SharepointObjects" @"
    
"@ "[GraphQL: o365SharepointObjects]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -UserObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -UserObjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -UserObjects
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryO365 -UserObjects" @"
    Name, id, object type, and mail address of user descendant object.
"@ "[GraphQL: o365UserObjects]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -OrgSummaries
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -OrgSummaries).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -OrgSummaries
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryO365 -OrgSummaries" @"
    
"@ "[GraphQL: o365OrgSummaries]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -ObjectAncestors
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -ObjectAncestors).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -ObjectAncestors
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "New-RscQueryO365 -ObjectAncestors" @"
    
"@ "[GraphQL: o365ObjectAncestors]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -BrowseTeamConvChannels
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -BrowseTeamConvChannels).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -BrowseTeamConvChannels
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.snapshotFidOpt = <System.String>
# REQUIRED
$inputs.Var.excludeArchived = <System.Boolean>
# REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.channelMembershipTypeFilter = <ChannelMembershipType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ChannelMembershipType]) for enum values.
# OPTIONAL
$inputs.Var.nameFilter = <System.String>
"@
    Write-Message "New-RscQueryO365 -BrowseTeamConvChannels" @"
    Browse channels in a Teams conversations snapshot.
"@ "[GraphQL: browseO365TeamConvChannels]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -ServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -ServiceAccount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -ServiceAccount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "New-RscQueryO365 -ServiceAccount" @"
    Gets the service account for the given org.
"@ "[GraphQL: o365ServiceAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -AllOrgStatuses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -AllOrgStatuses).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -AllOrgStatuses
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryO365 -AllOrgStatuses" @"
    Gets the status of each org in the account.
"@ "[GraphQL: allO365OrgStatuses]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -License
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -License).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -License
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryO365 -License" @"
    Retrieve o365 licence details.
"@ "[GraphQL: o365License]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -ListApps
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -ListApps).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -ListApps
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# REQUIRED
$inputs.Var.o365AppFilters = @(
	@{
		# OPTIONAL
		field = <AppFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AppFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.o365AppSortByParam = @{
	# OPTIONAL
	field = <AppSortByParamField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AppSortByParamField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
"@
    Write-Message "New-RscQueryO365 -ListApps" @"
    Lists the O365 apps.
"@ "[GraphQL: listO365Apps]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -AllSubscriptionsAppTypeCounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -AllSubscriptionsAppTypeCounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -AllSubscriptionsAppTypeCounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "New-RscQueryO365 -AllSubscriptionsAppTypeCounts" @"
    Returns the total number of apps of each type, for each O365 org.
"@ "[GraphQL: allO365SubscriptionsAppTypeCounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -StorageStats
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -StorageStats).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -StorageStats
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.orgID = <System.String>
"@
    Write-Message "New-RscQueryO365 -StorageStats" @"
    Returns the storage stats of an O365 org.
"@ "[GraphQL: o365StorageStats]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryO365 -ServiceStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryO365 -ServiceStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryO365 -ServiceStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.orgID = <System.String>
"@
    Write-Message "New-RscQueryO365 -ServiceStatus" @"
    Returns the service status of the O365 service running on MSFT server.
"@ "[GraphQL: o365ServiceStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryOracle -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -TopLevelDescendants).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -TopLevelDescendants
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryOracle -TopLevelDescendants" @"
    Paginated list of the highest-level Oracle Objects accessible by the current user.
"@ "[GraphQL: oracleTopLevelDescendants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -Databases).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -Databases
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryOracle -Databases" @"
    Paginated list of Oracle Databases.
"@ "[GraphQL: oracleDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -Host
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -Host).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -Host
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryOracle -Host" @"
    An Oracle Host.
"@ "[GraphQL: oracleHost]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -Rac
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -Rac).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -Rac
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryOracle -Rac" @"
    An Oracle Real Application Cluster.
"@ "[GraphQL: oracleRac]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -DataGuardGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -DataGuardGroup).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -DataGuardGroup
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryOracle -DataGuardGroup" @"
    An Oracle Data Guard Group.
"@ "[GraphQL: oracleDataGuardGroup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -Database).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -Database
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryOracle -Database" @"
    An Oracle Database.
"@ "[GraphQL: oracleDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -LiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -LiveMounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -LiveMounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filters = @(
	@{
		# OPTIONAL
		field = <OracleLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <OracleLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.OracleLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
"@
    Write-Message "New-RscQueryOracle -LiveMounts" @"
    Paginated list of Oracle Live Mounts.
"@ "[GraphQL: oracleLiveMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -AcoParameters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -AcoParameters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -AcoParameters
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbId = <System.String>
}
"@
    Write-Message "New-RscQueryOracle -AcoParameters" @"
    List of supported Advanced Cloning Options

Supported in v6.0+
Get the list of supported Advanced Cloning Options (ACO) parameters.
"@ "[GraphQL: oracleAcoParameters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -RecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -RecoverableRanges
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# OPTIONAL
	shouldIncludeDbSnapshotSummaries = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryOracle -RecoverableRanges" @"
    Get recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve the recoverable ranges for a specified Oracle database. A begin and/or end timestamp can be provided to retrieve only the ranges that fall within the window.
"@ "[GraphQL: oracleRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -MissedRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -MissedRecoverableRanges).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -MissedRecoverableRanges
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryOracle -MissedRecoverableRanges" @"
    Get missed recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve a list of missed recoverable ranges for a Oracle database. For each run of one type of error, the first and last occurrence of the error are given.
"@ "[GraphQL: oracleMissedRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -MissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -MissedSnapshots).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -MissedSnapshots
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryOracle -MissedSnapshots" @"
    Get missed snapshots for an Oracle database

Supported in v5.0+
Retrieve summary information about the missed snapshots of an Oracle database.
"@ "[GraphQL: oracleMissedSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -AcoExampleDownloadLink
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -AcoExampleDownloadLink).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -AcoExampleDownloadLink
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbId = <System.String>
}
"@
    Write-Message "New-RscQueryOracle -AcoExampleDownloadLink" @"
    Link to download the Advanced Recovery Options example file

Supported in v5.3+
Link to download the Advanced Recovery Options example file which can be used to customize Oracle recoveries.
"@ "[GraphQL: oracleAcoExampleDownloadLink]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -PdbDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -PdbDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -PdbDetails
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	pdbDetailsRequest = @{
		# REQUIRED
		recoveryPoint = @{
			# OPTIONAL
			snapshotId = <System.String>
			# OPTIONAL
			timestampMs = <System.Int64>
		}
	}
}
"@
    Write-Message "New-RscQueryOracle -PdbDetails" @"
    Get PDB details

Supported in v8.0+
Retrieves information about available pluggable databases (PDBs) for a given recovery point.
"@ "[GraphQL: oraclePdbDetails]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -HostLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -HostLogBackupConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -HostLogBackupConfig
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryOracle -HostLogBackupConfig" @"
    Oracle Log backup configuration for Oracle Host.
"@ "[GraphQL: oracleHostLogBackupConfig]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -DatabaseLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -DatabaseLogBackupConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -DatabaseLogBackupConfig
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryOracle -DatabaseLogBackupConfig" @"
    Oracle log backup configuration for an Oracle Database.
"@ "[GraphQL: oracleDatabaseLogBackupConfig]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryOracle -RacLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryOracle -RacLogBackupConfig).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryOracle -RacLogBackupConfig
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryOracle -RacLogBackupConfig" @"
    Oracle log backup configuration for an Oracle RAC.
"@ "[GraphQL: oracleRacLogBackupConfig]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQuerySla -Domains
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -Domains).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -Domains
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <SlaQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <GlobalSlaQueryFilterInputField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = <System.String>
		# OPTIONAL
		objectTypeList = @(
			<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$inputs.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = <System.String>
		# REQUIRED
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowProtectedObjectCount = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.showRemoteSlas = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>
"@
    Write-Message "New-RscQuerySla -Domains" @"
    Retrieves a list of SLA Domains.
"@ "[GraphQL: slaDomains]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -GlobalFilterList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -GlobalFilterList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -GlobalFilterList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <SlaQuerySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <GlobalSlaQueryFilterInputField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = <System.String>
		# OPTIONAL
		objectTypeList = @(
			<SlaObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.contextFilter = <ContextFilterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$inputs.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = <System.String>
		# REQUIRED
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowProtectedObjectCount = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.showRemoteSlas = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>
"@
    Write-Message "New-RscQuerySla -GlobalFilterList" @"
    Retrieves a list of SLA Domains.
"@ "[GraphQL: globalSlaFilterConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -Domain
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -Domain).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -Domain
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.id = <System.String>
# OPTIONAL
$inputs.Var.shouldShowSyncStatus = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowUpgradeInfo = <System.Boolean>
# OPTIONAL
$inputs.Var.shouldShowPausedClusters = <System.Boolean>
"@
    Write-Message "New-RscQuerySla -Domain" @"
    Query that retrieves an SLA Domain.
"@ "[GraphQL: slaDomain]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -CountOfObjectsProtected
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -CountOfObjectsProtected).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -CountOfObjectsProtected
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.rootOptionalFid = <System.String>
# REQUIRED
$inputs.Var.slaIds = @(
	<System.String>
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
"@
    Write-Message "New-RscQuerySla -CountOfObjectsProtected" @"
    The number of objects protected by the SLA Domains.
"@ "[GraphQL: countOfObjectsProtectedBySlas]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -AuditDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -AuditDetail).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -AuditDetail
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# REQUIRED
$inputs.Var.SlaId = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <SLAAuditDetailFilterFieldEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SLAAuditDetailFilterFieldEnum]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# OPTIONAL
$inputs.Var.timezone = <System.String>
"@
    Write-Message "New-RscQuerySla -AuditDetail" @"
    List of audit details for a given SLA Domain.
"@ "[GraphQL: slaAuditDetail]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -AllSummariesByIds
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -AllSummariesByIds).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -AllSummariesByIds
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.slaIds = @(
	<System.String>
)
"@
    Write-Message "New-RscQuerySla -AllSummariesByIds" @"
    List of SLA Domain summaries for the given IDs.
"@ "[GraphQL: allSlaSummariesByIds]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -GlobalStatuses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -GlobalStatuses).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -GlobalStatuses
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.last = <System.Int32>
# OPTIONAL
$inputs.Var.before = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <SlaStatusFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaStatusFilterField]) for enum values.
		# OPTIONAL
		text = <System.String>
}
)
# REQUIRED
$inputs.Var.SlaId = <System.String>
"@
    Write-Message "New-RscQuerySla -GlobalStatuses" @"
    Status on the clusters where global SLA is synced.
"@ "[GraphQL: globalSlaStatuses]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -ConflictObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -ConflictObjects).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -ConflictObjects
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fids = @(
	<System.String>
)
"@
    Write-Message "New-RscQuerySla -ConflictObjects" @"
    Conflicting objects for an SLA Domain assignment.
"@ "[GraphQL: slaConflictObjects]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -ManagedVolumes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -ManagedVolumes).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -ManagedVolumes
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQuerySla -ManagedVolumes" @"
    Paginated list of SLA Managed Volumes.
"@ "[GraphQL: slaManagedVolumes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -ManagedVolume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -ManagedVolume).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -ManagedVolume
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQuerySla -ManagedVolume" @"
    Details of a SLA Managed Volume object.
"@ "[GraphQL: slaManagedVolume]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQuerySla -AllNcdComplianceData
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQuerySla -AllNcdComplianceData).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQuerySla -AllNcdComplianceData
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusters = @(
	<System.String>
)
"@
    Write-Message "New-RscQuerySla -AllNcdComplianceData" @"
    NAS Cloud Direct SLA Domain compliance data for the requested clusters.
"@ "[GraphQL: allNcdSlaComplianceData]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryVcenter -Vcenter
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -Vcenter).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -Vcenter
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVcenter -Vcenter" @"
    
"@ "[GraphQL: vSphereVCenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -List).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -List
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVcenter -List" @"
    
"@ "[GraphQL: vSphereVCenterConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -PreAddInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -PreAddInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -PreAddInfo
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	vcenterConfig = @{
		# OPTIONAL
		connectionConfig = @{
			# OPTIONAL
			caCerts = <System.String>
			# REQUIRED
			hostname = <System.String>
			# REQUIRED
			password = <System.String>
			# REQUIRED
			username = <System.String>
		}
		# OPTIONAL
		id = <System.String>
	}
}
"@
    Write-Message "New-RscQueryVcenter -PreAddInfo" @"
    Get preAddInfo for a vcenter.
"@ "[GraphQL: vCenterPreAddInfo]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -Networks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -Networks).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -Networks
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryVcenter -Networks" @"
    Get the user-configured networks in the vCenter

Supported in v5.3+
Get the names and IDs of the user configured networks in the vCenter. This information enables users to choose a desired network for backups to go through for VMware Cloud on AWS setups.
"@ "[GraphQL: vCenterNetworks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -HotAddNetwork
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -HotAddNetwork).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -HotAddNetwork
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryVcenter -HotAddNetwork" @"
    Retrieve the user-configured network for HotAdd operations

Supported in v5.3+
Retrieve the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
"@ "[GraphQL: vCenterHotAddNetwork]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -NumProxiesNeeded
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -NumProxiesNeeded).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -NumProxiesNeeded
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryVcenter -NumProxiesNeeded" @"
    Get the number of HotAdd proxies needed for the vCenter

Supported in v5.3+
Get the number of HotAdd proxies that need to be deployed to the vCenter to support the maximum number of ingest jobs.
"@ "[GraphQL: vCenterNumProxiesNeeded]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -HotAddProxy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -HotAddProxy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -HotAddProxy
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuids = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryVcenter -HotAddProxy" @"
    Get a list of HotAdd proxy virtual machines

Supported in v5.3+
Retrieve summary information for all HotAdd proxy virtual machines.
"@ "[GraphQL: allVcenterHotAddProxyVms]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -HotAddBandwidth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -HotAddBandwidth).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -HotAddBandwidth
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryVcenter -HotAddBandwidth" @"
    Get the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Get the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
"@ "[GraphQL: vCenterHotAddBandwidth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVcenter -AdvancedTagPreview
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVcenter -AdvancedTagPreview).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVcenter -AdvancedTagPreview
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	limit = <System.Int32>
	# OPTIONAL
	offset = <System.Int32>
	# REQUIRED
	filterCondition = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryVcenter -AdvancedTagPreview" @"
    Preview list of virtual machines of a proposed filter condition

Supported in v7.0+
Preview list of virtual machines of a proposed filter condition. The result might not be accurate if new virtual machines were added after last vCenter refresh.
"@ "[GraphQL: vCenterAdvancedTagPreview]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryVsphere -Datacenter
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Datacenter).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Datacenter
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -Datacenter" @"
    
"@ "[GraphQL: vSphereDatacenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -ComputeCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -ComputeCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -ComputeCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -ComputeCluster" @"
    
"@ "[GraphQL: vSphereComputeCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -ResourcePool
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -ResourcePool).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -ResourcePool
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -ResourcePool" @"
    
"@ "[GraphQL: vSphereResourcePool]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Folder
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Folder).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Folder
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -Folder" @"
    
"@ "[GraphQL: vSphereFolder]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Host
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Host).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Host
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -Host" @"
    
"@ "[GraphQL: vSphereHost]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -DatastoreCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -DatastoreCluster).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -DatastoreCluster
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -DatastoreCluster" @"
    Vsphere datastore cluster based on id passed in.
"@ "[GraphQL: vSphereDatastoreCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Datastore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Datastore).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Datastore
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -Datastore" @"
    Vsphere datastore based on id passed in.
"@ "[GraphQL: vSphereDatastore]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -HostsByFids
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -HostsByFids).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -HostsByFids
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fids = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryVsphere -HostsByFids" @"
    All of the VSphere hosts based on fids passed in.
"@ "[GraphQL: vSphereHostsByFids]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Tag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Tag).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Tag
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -Tag" @"
    
"@ "[GraphQL: vSphereTag]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -TagCategory
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -TagCategory).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -TagCategory
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -TagCategory" @"
    
"@ "[GraphQL: vSphereTagCategory]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Network
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Network).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Network
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -Network" @"
    
"@ "[GraphQL: vSphereNetwork]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -TopLevelDescendantsList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -TopLevelDescendantsList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -TopLevelDescendantsList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.typeFilter = @(
	<HierarchyObjectTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVsphere -TopLevelDescendantsList" @"
    
"@ "[GraphQL: vSphereTopLevelDescendantsConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -RootRecoveryHierarchy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -RootRecoveryHierarchy).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -RootRecoveryHierarchy
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVsphere -RootRecoveryHierarchy" @"
    The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts.
"@ "[GraphQL: vSphereRootRecoveryHierarchy]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -HostList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -HostList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -HostList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVsphere -HostList" @"
    
"@ "[GraphQL: vSphereHostConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Folders
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Folders).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Folders
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVsphere -Folders" @"
    Get all the vSphere folders.
"@ "[GraphQL: vSphereFolders]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -ComputeClusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -ComputeClusters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -ComputeClusters
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVsphere -ComputeClusters" @"
    Query compute clusters
"@ "[GraphQL: vSphereComputeClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -DatastoreList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -DatastoreList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -DatastoreList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVsphere -DatastoreList" @"
    
"@ "[GraphQL: vSphereDatastoreConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -DatastoreClusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -DatastoreClusters).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -DatastoreClusters
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVsphere -DatastoreClusters" @"
    Query vSphere datastore clusters.
"@ "[GraphQL: vSphereDatastoreClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -LiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -LiveMounts).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -LiveMounts
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <VsphereLiveMountFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereLiveMountFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
}
)
# OPTIONAL
$inputs.Var.sortBy = @{
	# OPTIONAL
	field = <VsphereLiveMountSortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereLiveMountSortByField]) for enum values.
	# OPTIONAL
	sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
"@
    Write-Message "New-RscQueryVsphere -LiveMounts" @"
    List of vSphere Live Mounts.
"@ "[GraphQL: vSphereLiveMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -MountList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -MountList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -MountList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.filter = @{
	# OPTIONAL
	name = <System.String>
	# OPTIONAL
	clusterUuid = @(
		<System.String>
	)
	# OPTIONAL
	powerStatus = @(
		<System.Boolean>
	)
	# OPTIONAL
	sourceVmId = <System.String>
}
# OPTIONAL
$inputs.Var.sortBy = <VsphereMountSortBy> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.VsphereMountSortBy]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
"@
    Write-Message "New-RscQueryVsphere -MountList" @"
    vSphere Live Mount Connection
"@ "[GraphQL: vSphereMountConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -Mount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -Mount).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -Mount
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphere -Mount" @"
    Get a vSphere Live Mount by id
"@ "[GraphQL: vSphereMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -HostDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -HostDetails).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -HostDetails
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "New-RscQueryVsphere -HostDetails" @"
    Get details of a ESXi hypervisor

Supported in v5.0+
Get details of a ESXi hypervisor.
"@ "[GraphQL: vSphereHostDetails]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphere -VmwareCdpLiveInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphere -VmwareCdpLiveInfo).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphere -VmwareCdpLiveInfo
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.ids = @(
	<System.String>
)
"@
    Write-Message "New-RscQueryVsphere -VmwareCdpLiveInfo" @"
    
"@ "[GraphQL: vsphereVmwareCdpLiveInfo]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# New-RscQueryVsphereVm -New
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -New).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -New
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "New-RscQueryVsphereVm -New" @"
    
"@ "[GraphQL: vSphereVmNew]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -NewList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -NewList).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -NewList
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.first = <System.Int32>
# OPTIONAL
$inputs.Var.after = <System.String>
# OPTIONAL
$inputs.Var.sortBy = <HierarchySortByField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$inputs.Var.sortOrder = <SortOrder> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$inputs.Var.filter = @(
	@{
		# OPTIONAL
		field = <HierarchyFilterField> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			<System.String>
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = <TagFilterType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = <System.String>
				# OPTIONAL
				tagValue = <System.String>
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			<ManagedObjectType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			<AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = <System.Boolean>
		# OPTIONAL
		isSlowSearchEnabled = <System.Boolean>
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			<AzureNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			<UnmanagedObjectAvailabilityFilter> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
"@
    Write-Message "New-RscQueryVsphereVm -NewList" @"
    
"@ "[GraphQL: vSphereVmNewConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -AsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -AsyncRequestStatus).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -AsyncRequestStatus
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.id = <System.String>
"@
    Write-Message "New-RscQueryVsphereVm -AsyncRequestStatus" @"
    
"@ "[GraphQL: vSphereVMAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -RecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -RecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -RecoverableRange
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.beforeTime = <DateTime>
# OPTIONAL
$inputs.Var.afterTime = <DateTime>
"@
    Write-Message "New-RscQueryVsphereVm -RecoverableRange" @"
    
"@ "[GraphQL: vsphereVMRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -RecoverableRangeInBatch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -RecoverableRangeInBatch).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -RecoverableRangeInBatch
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.requestInfo = @{
	# OPTIONAL
	afterTime = <DateTime>
	# OPTIONAL
	beforeTime = <DateTime>
	# REQUIRED
	vmIds = @(
		<System.String>
	)
}
"@
    Write-Message "New-RscQueryVsphereVm -RecoverableRangeInBatch" @"
    
"@ "[GraphQL: vsphereVMRecoverableRangeInBatch]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# New-RscQueryVsphereVm -MissedRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (New-RscQueryVsphereVm -MissedRecoverableRange).GqlRequest().SaveQueryToFile()
} else {
    $query = New-RscQueryVsphereVm -MissedRecoverableRange
    $fieldTypeName = $query.Field.GetType().Name
    $argNames = $query.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.beforeTime = <DateTime>
# OPTIONAL
$inputs.Var.afterTime = <DateTime>
"@
    Write-Message "New-RscQueryVsphereVm -MissedRecoverableRange" @"
    
"@ "[GraphQL: vsphereVMMissedRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

