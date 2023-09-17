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
# Invoke-RscMutateActivitySeries -Cancel
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateActivitySeries -Cancel -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateActivitySeries -Cancel -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	activitySeriesId = <System.String>
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscMutateActivitySeries -Cancel" @"
    Cancel an activity series.
"@ "[GraphQL: cancelActivitySeries]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateAws -StartNativeEc2InstanceSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -StartNativeEc2InstanceSnapshotsJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -StartNativeEc2InstanceSnapshotsJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -StartNativeEc2InstanceSnapshotsJob" @"
    Start an on demand create snapshot job for AWS EC2 Instances.When completed, this will start taking an on-demand snapshot of the selected EC2 Instances  as per the SLA Policy assigned to the respective instances.
"@ "[GraphQL: startAwsNativeEc2InstanceSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -StartRestoreNativeEc2InstanceSnapshotJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -StartRestoreNativeEc2InstanceSnapshotJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -StartRestoreNativeEc2InstanceSnapshotJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -StartRestoreNativeEc2InstanceSnapshotJob" @"
    Start an on demand restore snapshot job for AWS EC2 Instance. When completed, this will replace the original EC2 Instance with the selected snapshot.
"@ "[GraphQL: startRestoreAwsNativeEc2InstanceSnapshotJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -StartRefreshNativeAccountsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -StartRefreshNativeAccountsJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -StartRefreshNativeAccountsJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -StartRefreshNativeAccountsJob" @"
    Start an on demand job to refresh AWS accounts. The job updates the Rubrik platform with changes to the AWS Native accounts.
"@ "[GraphQL: startRefreshAwsNativeAccountsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -StartCreateNativeEbsVolumeSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -StartCreateNativeEbsVolumeSnapshotsJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -StartCreateNativeEbsVolumeSnapshotsJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -StartCreateNativeEbsVolumeSnapshotsJob" @"
    Start job to create snapshots of EBS Volumes with given IDs. When completed, this will start taking an on-demand snapshot of the selected EBS Volumes  as per the SLA Policy assigned to the respective volumes.
"@ "[GraphQL: startCreateAwsNativeEbsVolumeSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -StartNativeAccountDisableJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -StartNativeAccountDisableJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -StartNativeAccountDisableJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -StartNativeAccountDisableJob" @"
    Starts a job to disable a specific AWS Native account. When complete, the job will disable protection for the specified AWS Native account.
"@ "[GraphQL: startAwsNativeAccountDisableJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -StartExportNativeEbsVolumeSnapshotJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -StartExportNativeEbsVolumeSnapshotJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -StartExportNativeEbsVolumeSnapshotJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -StartExportNativeEbsVolumeSnapshotJob" @"
    Start a job to export EBS Volume. The job creates a new EBS Volume with the same properties as that of the snapshot that is exported.
"@ "[GraphQL: startExportAwsNativeEbsVolumeSnapshotJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -ExcludeNativeEbsVolumesFromSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -ExcludeNativeEbsVolumesFromSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -ExcludeNativeEbsVolumesFromSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -ExcludeNativeEbsVolumesFromSnapshot" @"
    Mark AWS Native EBS Volumes to be excluded from EC2 Instance snapshot. By default, all EBS Volumes are marked as included.
"@ "[GraphQL: excludeAwsNativeEbsVolumesFromSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -StartNativeRdsInstanceSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -StartNativeRdsInstanceSnapshotsJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -StartNativeRdsInstanceSnapshotsJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -StartNativeRdsInstanceSnapshotsJob" @"
    Start job to create snapshots of RDS Instance with given IDs. When completed, this will start taking an on-demand snapshot of the selected RDS Instances  as per the SLA Policy assigned to the respective instances.
"@ "[GraphQL: startAwsNativeRdsInstanceSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -CreateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -CreateAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -CreateAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -CreateAccount" @"
    
"@ "[GraphQL: createAwsAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpdateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpdateAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpdateAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpdateAccount" @"
    
"@ "[GraphQL: updateAwsAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -CreateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -CreateAutomaticTargetMapping -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -CreateAutomaticTargetMapping -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -CreateAutomaticTargetMapping" @"
    
"@ "[GraphQL: createAutomaticAwsTargetMapping]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -CreateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -CreateCloudNativeStorageSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -CreateCloudNativeStorageSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -CreateCloudNativeStorageSetting" @"
    
"@ "[GraphQL: createCloudNativeAwsStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpdateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpdateAutomaticTargetMapping -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpdateAutomaticTargetMapping -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpdateAutomaticTargetMapping" @"
    
"@ "[GraphQL: updateAutomaticAwsTargetMapping]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpdateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpdateCloudNativeStorageSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpdateCloudNativeStorageSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpdateCloudNativeStorageSetting" @"
    
"@ "[GraphQL: updateCloudNativeAwsStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -CreateTarget -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -CreateTarget -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -CreateTarget" @"
    
"@ "[GraphQL: createAwsTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpdateTarget -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpdateTarget -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpdateTarget" @"
    
"@ "[GraphQL: updateAwsTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -CreateReaderTarget -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -CreateReaderTarget -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -CreateReaderTarget" @"
    Create a reader type for AWS archival location on a Rubrik cluster.
"@ "[GraphQL: createAwsReaderTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -CreateComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -CreateComputeSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -CreateComputeSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -CreateComputeSetting" @"
    
"@ "[GraphQL: createAwsComputeSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpdateComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpdateComputeSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpdateComputeSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpdateComputeSetting" @"
    
"@ "[GraphQL: updateAwsComputeSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -DeleteComputeSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -DeleteComputeSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -DeleteComputeSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateAws -DeleteComputeSetting" @"
    
"@ "[GraphQL: deleteAwsComputeSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -ValidateAndCreateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -ValidateAndCreateCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -ValidateAndCreateCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -ValidateAndCreateCloudAccount" @"
    Validate and create AWS cloud account. If validation fails, no error is returned and the cause is present in the ""message"" field of return object or within admin/child accounts of return object. In case validation succeeds, it initiates creation of AWS cloud account. This is the first step to set up native protection.
"@ "[GraphQL: validateAndCreateAwsCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -FinalizeCloudAccountProtection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -FinalizeCloudAccountProtection -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -FinalizeCloudAccountProtection -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -FinalizeCloudAccountProtection" @"
    Process cloud account. This is the second step after validate and create in addition of a feature for cloud account.The CloudFormation stack should be created after this step using the CloudFormation URL provided in the first step.
"@ "[GraphQL: finalizeAwsCloudAccountProtection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -PrepareCloudAccountDeletion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -PrepareCloudAccountDeletion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -PrepareCloudAccountDeletion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
}
"@
    Write-Message "Invoke-RscMutateAws -PrepareCloudAccountDeletion" @"
    Prepare deletion of cloud account. This is the first step to delete AWS cloud account. It generated template for deletion of cloud account and does not change any state of account.
"@ "[GraphQL: prepareAwsCloudAccountDeletion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -FinalizeCloudAccountDeletion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -FinalizeCloudAccountDeletion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -FinalizeCloudAccountDeletion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# REQUIRED
	feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
}
"@
    Write-Message "Invoke-RscMutateAws -FinalizeCloudAccountDeletion" @"
    Process and finalize deletion of cloud account is the last step in deletion of a feature from cloud account. This endpoint is a MUST for deletion of disconnected features.
"@ "[GraphQL: finalizeAwsCloudAccountDeletion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpdateCloudAccountFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpdateCloudAccountFeature -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpdateCloudAccountFeature -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpdateCloudAccountFeature" @"
    Updates regions, stack ARN, and role ARN for a feature for a given cloud account.
"@ "[GraphQL: updateAwsCloudAccountFeature]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpdateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpdateCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpdateCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
	# OPTIONAL
	awsAccountName = <System.String>
}
"@
    Write-Message "Invoke-RscMutateAws -UpdateCloudAccount" @"
    Update properties for a given AWS cloud account.
"@ "[GraphQL: updateAwsCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -PrepareFeatureUpdateForCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -PrepareFeatureUpdateForCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -PrepareFeatureUpdateForCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -PrepareFeatureUpdateForCloudAccount" @"
    Prepare manual update features to latest version.
"@ "[GraphQL: prepareFeatureUpdateForAwsCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -CreateExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -CreateExocomputeConfigs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -CreateExocomputeConfigs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -CreateExocomputeConfigs" @"
    Create AWS Exocompute configs.
"@ "[GraphQL: createAwsExocomputeConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -DeleteExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -DeleteExocomputeConfigs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -DeleteExocomputeConfigs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	configIdsToBeDeleted = @(
		<System.String>
	)
}
"@
    Write-Message "Invoke-RscMutateAws -DeleteExocomputeConfigs" @"
    Deletes AWS Exocompute configs.
"@ "[GraphQL: deleteAwsExocomputeConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpdateExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpdateExocomputeConfigs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpdateExocomputeConfigs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpdateExocomputeConfigs" @"
    Update AWS Exocompute configs.
"@ "[GraphQL: updateAwsExocomputeConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -StartExocomputeDisableJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -StartExocomputeDisableJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -StartExocomputeDisableJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountId = <System.String>
}
"@
    Write-Message "Invoke-RscMutateAws -StartExocomputeDisableJob" @"
    Starts a job to disable AWS Exocompute feature. When complete, the job will disable exocompute feature for the specified AWS Native account.
"@ "[GraphQL: startAwsExocomputeDisableJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -AddIamUserBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -AddIamUserBasedCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -AddIamUserBasedCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -AddIamUserBasedCloudAccount" @"
    Adds an IAM user-based AWS cloud account and enables the features specified in the input after successful validation of the request.
"@ "[GraphQL: addAwsIamUserBasedCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpgradeIamUserBasedCloudAccountPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpgradeIamUserBasedCloudAccountPermissions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpgradeIamUserBasedCloudAccountPermissions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpgradeIamUserBasedCloudAccountPermissions" @"
    Set IAM user-based AWS account features status to Connected from Update Permissions state. It should be used by caution from cloud accounts only after latest required permissions are granted to authorized IAM user.
"@ "[GraphQL: upgradeAwsIamUserBasedCloudAccountPermissions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -UpgradeCloudAccountFeaturesWithoutCft
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -UpgradeCloudAccountFeaturesWithoutCft -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -UpgradeCloudAccountFeaturesWithoutCft -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -UpgradeCloudAccountFeaturesWithoutCft" @"
    Updates status of AWS cloud account features to connected if they are in update permissions state. This mutation should be used with caution. It should be invoked only after the latest required permissions are granted to the AWS cloud account user used by Rubrik. This mutation does not verify if the required permissions are actually granted to the user or not. Its usage is restricted to only IAM user-based and authentication server-based AWS cloud accounts.
"@ "[GraphQL: upgradeAwsCloudAccountFeaturesWithoutCft]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -AddAuthenticationServerBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -AddAuthenticationServerBasedCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -AddAuthenticationServerBasedCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -AddAuthenticationServerBasedCloudAccount" @"
    Validates and adds an authentication server-based AWS cloud account. When validation succeeds, the AWS cloud account is added and the features specified in the request are enabled. When validation fails, an error is not returned, but the cause of the failure is specified in the ""message"" field of the response object.
"@ "[GraphQL: addAwsAuthenticationServerBasedCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -PatchAuthenticationServerBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -PatchAuthenticationServerBasedCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -PatchAuthenticationServerBasedCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -PatchAuthenticationServerBasedCloudAccount" @"
    Updates authentication server-based AWS cloud account. Use this mutation to update account details related to role name, certificates, features. The mutation can update one or more certificates associated to an account in a single request. All input fields except account identifier are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
"@ "[GraphQL: patchAwsAuthenticationServerBasedCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -PatchIamUserBasedCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -PatchIamUserBasedCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -PatchIamUserBasedCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -PatchIamUserBasedCloudAccount" @"
    Updates IAM user-based AWS cloud account. Use this mutation to update account details access/secret keys, role ARN and regions. All input fields except account ID are optional so that any combination of account attributes can be updated in a single call. If none of the optional fields are provided in the input then no updates are performed, and the response does not contain any error message.
"@ "[GraphQL: patchAwsIamUserBasedCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -RegisterFeatureArtifacts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -RegisterFeatureArtifacts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -RegisterFeatureArtifacts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -RegisterFeatureArtifacts" @"
    Registers the AWS account artifacts such as roles in RSC backend while onboarding AWS account in manual flow.
"@ "[GraphQL: registerAwsFeatureArtifacts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -BulkDeleteCloudAccountWithoutCft
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -BulkDeleteCloudAccountWithoutCft -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -BulkDeleteCloudAccountWithoutCft -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -BulkDeleteCloudAccountWithoutCft" @"
    Deletes specified AWS cloud accounts without using CloudFormation Template (CFT).
"@ "[GraphQL: bulkDeleteAwsCloudAccountWithoutCft]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -CreateCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -CreateCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -CreateCluster" @"
    Create a Rubrik Cloud Cluster on AWS.
"@ "[GraphQL: createAwsCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAws -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAws -DeleteCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAws -DeleteCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAws -DeleteCluster" @"
    Delete a Rubrik Cloud Cluster on AWS.
"@ "[GraphQL: deleteAwsCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartRefreshNativeSubscriptionsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartRefreshNativeSubscriptionsJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartRefreshNativeSubscriptionsJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	azureSubscriptionRubrikIds = @(
		<System.String>
	)
}
"@
    Write-Message "Invoke-RscMutateAzure -StartRefreshNativeSubscriptionsJob" @"
    Start a job to refresh Azure Native subscription for the given subscription IDs. When started, this job will update the Rubrik platform with any changes that have been done on Azure for the respective subscription.
"@ "[GraphQL: startRefreshAzureNativeSubscriptionsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartRestoreNativeVirtualMachineJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartRestoreNativeVirtualMachineJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartRestoreNativeVirtualMachineJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartRestoreNativeVirtualMachineJob" @"
    Start a job to restore Azure Native virtual machine with the selected snapshot. When started, this will replace the original VM with the selected snapshot.
"@ "[GraphQL: startRestoreAzureNativeVirtualMachineJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartExportNativeVirtualMachineJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartExportNativeVirtualMachineJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartExportNativeVirtualMachineJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartExportNativeVirtualMachineJob" @"
    Start a job to export the Azure native virtual machine for a specified snapshot to a specified destination.
"@ "[GraphQL: startExportAzureNativeVirtualMachineJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -ExcludeNativeManagedDisksFromSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -ExcludeNativeManagedDisksFromSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -ExcludeNativeManagedDisksFromSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -ExcludeNativeManagedDisksFromSnapshot" @"
    Exclude the Managed Disks from snapshots, for the specified virtual machines.
"@ "[GraphQL: excludeAzureNativeManagedDisksFromSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartCreateNativeVirtualMachineSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartCreateNativeVirtualMachineSnapshotsJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartCreateNativeVirtualMachineSnapshotsJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartCreateNativeVirtualMachineSnapshotsJob" @"
    Start a job to create a snapshot for the Azure Native virtual machine identified by the IDs. When started, this will start taking an on-demand snapshot of the selected VMs as per the SLA Policy assigned to the respective VMs.
"@ "[GraphQL: startCreateAzureNativeVirtualMachineSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartDisableNativeSubscriptionProtectionJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartDisableNativeSubscriptionProtectionJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartDisableNativeSubscriptionProtectionJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartDisableNativeSubscriptionProtectionJob" @"
    Start a job to disable protection for a specified Azure subscription.
"@ "[GraphQL: startDisableAzureNativeSubscriptionProtectionJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartCreateNativeManagedDiskSnapshotsJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartCreateNativeManagedDiskSnapshotsJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartCreateNativeManagedDiskSnapshotsJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartCreateNativeManagedDiskSnapshotsJob" @"
    Start a job to create snapshots of the Azure Native Managed Disks identified by the given IDs. When started, this will start taking an on-demand snapshot of the selected disks as per the SLA Policy assigned to the respective disks.
"@ "[GraphQL: startCreateAzureNativeManagedDiskSnapshotsJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartExportNativeManagedDiskJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartExportNativeManagedDiskJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartExportNativeManagedDiskJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartExportNativeManagedDiskJob" @"
    Start a job to export the specified Azure Native Managed Disks to the desired destination.
"@ "[GraphQL: startExportAzureNativeManagedDiskJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartExportSqlDatabaseDbJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartExportSqlDatabaseDbJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartExportSqlDatabaseDbJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartExportSqlDatabaseDbJob" @"
    Start a job to export Azure SQL Database. The job creates a new Azure SQL Database with the same properties as that of the instance that is exported.
"@ "[GraphQL: startExportAzureSqlDatabaseDbJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartExportSqlManagedInstanceDbJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartExportSqlManagedInstanceDbJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartExportSqlManagedInstanceDbJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartExportSqlManagedInstanceDbJob" @"
    Start a job to export Azure SQL Managed Instance database. The job creates a new Azure SQL Managed Instance database with the same properties as that of the instance that is exported.
"@ "[GraphQL: startExportAzureSqlManagedInstanceDbJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CreateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CreateAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CreateAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -CreateAccount" @"
    
"@ "[GraphQL: createAzureAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpdateAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpdateAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpdateAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -UpdateAccount" @"
    
"@ "[GraphQL: updateAzureAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CreateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CreateAutomaticTargetMapping -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CreateAutomaticTargetMapping -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -CreateAutomaticTargetMapping" @"
    
"@ "[GraphQL: createAutomaticAzureTargetMapping]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CreateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CreateCloudNativeStorageSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CreateCloudNativeStorageSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -CreateCloudNativeStorageSetting" @"
    Creates Storage Settings for the archival of azure cloud native protected objects
"@ "[GraphQL: createCloudNativeAzureStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CreateCloudNativeRcvStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CreateCloudNativeRcvStorageSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CreateCloudNativeRcvStorageSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -CreateCloudNativeRcvStorageSetting" @"
    Create Rubrik Cloud Vault storage settings for archiving azure cloud native protected objects.
"@ "[GraphQL: createCloudNativeRcvAzureStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpdateAutomaticTargetMapping
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpdateAutomaticTargetMapping -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpdateAutomaticTargetMapping -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -UpdateAutomaticTargetMapping" @"
    
"@ "[GraphQL: updateAutomaticAzureTargetMapping]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpdateCloudNativeStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpdateCloudNativeStorageSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpdateCloudNativeStorageSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -UpdateCloudNativeStorageSetting" @"
    
"@ "[GraphQL: updateCloudNativeAzureStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpdateCloudNativeRcvStorageSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpdateCloudNativeRcvStorageSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpdateCloudNativeRcvStorageSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
	# REQUIRED
	name = <System.String>
}
"@
    Write-Message "Invoke-RscMutateAzure -UpdateCloudNativeRcvStorageSetting" @"
    Updates an existing Rubrik Cloud Vault Storage Settings for the archival of azure cloud native protected objects.
"@ "[GraphQL: updateCloudNativeRcvAzureStorageSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CreateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CreateTarget -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CreateTarget -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -CreateTarget" @"
    Creates an Azure archival target on the Rubrik cluster.
"@ "[GraphQL: createAzureTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpdateTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpdateTarget -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpdateTarget -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -UpdateTarget" @"
    
"@ "[GraphQL: updateAzureTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CreateReaderTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CreateReaderTarget -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CreateReaderTarget -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -CreateReaderTarget" @"
    Creates reader type for Azure archival location on a CDM cluster.
"@ "[GraphQL: createAzureReaderTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartCloudAccountOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartCloudAccountOauth -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartCloudAccountOauth -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	tenantDomainName = <System.String>
	# OPTIONAL
	azureCloudType = <AzureCloudType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudType]) for enum values.
}
"@
    Write-Message "Invoke-RscMutateAzure -StartCloudAccountOauth" @"
    Initiates a session before doing Azure OAuth flow. If a custom app is configured for the tenant, the client ID of the custom app is returned. Otherwise, the client ID of the default app is returned.
"@ "[GraphQL: startAzureCloudAccountOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CompleteCloudAccountOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CompleteCloudAccountOauth -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CompleteCloudAccountOauth -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -CompleteCloudAccountOauth" @"
    Complete the Azure OAuth flow and pass the authorization code.
"@ "[GraphQL: completeAzureCloudAccountOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -SetCloudAccountCustomerAppCredentials
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -SetCloudAccountCustomerAppCredentials -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -SetCloudAccountCustomerAppCredentials -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -SetCloudAccountCustomerAppCredentials" @"
    Set credentials for the customer application, for the tenant domain name.
"@ "[GraphQL: setAzureCloudAccountCustomerAppCredentials]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -AddCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -AddCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -AddCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -AddCloudAccount" @"
    Add the Azure Subscriptions cloud account for the given feature.
"@ "[GraphQL: addAzureCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -AddCloudAccountWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -AddCloudAccountWithoutOauth -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -AddCloudAccountWithoutOauth -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -AddCloudAccountWithoutOauth" @"
    Add the Azure Subscription cloud account for the given feature without OAuth.
"@ "[GraphQL: addAzureCloudAccountWithoutOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -DeleteCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -DeleteCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -DeleteCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -DeleteCloudAccount" @"
    Delete the Azure Subscriptions cloud account for the given feature.
"@ "[GraphQL: deleteAzureCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -DeleteCloudAccountWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -DeleteCloudAccountWithoutOauth -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -DeleteCloudAccountWithoutOauth -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -DeleteCloudAccountWithoutOauth" @"
    Delete the Azure Subscriptions cloud account for the given feature without OAuth.
"@ "[GraphQL: deleteAzureCloudAccountWithoutOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpgradeCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpgradeCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpgradeCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -UpgradeCloudAccount" @"
    Update permissions of the Azure Subscriptions cloud account for given feature.
"@ "[GraphQL: upgradeAzureCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpdateCustomerAppPermissionForSql
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpdateCustomerAppPermissionForSql -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpdateCustomerAppPermissionForSql -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscMutateAzure -UpdateCustomerAppPermissionForSql" @"
    Updates the Azure app for the specified account in an idempotent manner to support Azure SQL Database and  Managed Instance Database authentication.
"@ "[GraphQL: updateCustomerAppPermissionForAzureSql]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -StartDisableCloudAccountJob
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -StartDisableCloudAccountJob -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -StartDisableCloudAccountJob -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -StartDisableCloudAccountJob" @"
    Start on-demand jobs to disable the feature for the given Azure Cloud Accounts. When completed, the status of cloud account feature will change to Disabled and the feature will become eligible to be deleted.
"@ "[GraphQL: startDisableAzureCloudAccountJob]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpdateCloudAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpdateCloudAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpdateCloudAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -UpdateCloudAccount" @"
    Update names of the Azure Subscriptions cloud account and regions for the given feature.
"@ "[GraphQL: updateAzureCloudAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -MapCloudAccountToPersistentStorageLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -MapCloudAccountToPersistentStorageLocation -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -MapCloudAccountToPersistentStorageLocation -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -MapCloudAccountToPersistentStorageLocation" @"
    Map Azure cloud accounts to a persistent storage location.
"@ "[GraphQL: mapAzureCloudAccountToPersistentStorageLocation]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -AddCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -AddCloudAccountExocomputeConfigurations -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -AddCloudAccountExocomputeConfigurations -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -AddCloudAccountExocomputeConfigurations" @"
    Add Exocompute configurations for an Azure Cloud Account.
"@ "[GraphQL: addAzureCloudAccountExocomputeConfigurations]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -DeleteCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -DeleteCloudAccountExocomputeConfigurations -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -DeleteCloudAccountExocomputeConfigurations -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
}
"@
    Write-Message "Invoke-RscMutateAzure -DeleteCloudAccountExocomputeConfigurations" @"
    Delete Exocompute configurations for an Azure Cloud Account.
"@ "[GraphQL: deleteAzureCloudAccountExocomputeConfigurations]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -MapCloudAccountExocomputeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -MapCloudAccountExocomputeSubscription -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -MapCloudAccountExocomputeSubscription -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -MapCloudAccountExocomputeSubscription" @"
    Map Azure cloud accounts to an Exocompute subscription.
"@ "[GraphQL: mapAzureCloudAccountExocomputeSubscription]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UnmapCloudAccountExocomputeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UnmapCloudAccountExocomputeSubscription -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UnmapCloudAccountExocomputeSubscription -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	cloudAccountIds = @(
		<System.String>
	)
}
"@
    Write-Message "Invoke-RscMutateAzure -UnmapCloudAccountExocomputeSubscription" @"
    Unmap Azure cloud accounts from the mapped Exocompute subscription.
"@ "[GraphQL: unmapAzureCloudAccountExocomputeSubscription]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UpgradeCloudAccountPermissionsWithoutOauth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UpgradeCloudAccountPermissionsWithoutOauth -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UpgradeCloudAccountPermissionsWithoutOauth -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -UpgradeCloudAccountPermissionsWithoutOauth" @"
    Set Azure Cloud Account feature status to Connected from Update Permissions state without any permission validation. It should be used by caution from cloud accounts which have been set up without using OAuth, only after adding the latest permissions that are required.
"@ "[GraphQL: upgradeAzureCloudAccountPermissionsWithoutOauth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -UnmapPersistentStorageSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -UnmapPersistentStorageSubscription -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -UnmapPersistentStorageSubscription -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -UnmapPersistentStorageSubscription" @"
    Unmaps the archival location from the subscription.
"@ "[GraphQL: unmapAzurePersistentStorageSubscription]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -OauthConsentKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -OauthConsentKickoff -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -OauthConsentKickoff -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscMutateAzure -OauthConsentKickoff" @"
    Kicks off an OAuth consent flow for Azure resource access.
"@ "[GraphQL: azureOauthConsentKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -OauthConsentComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -OauthConsentComplete -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -OauthConsentComplete -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -OauthConsentComplete" @"
    Completes an OAuth consent flow for Azure resource access.
"@ "[GraphQL: azureOauthConsentComplete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CreateSaasAppAad
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CreateSaasAppAad -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CreateSaasAppAad -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscMutateAzure -CreateSaasAppAad" @"
    Create or get an Azure AAD application.
"@ "[GraphQL: createAzureSaasAppAad]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -CreateCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -CreateCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -CreateCluster" @"
    Create a Rubrik Cloud Cluster on Azure.
"@ "[GraphQL: createAzureCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateAzure -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzure -DeleteCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzure -DeleteCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzure -DeleteCluster" @"
    Delete a Rubrik Cloud Cluster on Azure.
"@ "[GraphQL: deleteAzureCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateAzureO365 -SetupExocompute
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateAzureO365 -SetupExocompute -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateAzureO365 -SetupExocompute -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateAzureO365 -SetupExocompute" @"
    Sets up Exocompute for an O365 subscription.
"@ "[GraphQL: setupAzureO365Exocompute]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateCassandra -RecoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCassandra -RecoverSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCassandra -RecoverSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCassandra -RecoverSource" @"
    Recover a cassandra source.
"@ "[GraphQL: recoverCassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCassandra -CreateSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCassandra -CreateSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCassandra -CreateSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCassandra -CreateSource" @"
    Create a cassandra source.
"@ "[GraphQL: createCassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCassandra -UpdateSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCassandra -UpdateSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCassandra -UpdateSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCassandra -UpdateSource" @"
    Update a cassandra source.
"@ "[GraphQL: updateCassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCassandra -DeleteSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCassandra -DeleteSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCassandra -DeleteSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCassandra -DeleteSource" @"
    Delete a cassandra source.
"@ "[GraphQL: deleteCassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCassandra -BulkDeleteSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCassandra -BulkDeleteSources -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCassandra -BulkDeleteSources -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCassandra -BulkDeleteSources" @"
    Bulk Delete cassandra sources.
"@ "[GraphQL: bulkDeleteCassandraSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateCluster -AddNodesToCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -AddNodesToCloud -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -AddNodesToCloud -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCluster -AddNodesToCloud" @"
    Add nodes to cloud cluster.
"@ "[GraphQL: addNodesToCloudCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -RegisterCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -RegisterCloud -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -RegisterCloud -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscMutateCluster -RegisterCloud" @"
    Register a cloud cluster.
"@ "[GraphQL: registerCloudCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -UpdateDatabaseLogReportingProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -UpdateDatabaseLogReportingProperties -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -UpdateDatabaseLogReportingProperties -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCluster -UpdateDatabaseLogReportingProperties" @"
    Update the database log backup report properties

Supported in v5.3+
Update the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.
"@ "[GraphQL: updateDatabaseLogReportingPropertiesForCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -CreateFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -CreateFailover -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -CreateFailover -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCluster -CreateFailover" @"
    Create a failover cluster

Supported in v5.2+
Create a failover cluster.
"@ "[GraphQL: createFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -UpdateFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -UpdateFailover -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -UpdateFailover -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCluster -UpdateFailover" @"
    Update a failover cluster

Supported in v5.2+
Update failover cluster with specified properties.
"@ "[GraphQL: updateFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -DeleteFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -DeleteFailover -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -DeleteFailover -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	preserveSnapshots = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateCluster -DeleteFailover" @"
    Delete a failover cluster

Supported in v5.2+
Delete a failover cluster.
"@ "[GraphQL: deleteFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -BulkDeleteFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -BulkDeleteFailover -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -BulkDeleteFailover -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCluster -BulkDeleteFailover" @"
    Delete the provided failover clusters

Supported in v5.3+
Delete the provided failover clusters.
"@ "[GraphQL: bulkDeleteFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -CreateK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -CreateK8s -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -CreateK8s -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCluster -CreateK8s" @"
    Add a Kubernetes cluster.
"@ "[GraphQL: createK8sCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -RefreshK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -RefreshK8s -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -RefreshK8s -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	k8sClusterId = <System.String>
}
"@
    Write-Message "Invoke-RscMutateCluster -RefreshK8s" @"
    Refresh resources of a Kubernetes cluster.
"@ "[GraphQL: refreshK8sCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -ArchiveK8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -ArchiveK8s -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -ArchiveK8s -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterId = <System.String>
}
"@
    Write-Message "Invoke-RscMutateCluster -ArchiveK8s" @"
    Archive a Kubernetes cluster.
"@ "[GraphQL: archiveK8sCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -RemoveCdm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -RemoveCdm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -RemoveCdm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUUID = <System.String>
# REQUIRED
$inputs.Var.isForce = <System.Boolean>
# OPTIONAL
$inputs.Var.expireInDays = <System.Int64>
"@
    Write-Message "Invoke-RscMutateCluster -RemoveCdm" @"
    
"@ "[GraphQL: removeCdmCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateCluster -RecoverCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateCluster -RecoverCloud -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateCluster -RecoverCloud -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateCluster -RecoverCloud" @"
    Recover a Rubrik Cloud Cluster.
"@ "[GraphQL: recoverCloudCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -AddInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -AddInstance -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -AddInstance -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateDb2 -AddInstance" @"
    Mutation to add a new Db2 instance.
"@ "[GraphQL: addDb2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -DeleteInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -DeleteInstance -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -DeleteInstance -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateDb2 -DeleteInstance" @"
    Mutation to delete existing Db2 instance.
"@ "[GraphQL: deleteDb2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -DiscoverInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -DiscoverInstance -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -DiscoverInstance -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateDb2 -DiscoverInstance" @"
    On-demand discovery of a Db2 instance

Supported in v7.0+
Initiates an on-demand job to discover a Db2 instance.
"@ "[GraphQL: discoverDb2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -PatchInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -PatchInstance -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -PatchInstance -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateDb2 -PatchInstance" @"
    Mutation to update an existing Db2 instance.
"@ "[GraphQL: patchDb2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -CreateOnDemandBackup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -CreateOnDemandBackup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateDb2 -CreateOnDemandBackup" @"
    Create on demand database snapshot

Supported in v8.0+
Initiates a job to take an on demand, full snapshot of a specified Db2 database object. Use the GET /db2/db/request/{id} endpoint to monitor the progress of the job.
"@ "[GraphQL: createOnDemandDb2Backup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -DownloadSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -DownloadSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	locationId = <System.String>
	# REQUIRED
	snapshotId = <System.String>
}
"@
    Write-Message "Invoke-RscMutateDb2 -DownloadSnapshot" @"
    Download Db2 database snapshot from archive

Supported in v8.0+
Downloads a specific Db2 database snapshot from the specified archival location.
"@ "[GraphQL: downloadDb2Snapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -DownloadSnapshotsForPointInTimeRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -DownloadSnapshotsForPointInTimeRecovery -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -DownloadSnapshotsForPointInTimeRecovery -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateDb2 -DownloadSnapshotsForPointInTimeRecovery" @"
    Download Db2 database snapshots from archive for a point in time recovery

Supported in v8.0+
Downloads the most recent full snapshot and the log snapshots taken after the full snapshot, required for the point in time recovery of a Db2 database.
"@ "[GraphQL: downloadDb2SnapshotsForPointInTimeRecovery]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -ExpireDownloadedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -ExpireDownloadedSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -ExpireDownloadedSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateDb2 -ExpireDownloadedSnapshots" @"
    Expire downloaded snapshots of a Db2 database

Supported in v8.0+
Requests an asynchronous job to expire all downloaded data and log snapshots. You can specify a begin time or an end time or both to provide a time range to expire only the downloaded data and log snapshots that were taken within the specified time range. The time is relative to when the snapshot was originally taken, not when it was downloaded. You can also configure a flag to expire only the log snapshots.
"@ "[GraphQL: expireDownloadedDb2Snapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -PatchDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -PatchDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -PatchDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateDb2 -PatchDatabase" @"
    Update a Db2 database

Supported in v9.0+
Updating a Db2 database involves modifying the metadata associated with the Db2 database using the provided input values.
"@ "[GraphQL: patchDb2Database]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -RefreshDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -RefreshDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -RefreshDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateDb2 -RefreshDatabase" @"
    On-demand refresh of a Db2 database

Supported in v8.1+
Initiates an on-demand job to refresh a Db2 database. Currently, this is allowed only for Db2 HADR databases.
"@ "[GraphQL: refreshDb2Database]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateDb2 -DeleteDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateDb2 -DeleteDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateDb2 -DeleteDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateDb2 -DeleteDatabase" @"
    Delete Db2 database

Supported in v8.1+
Deletes a Db2 database.
"@ "[GraphQL: deleteDb2Database]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -RegisterScvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -RegisterScvmm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -RegisterScvmm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -RegisterScvmm" @"
    Register HyperV SCVMM to Rubrik Cluster.
"@ "[GraphQL: registerHypervScvmm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -ScvmmUpdate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -ScvmmUpdate -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -ScvmmUpdate -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -ScvmmUpdate" @"
    Update properties for a given HyperV SCVMM.
"@ "[GraphQL: hypervScvmmUpdate]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -ScvmmDelete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -ScvmmDelete -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -ScvmmDelete -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateHyperv -ScvmmDelete" @"
    Delete a given HyperV SCVMM.
"@ "[GraphQL: hypervScvmmDelete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -RefreshScvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -RefreshScvmm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -RefreshScvmm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateHyperv -RefreshScvmm" @"
    Refresh a given HyperV SCVMM.
"@ "[GraphQL: refreshHypervScvmm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -OnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -OnDemandSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -OnDemandSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -OnDemandSnapshot" @"
    Create on-demand VM snapshot

Supported in v5.0+
Create an on-demand snapshot for the given VM ID.
"@ "[GraphQL: hypervOnDemandSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -DeleteAllSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -DeleteAllSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -DeleteAllSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateHyperv -DeleteAllSnapshots" @"
    Delete all snapshots of VM

Supported in v5.0+
Delete all snapshots of a virtual machine.
"@ "[GraphQL: hypervDeleteAllSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -ExportVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -ExportVirtualMachine -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -ExportVirtualMachine -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -ExportVirtualMachine" @"
    Export VM snapshot

Supported in v5.0+
Export snapshot of a vm.
"@ "[GraphQL: exportHypervVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshotFiles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshotFiles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshotFiles" @"
    Download files from a Hyper-V VM backup

Supported in v5.0+
Start an asynchronous job to download multiple files and folders from a specified Hyper-V VM backup. The response returns an asynchrounous request ID. Get the URL for downloading the ZIP file including the specific files/folders by sending a GET request to 'hyperv/vm/request/{id}'.
"@ "[GraphQL: downloadHypervVirtualMachineSnapshotFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -InstantRecoverVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -InstantRecoverVirtualMachineSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -InstantRecoverVirtualMachineSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -InstantRecoverVirtualMachineSnapshot" @"
    Creates an instant recover request that restores a target VM from the given Rubrik-hosted-snapshot

Supported in v5.0+
The VM will be started with networking enabled. If the VM does not exist anymore, a new VM will be created.
"@ "[GraphQL: instantRecoverHypervVirtualMachineSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -RestoreVirtualMachineSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -RestoreVirtualMachineSnapshotFiles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -RestoreVirtualMachineSnapshotFiles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -RestoreVirtualMachineSnapshotFiles" @"
    Restore files from snapshot

Supported in v5.0+
Restore files from a snapshot to the original source location.
"@ "[GraphQL: restoreHypervVirtualMachineSnapshotFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -RegisterAgentVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -RegisterAgentVirtualMachine -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -RegisterAgentVirtualMachine -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateHyperv -RegisterAgentVirtualMachine" @"
    Register the agent installed in VM

Supported in v5.0+
Register the agent that installed in VM.
"@ "[GraphQL: registerAgentHypervVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <InternalDeleteHypervVirtualMachineSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteHypervVirtualMachineSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshot" @"
    Delete VM snapshot

Supported in v5.0+
Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.
"@ "[GraphQL: deleteHypervVirtualMachineSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateHyperv -DownloadVirtualMachineSnapshot" @"
    Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
"@ "[GraphQL: downloadHypervVirtualMachineSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -CreateVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -CreateVirtualMachineSnapshotMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -CreateVirtualMachineSnapshotMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -CreateVirtualMachineSnapshotMount" @"
    Create a live mount request

Supported in v5.0+
Create a live mount request with given configuration.
"@ "[GraphQL: createHypervVirtualMachineSnapshotMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -UpdateVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -UpdateVirtualMachineSnapshotMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -UpdateVirtualMachineSnapshotMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -UpdateVirtualMachineSnapshotMount" @"
    Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.
"@ "[GraphQL: updateHypervVirtualMachineSnapshotMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshotMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshotMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshotMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateHyperv -DeleteVirtualMachineSnapshotMount" @"
    Requst to delete a live mount

Supported in v5.0+
Create a request to delete a live mount.
"@ "[GraphQL: deleteHypervVirtualMachineSnapshotMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -RefreshServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -RefreshServer -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -RefreshServer -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateHyperv -RefreshServer" @"
    Refresh Hyper-V host metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Hyper-V host.
"@ "[GraphQL: refreshHypervServer]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -BatchOnDemandBackupVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -BatchOnDemandBackupVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -BatchOnDemandBackupVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -BatchOnDemandBackupVm" @"
    Takes bulk on-demand backup of Hyper-V virtual machines

Supported in v9.0+
Takes on-demand backup of multiple specified Hyper-V virtual machines.
"@ "[GraphQL: batchOnDemandBackupHypervVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -BatchExportVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -BatchExportVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -BatchExportVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -BatchExportVm" @"
    Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.
"@ "[GraphQL: batchExportHypervVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -BatchMountVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -BatchMountVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -BatchMountVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -BatchMountVm" @"
    Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.
"@ "[GraphQL: batchMountHypervVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -BatchInstantRecoverVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -BatchInstantRecoverVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -BatchInstantRecoverVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -BatchInstantRecoverVm" @"
    Instantly recovers snapshots from multiple virtual machines

Supported in v7.0+
Instantly recovers a batch of snapshots from a group of specified virtual machines.
"@ "[GraphQL: batchInstantRecoverHypervVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -UpdateVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -UpdateVirtualMachine -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -UpdateVirtualMachine -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -UpdateVirtualMachine" @"
    Update VM

Supported in v5.0+
Update VM with specified properties.
"@ "[GraphQL: updateHypervVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateHyperv -DownloadSnapshotFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateHyperv -DownloadSnapshotFromLocation -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateHyperv -DownloadSnapshotFromLocation -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateHyperv -DownloadSnapshotFromLocation" @"
    Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
"@ "[GraphQL: downloadHypervSnapshotFromLocation]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateLdap -UpdateIntegration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateLdap -UpdateIntegration -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateLdap -UpdateIntegration -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateLdap -UpdateIntegration" @"
    Mutate LDAP integration.
"@ "[GraphQL: updateLdapIntegration]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateLdap -RemoveIntegration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateLdap -RemoveIntegration -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateLdap -RemoveIntegration -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.id = <System.String>
"@
    Write-Message "Invoke-RscMutateLdap -RemoveIntegration" @"
    Remove LDAP integration.
"@ "[GraphQL: removeLdapIntegration]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateLdap -DeletePrincipals
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateLdap -DeletePrincipals -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateLdap -DeletePrincipals -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.principalIds = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscMutateLdap -DeletePrincipals" @"
    
"@ "[GraphQL: deleteLdapPrincipals]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateLdap -SetMfaSetting
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateLdap -SetMfaSetting -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateLdap -SetMfaSetting -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	ldapId = <System.String>
	# OPTIONAL
	isTotpEnforced = <System.Boolean>
}
"@
    Write-Message "Invoke-RscMutateLdap -SetMfaSetting" @"
    Update the MFA settings for the given LDAP integration. Return true when the operation succeeds.
"@ "[GraphQL: setLdapMfaSetting]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateMongo -AddSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -AddSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -AddSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -AddSource" @"
    Add a new MongoDB source

Supported in v8.1+
Adds a new MongoDB source to the Rubrik Cluster.
"@ "[GraphQL: addMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -DeleteSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -DeleteSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -DeleteSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateMongo -DeleteSource" @"
    Delete a MongoDB source

Supported in v8.1+
Deletes a specific MongoDB source.
"@ "[GraphQL: deleteMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -DiscoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -DiscoverSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -DiscoverSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateMongo -DiscoverSource" @"
    Discover a MongoDB source on-demand

Supported in v8.1+
Initiates an on-demand job to discover a MongoDB source.
"@ "[GraphQL: discoverMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -PatchSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -PatchSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -PatchSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -PatchSource" @"
    Edit a MongoDB source

Supported in v8.1+
Edits the properties of a MongoDB source. Hosts, name, and type of MongoDB cannot be changed once added.
"@ "[GraphQL: patchMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -RetryAddSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -RetryAddSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -RetryAddSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -RetryAddSource" @"
    Update a MongoDB source

Supported in v8.1+
Updates a MongoDB source details. You can use this endpoint for updating MongoDB source details when the request to add a source fails.
"@ "[GraphQL: retryAddMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -AssignSlaToDbCollection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -AssignSlaToDbCollection -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -AssignSlaToDbCollection -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -AssignSlaToDbCollection" @"
    Assign SLA Domain to MongoDB collection objects

Supported in v8.1+
Assigns SLA Domain to the given MongoDB collection objects.
"@ "[GraphQL: assignSlaToMongoDbCollection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -RecoverSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -RecoverSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -RecoverSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -RecoverSource" @"
    Recover a MongoDB source from Rubrik CDM cluster.
"@ "[GraphQL: recoverMongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -CreatedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -CreatedbSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -CreatedbSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -CreatedbSource" @"
    Register a new MongoDB source to NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster.
For more info on MongoDB cluster, refer to: https://docs.mongodb.com/manual/introduction/.
"@ "[GraphQL: createMongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -UpdatedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -UpdatedbSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -UpdatedbSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -UpdatedbSource" @"
    Modifies configuration for a registered MongoDB source in NoSQL cluster.
"@ "[GraphQL: updateMongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -DeletedbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -DeletedbSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -DeletedbSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -DeletedbSource" @"
    Remove a registered MongoDB source from NoSQL cluster.
"@ "[GraphQL: deleteMongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -BulkDeletedbSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -BulkDeletedbSources -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -BulkDeletedbSources -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -BulkDeletedbSources" @"
    Bulk Delete Sources

Supported in m3.2.0-m4.2.0.
"@ "[GraphQL: bulkDeleteMongodbSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMongo -RecoverdbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMongo -RecoverdbSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMongo -RecoverdbSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMongo -RecoverdbSource" @"
    Recover a MongoDB source from NoSQL cluster.
"@ "[GraphQL: recoverMongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateMssql -BrowseDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -BrowseDatabaseSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -BrowseDatabaseSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -BrowseDatabaseSnapshot" @"
    List snapshots and logs from a Mssql Database. This endpoint is only used to fetch data, but uses a mutation instead of a query due to limitations with the CDM API.
"@ "[GraphQL: browseMssqlDatabaseSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -ExportDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -ExportDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -ExportDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -ExportDatabase" @"
    Create a request to export a Microsoft SQL database.
"@ "[GraphQL: exportMssqlDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -RestoreDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -RestoreDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -RestoreDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -RestoreDatabase" @"
    Create a request to restore a Microsoft SQL database.
"@ "[GraphQL: restoreMssqlDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -BulkUpdateDbs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -BulkUpdateDbs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -BulkUpdateDbs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -BulkUpdateDbs" @"
    Update multiple Microsoft SQL databases with the specified properties.
"@ "[GraphQL: bulkUpdateMssqlDbs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -TakeLogBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -TakeLogBackup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -TakeLogBackup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateMssql -TakeLogBackup" @"
    Take an on-demand log backup for a Microsoft SQL database.
"@ "[GraphQL: takeMssqlLogBackup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -CreateOnDemandBackup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -CreateOnDemandBackup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -CreateOnDemandBackup" @"
    Take an on-demand backup of a Microsoft SQL Database
"@ "[GraphQL: createOnDemandMssqlBackup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -DeleteDbSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -DeleteDbSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -DeleteDbSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateMssql -DeleteDbSnapshots" @"
    Delete snapshots of a Microsoft SQL Database.
"@ "[GraphQL: deleteMssqlDbSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -DeleteLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -DeleteLiveMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -DeleteLiveMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateMssql -DeleteLiveMount" @"
    Delete a Live Mount of a SQL Server database

Supported in v5.0+
Create an async request to delete a Live Mount of a SQL Server database. Poll the task status by using /mssql/request/{id}.
"@ "[GraphQL: deleteMssqlLiveMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -BulkCreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -BulkCreateOnDemandBackup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -BulkCreateOnDemandBackup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -BulkCreateOnDemandBackup" @"
    Take a bulk on-demand backup of a Microsoft SQL Database.
"@ "[GraphQL: bulkCreateOnDemandMssqlBackup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -CreateLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -CreateLiveMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -CreateLiveMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -CreateLiveMount" @"
    Create live mount of a Microsoft SQL Database.
"@ "[GraphQL: createMssqlLiveMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -UpdateLogShippingConfiguration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -UpdateLogShippingConfiguration -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -UpdateLogShippingConfiguration -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -UpdateLogShippingConfiguration" @"
    Update log shipping configuration of a Microsoft SQL Database.
"@ "[GraphQL: updateMssqlLogShippingConfiguration]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -DownloadDatabaseFilesFromArchivalLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -DownloadDatabaseFilesFromArchivalLocation -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -DownloadDatabaseFilesFromArchivalLocation -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -DownloadDatabaseFilesFromArchivalLocation" @"
    Download Microsoft SQL Database backup files from archival location.
"@ "[GraphQL: downloadMssqlDatabaseFilesFromArchivalLocation]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -DownloadDatabaseBackupFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -DownloadDatabaseBackupFiles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -DownloadDatabaseBackupFiles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -DownloadDatabaseBackupFiles" @"
    Downloads a list of snapshot and log backups from a Microsoft SQL database

Supported in v5.2+
Downloads a list of snapshot and log backups from a Microsoft SQL database.
"@ "[GraphQL: downloadMssqlDatabaseBackupFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -AssignSlaDomainProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -AssignSlaDomainProperties -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -AssignSlaDomainProperties -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -AssignSlaDomainProperties" @"
    Assign SLA domain properties to Mssql objects.
"@ "[GraphQL: assignMssqlSlaDomainProperties]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -UpdateDefaultProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -UpdateDefaultProperties -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -UpdateDefaultProperties -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -UpdateDefaultProperties" @"
    Update the default properties for Microsoft SQL databases.
"@ "[GraphQL: updateMssqlDefaultProperties]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -CreateLogShippingConfiguration
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -CreateLogShippingConfiguration -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -CreateLogShippingConfiguration -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -CreateLogShippingConfiguration" @"
    Create log shipping configuration of a Microsoft SQL Database.
"@ "[GraphQL: createMssqlLogShippingConfiguration]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateMssql -AssignSlaDomainPropertiesAsync
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateMssql -AssignSlaDomainPropertiesAsync -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateMssql -AssignSlaDomainPropertiesAsync -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateMssql -AssignSlaDomainPropertiesAsync" @"
    Assign SLA domain properties to Mssql objects.
"@ "[GraphQL: assignMssqlSlaDomainPropertiesAsync]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -CreateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -CreateCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -CreateCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -CreateCluster" @"
    Add Nutanix cluster

Supported in v5.0+
Create a Nutanix cluster object by providing an address and account credentials for Prism. Initiates an asynchronous job to establish a connection with the cluster and retrieve all metadata. Use GET /nutanix_cluster/{id}/status to check status.
"@ "[GraphQL: createNutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -RefreshCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -RefreshCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -RefreshCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -RefreshCluster" @"
    Refresh Nutanix cluster metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified Nutanix cluster.
"@ "[GraphQL: refreshNutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -UpdateCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -UpdateCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -UpdateCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -UpdateCluster" @"
    Patch Nutanix cluster

Supported in v5.0+
Patch the host, credentials, and/or CA certs of the specified Nutanix cluster object.
"@ "[GraphQL: updateNutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -DeleteCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -DeleteCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -DeleteCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -DeleteCluster" @"
    Remove Nutanix cluster

Supported in v5.0+
Initiates an asynchronous job to remove a Nutanix cluster object. The Nutanix cluster cannot have VMs mounted through the Rubrik cluster.
"@ "[GraphQL: deleteNutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -RegisterAgentVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -RegisterAgentVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -RegisterAgentVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -RegisterAgentVm" @"
    v5.0-v8.0: Register the agent installed on the Nutanix VM
v8.1+: Register the agent installed on the Nutanix virtual machine

Supported in v5.0+
v5.0-v5.3: Register the agent installed on the Nutanix VM
v6.0-v8.0: Register the agent installed on the Nutanix VM.
v8.1+: Register the agent installed on the Nutanix virtual machine.
"@ "[GraphQL: registerAgentNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -UpdateVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -UpdateVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -UpdateVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -UpdateVm" @"
    v5.0-v8.0: Patch VM
v8.1+: Patch virtual machine

Supported in v5.0+
v5.0-v5.3: Patch VM with specified properties
v6.0-v8.0: Patch VM with specified properties.
v8.1+: Patch virtual machine with specified properties.
"@ "[GraphQL: updateNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -CreateOnDemandBackup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -CreateOnDemandBackup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -CreateOnDemandBackup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -CreateOnDemandBackup" @"
    v5.0-v8.0: Create on-demand VM snapshot
v8.1+: Create on-demand virtual machine snapshot

Supported in v5.0+
v5.0-v5.3: Create an on-demand snapshot for the given VM ID
v6.0-v8.0: Create an on-demand snapshot for the given VM ID.
v8.1+: Create an on-demand snapshot for the given virtual machine ID.
"@ "[GraphQL: createOnDemandNutanixBackup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -DeleteSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -DeleteSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -DeleteSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -DeleteSnapshots" @"
    v5.0-v8.0: Delete all snapshots of VM
v8.1+: Delete all snapshots of virtual machine

Supported in v5.0+
Delete all snapshots of a virtual machine.
"@ "[GraphQL: deleteNutanixSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -MountSnapshotV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -MountSnapshotV1 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -MountSnapshotV1 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -MountSnapshotV1" @"
    Initiate a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to perform a Live Mount of a Nutanix virtual machine snapshot identified by the snapshot ID.
"@ "[GraphQL: mountNutanixSnapshotV1]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -PatchMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -PatchMountV1 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -PatchMountV1 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -PatchMountV1" @"
    Change Nutanix Live Mount power status

Supported in v6.0+
Changes the power status of a mounted Nutanix virtual machine.
"@ "[GraphQL: patchNutanixMountV1]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -DeleteMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -DeleteMountV1 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -DeleteMountV1 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -DeleteMountV1" @"
    Remove a Live Mount of a Nutanix virtual machine snapshot

Supported in v6.0+
Initiates a request to remove a Live Mount of a Nutanix virtual machine snapshot identified by the ID of the Live Mount.
"@ "[GraphQL: deleteNutanixMountV1]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -MigrateMountV1
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -MigrateMountV1 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -MigrateMountV1 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -MigrateMountV1" @"
    Relocate a Nutanix virtual machine to another storage container

Supported in v6.0+
Initiate a request to migrate the virtual disks of a specified Nutanix Live Mount to another storage container. The destination storage container has been specified when the Live Mount was created. The Live Mount will be deleted when the relocation succeeds.
"@ "[GraphQL: migrateNutanixMountV1]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -DeleteSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -DeleteSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -DeleteSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <InternalDeleteNutanixSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.InternalDeleteNutanixSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -DeleteSnapshot" @"
    v5.0-v8.0: Delete VM snapshot
v8.1+: Delete virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected vm.
v8.1+: Delete a snapshot by expiring it. Snapshot is expired only if it is a manual snapshot or a snapshot of an unprotected virtual machine.
"@ "[GraphQL: deleteNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -RestoreFilesSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -RestoreFilesSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -RestoreFilesSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -RestoreFilesSnapshot" @"
    Restore files

Supported in v5.0+
Restore files from a snapshot to the source Nutanix virtual machine.
"@ "[GraphQL: restoreFilesNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -DownloadFilesSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -DownloadFilesSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -DownloadFilesSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -DownloadFilesSnapshot" @"
    v5.0-v8.0: Download files from a Nutanix VM backup
v8.1+: Download files from a Nutanix virtual machine backup

Supported in v5.0+
v5.0-v8.0: Start an asynchronous job to download multiple files and folders from a specified Nutanix VM backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
v8.1+: Start an asynchronous job to download multiple files and folders from a specified Nutanix virtual machine backup. The response returns an asynchronous request ID. Get the URL for downloading the zip file including the specific files/folders by sending a GET request to 'nutanix/vm/request/{id}'.
"@ "[GraphQL: downloadFilesNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -ExportSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -ExportSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -ExportSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -ExportSnapshot" @"
    v5.0-v8.0: Export VM snapshot
v8.1+: Export virtual machine snapshot

Supported in v5.0+
v5.0-v8.0: Export snapshot of a vm.
v8.1+: Export snapshot of a virtual machine.
"@ "[GraphQL: exportNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -DownloadSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -DownloadSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -DownloadSnapshot" @"
    Creates a download from archival request

Supported in v5.0+
Download a snapshot from archival.
"@ "[GraphQL: downloadNutanixSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -BatchExportVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -BatchExportVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -BatchExportVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -BatchExportVm" @"
    Exports a snapshot from each member of a set of virtual machines

Supported in v7.0+
Export a snapshot from each member of a set of virtual machines.
"@ "[GraphQL: batchExportNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -BatchMountVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -BatchMountVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -BatchMountVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -BatchMountVm" @"
    Mount snapshots from multiple virtual machines

Supported in v7.0+
Mounts a batch of snapshots from a group of specified virtual machines.
"@ "[GraphQL: batchMountNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -DownloadVmFromLocation
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -DownloadVmFromLocation -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -DownloadVmFromLocation -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -DownloadVmFromLocation" @"
    Download a snapshot from a replication target

Supported in v7.0+
Initiates a job to download a snapshot from the specified location when the snapshot does not exist locally. The specified location has to be a replication target connected to this Rubrik cluster. If an SLA Domain is not provided, the snapshot will be retained forever.
"@ "[GraphQL: downloadNutanixVmFromLocation]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -CreatePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -CreatePrismCentral -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -CreatePrismCentral -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -CreatePrismCentral" @"
    Add Nutanix Prism Central and it's corresponding Prism Elements

Supported in v9.0+
Create a Nutanix Prism Central object and refresh the Prism Elements present in it.
"@ "[GraphQL: createNutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -UpdatePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -UpdatePrismCentral -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -UpdatePrismCentral -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -UpdatePrismCentral" @"
    Patch Nutanix Prism Central

Supported in v9.0+
Patch the host and credentials of Nutanix Prism Central.
"@ "[GraphQL: updateNutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -DeletePrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -DeletePrismCentral -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -DeletePrismCentral -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -DeletePrismCentral" @"
    Remove Nutanix Prism Central

Supported in v9.0+
Initiates an asynchronous job to remove a Nutanix Prism Central object. The Nutanix Clusters attached to the Prism Central cannot have Virtual Machines mounted through the Rubrik cluster.
"@ "[GraphQL: deleteNutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -RefreshPrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -RefreshPrismCentral -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -RefreshPrismCentral -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateNutanix -RefreshPrismCentral" @"
    Refresh Nutanix Prism Central metadata

Supported in v9.0+
Initiates a job to refresh the metadata for the specified Nutanix Prism Central and all its associated clusters.
"@ "[GraphQL: refreshNutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateNutanix -BulkOnDemandSnapshotVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateNutanix -BulkOnDemandSnapshotVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateNutanix -BulkOnDemandSnapshotVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateNutanix -BulkOnDemandSnapshotVm" @"
    Take an on-demand snapshot for selected Nutanix virtual machines

Supported in v9.0+
Take bulk backups for multiple Nutanix virtual machines.
"@ "[GraphQL: bulkOnDemandSnapshotNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateO365 -SaaSSetupKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -SaaSSetupKickoff -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -SaaSSetupKickoff -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscMutateO365 -SaaSSetupKickoff" @"
    
"@ "[GraphQL: o365SaaSSetupKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -PdlGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -PdlGroups -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -PdlGroups -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -PdlGroups" @"
    Retrieve or create the groups corresponding to the preferred data location and workload pairings for use in role creation.
"@ "[GraphQL: o365PdlGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -SaasSetupComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -SaasSetupComplete -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -SaasSetupComplete -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -SaasSetupComplete" @"
    Completes a Rubrik-Hosted setup flow.
"@ "[GraphQL: o365SaasSetupComplete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -SetupKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -SetupKickoff -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -SetupKickoff -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscMutateO365 -SetupKickoff" @"
    Kicks off an O365 subscription setup flow.
"@ "[GraphQL: o365SetupKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -AddOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -AddOrg -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -AddOrg -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -AddOrg" @"
    Adds an O365 org to the account.
"@ "[GraphQL: addO365Org]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -OauthConsentKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -OauthConsentKickoff -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -OauthConsentKickoff -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	appType = <System.String>
}
"@
    Write-Message "Invoke-RscMutateO365 -OauthConsentKickoff" @"
    Kicks off the OAuth consent flow for an O365 Azure AD App.
"@ "[GraphQL: o365OauthConsentKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -OauthConsentComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -OauthConsentComplete -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -OauthConsentComplete -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -OauthConsentComplete" @"
    Completes the OAuth consent flow for an O365 Azure AD App.
"@ "[GraphQL: o365OauthConsentComplete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -CreateAppKickoff
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -CreateAppKickoff -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -CreateAppKickoff -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgId = <System.String>
	# REQUIRED
	appType = <System.String>
}
"@
    Write-Message "Invoke-RscMutateO365 -CreateAppKickoff" @"
    Kicks off the creation flow for an O365 Azure AD App.
"@ "[GraphQL: createO365AppKickoff]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -CreateAppComplete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -CreateAppComplete -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -CreateAppComplete -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -CreateAppComplete" @"
    Completes the creation flow for an O365 Azure AD App.
"@ "[GraphQL: createO365AppComplete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -InsertCustomerApp
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -InsertCustomerApp -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -InsertCustomerApp -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -InsertCustomerApp" @"
    Inserts a Customer-hosted O365 Azure AD App.
"@ "[GraphQL: insertCustomerO365App]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -UpdateAppAuthStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -UpdateAppAuthStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -UpdateAppAuthStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	o365OrgId = <System.String>
	# REQUIRED
	o365AppId = <System.String>
}
"@
    Write-Message "Invoke-RscMutateO365 -UpdateAppAuthStatus" @"
    Update O365 App authentication status to applicable app version.
"@ "[GraphQL: updateO365AppAuthStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -UpdateAppPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -UpdateAppPermissions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -UpdateAppPermissions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	o365AppType = <O365AppType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.O365AppType]) for enum values.
	# REQUIRED
	o365AppId = <System.String>
}
"@
    Write-Message "Invoke-RscMutateO365 -UpdateAppPermissions" @"
    Update O365 Azure app permission in Azure AD portal.
"@ "[GraphQL: updateO365AppPermissions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -DeleteAzureApp
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -DeleteAzureApp -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -DeleteAzureApp -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.o365AppClientId = <System.String>
# REQUIRED
$inputs.Var.o365AppType = <System.String>
"@
    Write-Message "Invoke-RscMutateO365 -DeleteAzureApp" @"
    Deletes an O365 Azure AD App from the account.
"@ "[GraphQL: deleteO365AzureApp]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -BackupMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -BackupMailbox -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -BackupMailbox -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.mailboxIds = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscMutateO365 -BackupMailbox" @"
    Backup mailbox workload.
"@ "[GraphQL: backupO365Mailbox]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -BackupOnedrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -BackupOnedrive -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -BackupOnedrive -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}
"@
    Write-Message "Invoke-RscMutateO365 -BackupOnedrive" @"
    Take on-demand snapshot for Onedrive.
"@ "[GraphQL: backupO365Onedrive]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -BackupSharepointDrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -BackupSharepointDrive -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -BackupSharepointDrive -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}
"@
    Write-Message "Invoke-RscMutateO365 -BackupSharepointDrive" @"
    Take on-demand snapshot for Sharepoint drive.
"@ "[GraphQL: backupO365SharepointDrive]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -BackupSharepointList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -BackupSharepointList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -BackupSharepointList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuid = <System.String>
}
"@
    Write-Message "Invoke-RscMutateO365 -BackupSharepointList" @"
    Take on-demand snapshot for SharePoint list.
"@ "[GraphQL: backupO365SharepointList]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -BackupSharePointSite
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -BackupSharePointSite -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -BackupSharePointSite -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	siteFid = <System.String>
}
"@
    Write-Message "Invoke-RscMutateO365 -BackupSharePointSite" @"
    Take on-demand snapshot for a SharePoint site.
"@ "[GraphQL: backupO365SharePointSite]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -BackupTeam
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -BackupTeam -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -BackupTeam -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snappableUuids = @(
		<System.String>
	)
}
"@
    Write-Message "Invoke-RscMutateO365 -BackupTeam" @"
    Take on-demand snapshot for Teams.
"@ "[GraphQL: backupO365Team]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -RestoreTeamsFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -RestoreTeamsFiles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -RestoreTeamsFiles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -RestoreTeamsFiles" @"
    Restore Team files.
"@ "[GraphQL: restoreO365TeamsFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -RestoreTeamsConversations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -RestoreTeamsConversations -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -RestoreTeamsConversations -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -RestoreTeamsConversations" @"
    Restore Team conversations.
"@ "[GraphQL: restoreO365TeamsConversations]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -RestoreSnappable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -RestoreSnappable -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -RestoreSnappable -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -RestoreSnappable" @"
    Restores an O365 snappable.
"@ "[GraphQL: restoreO365Snappable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -RefreshOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -RefreshOrg -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -RefreshOrg -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "Invoke-RscMutateO365 -RefreshOrg" @"
    Refreshes an O365 org.
"@ "[GraphQL: refreshO365Org]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -DeleteOrg
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -DeleteOrg -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -DeleteOrg -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "Invoke-RscMutateO365 -DeleteOrg" @"
    Deletes an O365 org from the account.
"@ "[GraphQL: deleteO365Org]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -RestoreMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -RestoreMailbox -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -RestoreMailbox -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -RestoreMailbox" @"
    Restores an Exchange mailbox.
"@ "[GraphQL: restoreO365Mailbox]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -ExportMailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -ExportMailbox -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -ExportMailbox -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateO365 -ExportMailbox" @"
    Exports an Exchange mailbox.
"@ "[GraphQL: exportO365Mailbox]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -SetServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -SetServiceAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -SetServiceAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.username = <System.String>
# REQUIRED
$inputs.Var.appPassword = <System.String>
# REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "Invoke-RscMutateO365 -SetServiceAccount" @"
    Sets the service account for the org.
"@ "[GraphQL: setO365ServiceAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -EnableSharePoint
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -EnableSharePoint -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -EnableSharePoint -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	exocomputeClusterId = <System.String>
}
"@
    Write-Message "Invoke-RscMutateO365 -EnableSharePoint" @"
    Enables SharePoint protection in the exocompute cluster.
"@ "[GraphQL: enableO365SharePoint]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -EnableTeams
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -EnableTeams -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -EnableTeams -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.exocomputeClusterId = <System.String>
"@
    Write-Message "Invoke-RscMutateO365 -EnableTeams" @"
    Enables Teams protection in the exocompute cluster.
"@ "[GraphQL: enableO365Teams]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -DeleteServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -DeleteServiceAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -DeleteServiceAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "Invoke-RscMutateO365 -DeleteServiceAccount" @"
    Deletes the service account for an org.
"@ "[GraphQL: deleteO365ServiceAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateO365 -UpdateOrgCustomName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateO365 -UpdateOrgCustomName -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateO365 -UpdateOrgCustomName -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	orgUuid = <System.String>
	# REQUIRED
	customName = <System.String>
}
"@
    Write-Message "Invoke-RscMutateO365 -UpdateOrgCustomName" @"
    Update the custom name for an O365 Organization.
"@ "[GraphQL: updateO365OrgCustomName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateOracle -BulkUpdateHosts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -BulkUpdateHosts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -BulkUpdateHosts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -BulkUpdateHosts" @"
    Update Oracle Hosts

Supported in v5.2+
Update properties to Oracle Host objects.
"@ "[GraphQL: bulkUpdateOracleHosts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -RefreshDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -RefreshDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -RefreshDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateOracle -RefreshDatabase" @"
    Refresh an Oracle database

Supported in v6.0+
Starts an asynchronous job to refresh the Oracle database metadata by querying the database instances on all the underlying hosts.
"@ "[GraphQL: refreshOracleDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -UpdateDataGuardGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -UpdateDataGuardGroup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -UpdateDataGuardGroup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -UpdateDataGuardGroup" @"
    Update an Oracle Data Guard group

Supported in v6.0+
Update properties of an Oracle Data Guard group object.
"@ "[GraphQL: updateOracleDataGuardGroup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -DeleteAllDatabaseSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -DeleteAllDatabaseSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -DeleteAllDatabaseSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateOracle -DeleteAllDatabaseSnapshots" @"
    Delete Oracle database snapshots

Supported in v5.0+
Delete all snapshots for a specified Oracle database object. For the operation to succeed the referenced database must not be assigned to an SLA Domain.
"@ "[GraphQL: deleteAllOracleDatabaseSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -TakeOnDemandDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -TakeOnDemandDatabaseSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -TakeOnDemandDatabaseSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -TakeOnDemandDatabaseSnapshot" @"
    On-demand backup of an Oracle database

Supported in v5.0+
Create an asynchronous job for an on-demand snapshot of an Oracle database. The response includes an ID for the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
"@ "[GraphQL: takeOnDemandOracleDatabaseSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -TakeOnDemandLogSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -TakeOnDemandLogSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -TakeOnDemandLogSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateOracle -TakeOnDemandLogSnapshot" @"
    On-demand log backup for an Oracle database log

Supported in v5.0+
Create an asynchronous job for an on-demand backup of an Oracle database log. The response includes an ID for the asynchronous job request.  To see the status of the request, poll /oracle/request/{id}.
"@ "[GraphQL: takeOnDemandOracleLogSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -BulkUpdateRacs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -BulkUpdateRacs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -BulkUpdateRacs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -BulkUpdateRacs" @"
    Update Oracle RACs

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle RAC.
"@ "[GraphQL: bulkUpdateOracleRacs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -ExportTablespace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -ExportTablespace -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -ExportTablespace -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -ExportTablespace" @"
    Export an Oracle tablespace

Supported in v5.0+
Request an asynchronous job to export an Oracle tablespace from a specified snapshot or timestamp.
"@ "[GraphQL: exportOracleTablespace]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -ValidateAcoFile
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -ValidateAcoFile -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -ValidateAcoFile -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -ValidateAcoFile" @"
    Validate Oracle ACO file

Supported in v6.0+
Validate the provided Oracle ACO (Advanced Cloning Options) file.
"@ "[GraphQL: validateOracleAcoFile]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -ValidateDatabaseBackups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -ValidateDatabaseBackups -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -ValidateDatabaseBackups -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -ValidateDatabaseBackups" @"
    Validate Oracle database backups

Supported in v5.3+
Queue a job to validate Oracle backups for a database snapshot or a specified timestamp.
"@ "[GraphQL: validateOracleDatabaseBackups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -BulkUpdateDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -BulkUpdateDatabases -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -BulkUpdateDatabases -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -BulkUpdateDatabases" @"
    Update Oracle Databases

Supported in v5.2+
Update the properties of the objects that represent the specified Oracle Databases.
"@ "[GraphQL: bulkUpdateOracleDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -InstantRecoverSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -InstantRecoverSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -InstantRecoverSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -InstantRecoverSnapshot" @"
    Instant recovery of a database

Supported in v5.0+
Creates an instant recover request that restores a target database from the given snapshot.
"@ "[GraphQL: instantRecoverOracleSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -MountDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -MountDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -MountDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -MountDatabase" @"
    Live Mount an Oracle database snapshot

Supported in v5.0+
Create an asynchronous job to Live Mount an Oracle database from a snapshot.
"@ "[GraphQL: mountOracleDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -ExportDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -ExportDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -ExportDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -ExportDatabase" @"
    Export an Oracle database

Supported in v5.0+
Request an asynchronous job to export an Oracle database from a specified snapshot or timestamp.
"@ "[GraphQL: exportOracleDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -CreatePdbRestore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -CreatePdbRestore -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -CreatePdbRestore -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -CreatePdbRestore" @"
    Restore PDBs on an Oracle database

Supported in v8.0+
Initiates an asynchronous request to restore PDBs on an Oracle database from a specified snapshot or timestamp.
"@ "[GraphQL: createOraclePdbRestore]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -DownloadDatabaseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -DownloadDatabaseSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -DownloadDatabaseSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	snapshotId = <System.String>
}
"@
    Write-Message "Invoke-RscMutateOracle -DownloadDatabaseSnapshot" @"
    Download Oracle snapshot from cloud

Supported in v5.0+
Create an asynchronous job to download an Oracle database snapshot and associated logs using the snapshot ID. The response includes the ID of the asynchronous job request. To see the status of the request, poll /oracle/request/{id}.
"@ "[GraphQL: downloadOracleDatabaseSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -DeleteMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -DeleteMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -DeleteMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateOracle -DeleteMount" @"
    Delete an Oracle database Live Mount

Supported in v5.0+
Request an asynchronous job to delete a specified Live Mount of an Oracle database snapshot. Poll the job status by using /oracle/request/{id}.
"@ "[GraphQL: deleteOracleMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateOracle -RestoreLogs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateOracle -RestoreLogs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateOracle -RestoreLogs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateOracle -RestoreLogs" @"
    Restore archive logs of an Oracle database

Supported in v6.0+
v6.0: Create an asynchronous job to restore archive logs of an Oracle database.
v7.0+: Starts an asynchronous job to restore archive logs of an Oracle database.
"@ "[GraphQL: restoreOracleLogs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateSla -CreateGlobal
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -CreateGlobal -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -CreateGlobal -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -CreateGlobal" @"
    Create SLA Domain.
"@ "[GraphQL: createGlobalSla]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateSla -UpdateGlobal
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -UpdateGlobal -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -UpdateGlobal -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -UpdateGlobal" @"
    Update SLA Domain.
"@ "[GraphQL: updateGlobalSla]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateSla -Assign
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -Assign -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -Assign -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -Assign" @"
    Endpoint to assign SLA Domain.
"@ "[GraphQL: assignSla]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateSla -AssignsForSnappableHierarchies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -AssignsForSnappableHierarchies -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -AssignsForSnappableHierarchies -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -AssignsForSnappableHierarchies" @"
    Assign SLA Domain to workloads with multiple hierarchies.
"@ "[GraphQL: assignSlasForSnappableHierarchies]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateSla -AssignRetentionToSnappables
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -AssignRetentionToSnappables -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -AssignRetentionToSnappables -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -AssignRetentionToSnappables" @"
    Endpoint to assign retention SLA Domain to workloads.
"@ "[GraphQL: assignRetentionSLAToSnappables]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateSla -AssignRetentionToSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -AssignRetentionToSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -AssignRetentionToSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -AssignRetentionToSnapshots" @"
    Endpoint to assign retention SLA Domain to snapshots.
"@ "[GraphQL: assignRetentionSLAToSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateSla -Pause
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -Pause -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -Pause -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -Pause" @"
    Pause or resume SLA Domain on the given Rubrik clusters.
"@ "[GraphQL: pauseSla]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateSla -GetPendingAssignments
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -GetPendingAssignments -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -GetPendingAssignments -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -GetPendingAssignments" @"
    Get pending SLA Domain assignments on selected managed objects

Supported in v5.2+
Retrieve the details of pending SLA Domain assignments on the given managed objects. For objects with pending assignments, return the SLA Domain that is pending. For objects without pending assignments, return the current SLA Domain information. Explicitly list invalid object IDs.
"@ "[GraphQL: getPendingSlaAssignments]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateSla -ExportManagedVolumeSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateSla -ExportManagedVolumeSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateSla -ExportManagedVolumeSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateSla -ExportManagedVolumeSnapshot" @"
    Create a request to export a snapshot and mount it on a host

Supported in v5.3+
Export a managed volume snapshot as a share and mount it on a given host.
"@ "[GraphQL: exportSlaManagedVolumeSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateVcenter -Create
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVcenter -Create -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVcenter -Create -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVcenter -Create" @"
    Add a vCenter server.
"@ "[GraphQL: createVsphereVcenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVcenter -Delete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVcenter -Delete -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVcenter -Delete -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateVcenter -Delete" @"
    Remove vCenter Server

Supported in v5.0+
Initiates an asynchronous job to remove a vCenter Server object. The vCenter Server cannot have VMs mounted through the Rubrik cluster.
"@ "[GraphQL: vsphereDeleteVcenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVcenter -Refresh
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVcenter -Refresh -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVcenter -Refresh -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	fid = <System.String>
	# OPTIONAL
	shouldDiagnose = <System.Boolean>
}
"@
    Write-Message "Invoke-RscMutateVcenter -Refresh" @"
    Refresh vCenter Server metadata

Supported in v5.0+
Create a job to refresh the metadata for the specified vCenter Server.
"@ "[GraphQL: refreshVsphereVcenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVcenter -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVcenter -Update -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVcenter -Update -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVcenter -Update" @"
    Update vCenter Server

Supported in v5.0+
Update the address, username and password of the specified vCenter Server object.
"@ "[GraphQL: updateVcenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVcenter -UpdateHotAddNetwork
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVcenter -UpdateHotAddNetwork -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVcenter -UpdateHotAddNetwork -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVcenter -UpdateHotAddNetwork" @"
    Set the user-configured network for HotAdd backup and recovery

Supported in v5.3+
Set the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
"@ "[GraphQL: updateVcenterHotAddNetwork]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVcenter -UpdateHotAddBandwidth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVcenter -UpdateHotAddBandwidth -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVcenter -UpdateHotAddBandwidth -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVcenter -UpdateHotAddBandwidth" @"
    Set the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Set the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
"@ "[GraphQL: updateVcenterHotAddBandwidth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateVsphere -OnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphere -OnDemandSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphere -OnDemandSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphere -OnDemandSnapshot" @"
    
"@ "[GraphQL: vsphereOnDemandSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphere -BulkOnDemandSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphere -BulkOnDemandSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphere -BulkOnDemandSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphere -BulkOnDemandSnapshot" @"
    Trigger a bulk on demand snapshot.
"@ "[GraphQL: vsphereBulkOnDemandSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphere -DeleteLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphere -DeleteLiveMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphere -DeleteLiveMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	force = <System.Boolean>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateVsphere -DeleteLiveMount" @"
    Delete a Live Mount VM

Supported in v5.0+
Create a request to delete a Live Mount virtual machine.
"@ "[GraphQL: deleteVsphereLiveMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphere -ExportSnapshotToStandaloneHostV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphere -ExportSnapshotToStandaloneHostV2 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphere -ExportSnapshotToStandaloneHostV2 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphere -ExportSnapshotToStandaloneHostV2" @"
    Export snapshot of a virtual machine to standalone ESXi server.
"@ "[GraphQL: vsphereExportSnapshotToStandaloneHostV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphere -DownloadVirtualMachineFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphere -DownloadVirtualMachineFiles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphere -DownloadVirtualMachineFiles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphere -DownloadVirtualMachineFiles" @"
    Download Virtual Machine files from a snapshot

Supported in v9.0+
Start an asynchronous job to download multiple Virtual Machine files, such as .vmdk, .vmx, and .nvram files, from the specified Virtual Machine snapshot.
"@ "[GraphQL: downloadVsphereVirtualMachineFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphere -CreateAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphere -CreateAdvancedTag -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphere -CreateAdvancedTag -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphere -CreateAdvancedTag" @"
    Create a multi-tag filter for vSphere tags

Supported in v7.0+
Create a filter consisting of vSphere tags joined with logical operators.
"@ "[GraphQL: createVsphereAdvancedTag]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphere -DeleteAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphere -DeleteAdvancedTag -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphere -DeleteAdvancedTag -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	filterId = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateVsphere -DeleteAdvancedTag" @"
    Remove the multi-tag filter

Supported in v7.0+
Remove the multi-tag filter.
"@ "[GraphQL: deleteVsphereAdvancedTag]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphere -UpdateAdvancedTag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphere -UpdateAdvancedTag -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphere -UpdateAdvancedTag -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphere -UpdateAdvancedTag" @"
    Update the multi-tag filter

Supported in v7.0+
Updates the name, condition, and description of the specified multi-tag filter.
"@ "[GraphQL: updateVsphereAdvancedTag]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -RecoverFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -RecoverFiles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -RecoverFiles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -RecoverFiles" @"
    Restores multiple files/directories from snapshot.
"@ "[GraphQL: vsphereVmRecoverFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -RecoverFilesNew
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -RecoverFilesNew -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -RecoverFilesNew -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -RecoverFilesNew" @"
    Restores multiple files/directories from snapshot.
"@ "[GraphQL: vsphereVmRecoverFilesNew]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -RegisterAgent
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -RegisterAgent -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -RegisterAgent -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateVsphereVm -RegisterAgent" @"
    Register Rubrik Backup Service

Supported in v5.0+
Register the Rubrik Backup Service that is running on a specified host with the specified Rubrik cluster.
"@ "[GraphQL: vsphereVmRegisterAgent]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -DownloadSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -DownloadSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -DownloadSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateVsphereVm -DownloadSnapshot" @"
    Download snapshot from archive

Supported in v5.0+
Provides a method for retrieving a snapshot, that is not available locally, from an archival location.
"@ "[GraphQL: vsphereVmDownloadSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -ExportSnapshotV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -ExportSnapshotV2 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -ExportSnapshotV2 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -ExportSnapshotV2" @"
    Create a vSphere Export from a snapshot or a point-in-time.
"@ "[GraphQL: vsphereVmExportSnapshotV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -ExportSnapshotV3
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -ExportSnapshotV3 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -ExportSnapshotV3 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -ExportSnapshotV3" @"
    Create a vSphere Export from a snapshot or a point-in-time with datastore cluster and virtual disk mapping support.
"@ "[GraphQL: vsphereVmExportSnapshotV3]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -BatchExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -BatchExport -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -BatchExport -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -BatchExport" @"
    Create a mass export for a group of virtual machines.
"@ "[GraphQL: vsphereVmBatchExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -BatchExportV3
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -BatchExportV3 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -BatchExportV3 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -BatchExportV3" @"
    Create a batch export for a group of virtual machines with datastore cluster support.
"@ "[GraphQL: vsphereVmBatchExportV3]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -InitiateInPlaceRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -InitiateInPlaceRecovery -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -InitiateInPlaceRecovery -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -InitiateInPlaceRecovery" @"
    Trigger an in-place recovery from a snapshot or point-in-time.
"@ "[GraphQL: vsphereVmInitiateInPlaceRecovery]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -ExportSnapshotWithDownloadFromCloud
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -ExportSnapshotWithDownloadFromCloud -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -ExportSnapshotWithDownloadFromCloud -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -ExportSnapshotWithDownloadFromCloud" @"
    Download a snapshot from an archival location, then export a virtual machine using the downloaded snapshot

Supported in v5.3+
Download a snapshot from an archival location and then export a virtual machine using the downloaded snapshot.
"@ "[GraphQL: vsphereVmExportSnapshotWithDownloadFromCloud]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -BatchInPlaceRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -BatchInPlaceRecovery -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -BatchInPlaceRecovery -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -BatchInPlaceRecovery" @"
    Supported in v6.0+. Export a snapshot each from a set of virtual machines.
"@ "[GraphQL: vsphereVmBatchInPlaceRecovery]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -DeleteSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -DeleteSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -DeleteSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	location = <DeleteVmwareSnapshotRequestLocation> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DeleteVmwareSnapshotRequestLocation]) for enum values.
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscMutateVsphereVm -DeleteSnapshot" @"
    Designate a snapshot as expired and available for garbage collection. The snapshot must be an on-demand snapshot or a snapshot from a virtual machine that is not assigned to an SLA Domain.
"@ "[GraphQL: vsphereVmDeleteSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -InitiateInstantRecoveryV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -InitiateInstantRecoveryV2 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -InitiateInstantRecoveryV2 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -InitiateInstantRecoveryV2" @"
    Instantly recover a vSphere virtual machine from a snapshot or point-in-time.
"@ "[GraphQL: vsphereVmInitiateInstantRecoveryV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -InitiateBatchInstantRecovery
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -InitiateBatchInstantRecovery -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -InitiateBatchInstantRecovery -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -InitiateBatchInstantRecovery" @"
    Initiate a mass instant recovery for a group of VMs.
"@ "[GraphQL: vsphereVmInitiateBatchInstantRecovery]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -InitiateDiskMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -InitiateDiskMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -InitiateDiskMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -InitiateDiskMount" @"
    Attaching disks from a snapshot to an existing virtual machine

Supported in v5.0+
Requests a snapshot mount to attach disks to an existing virtual machine.
"@ "[GraphQL: vsphereVmInitiateDiskMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -InitiateLiveMountV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -InitiateLiveMountV2 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -InitiateLiveMountV2 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -InitiateLiveMountV2" @"
    Create a vSphere Live Mount from a snapshot or point-in-time.
"@ "[GraphQL: vsphereVmInitiateLiveMountV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -InitiateBatchLiveMountV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -InitiateBatchLiveMountV2 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -InitiateBatchLiveMountV2 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -InitiateBatchLiveMountV2" @"
    Initiate a mass live mount for a group of VMs.
"@ "[GraphQL: vsphereVmInitiateBatchLiveMountV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -PowerOnOffLiveMount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -PowerOnOffLiveMount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -PowerOnOffLiveMount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -PowerOnOffLiveMount" @"
    Power a Live Mount on and off

Supported in v5.0+
Power a specified Live Mount virtual machine on or off. Pass **_true_** to power the virtual machine on and pass **_false_** to power the virtual machine off.
"@ "[GraphQL: vsphereVmPowerOnOffLiveMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -ListEsxiDatastores
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -ListEsxiDatastores -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -ListEsxiDatastores -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -ListEsxiDatastores" @"
    List ESXi datastores

Supported in v5.0+
Retrieve a list of the datastores for a specified ESXi host.
"@ "[GraphQL: vsphereVmListEsxiDatastores]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -MountRelocate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -MountRelocate -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -MountRelocate -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -MountRelocate" @"
    Relocate a virtual machine to another datastore

Supported in v5.0+
Run storage VMotion to relocate a specified Live Mount into another data store.
"@ "[GraphQL: vsphereVmMountRelocate]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -MountRelocateV2
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -MountRelocateV2 -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -MountRelocateV2 -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -MountRelocateV2" @"
    Create a Live Mount migration to a datastore or datastore cluster with virtual disk mapping support.
"@ "[GraphQL: vsphereVmMountRelocateV2]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -ExcludeVmDisks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -ExcludeVmDisks -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -ExcludeVmDisks -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -ExcludeVmDisks" @"
    Exclude or include virtual disks during snapshot.
"@ "[GraphQL: vsphereExcludeVmDisks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -DownloadSnapshotFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -DownloadSnapshotFiles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -DownloadSnapshotFiles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -DownloadSnapshotFiles" @"
    Download files from snapshot.
"@ "[GraphQL: vsphereVmDownloadSnapshotFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscMutateVsphereVm -Update
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscMutateVsphereVm -Update -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscMutateVsphereVm -Update -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscMutateVsphereVm -Update" @"
    Update VM

Supported in v5.0+
Update a virtual machine with specified properties. Use the guestCredential field to update the guest credential for a specified virtual machine.
"@ "[GraphQL: updateVsphereVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryAccount -Settings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAccount -Settings -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAccount -Settings -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryAccount -Settings" @"
    This endpoint is deprecated.
"@ "[GraphQL: accountSettings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAccount -SWithExocomputeMappings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAccount -SWithExocomputeMappings -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAccount -SWithExocomputeMappings -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAccount -SWithExocomputeMappings" @"
    Retrieves the list of all accounts with their Exocompute account mapping, if exists.
"@ "[GraphQL: allAccountsWithExocomputeMappings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAccount -Products
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAccount -Products -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAccount -Products -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAccount -Products" @"
    
"@ "[GraphQL: allAccountProducts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAccount -Id
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAccount -Id -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAccount -Id -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryAccount -Id" @"
    Account ID.
"@ "[GraphQL: accountId]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAccount -Owners
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAccount -Owners -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAccount -Owners -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryAccount -Owners" @"
    List of account owners.
"@ "[GraphQL: allAccountOwners]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryActivitySeries -ActivitySeries
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryActivitySeries -ActivitySeries -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryActivitySeries -ActivitySeries -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	activitySeriesId = <System.String>
	# OPTIONAL
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscQueryActivitySeries -ActivitySeries" @"
    Retrieve an activity series.
"@ "[GraphQL: activitySeries]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryActivitySeries -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryActivitySeries -List -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryActivitySeries -List -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryActivitySeries -List" @"
    
"@ "[GraphQL: activitySeriesConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeRoot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeRoot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeRoot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryAws -NativeRoot" @"
    Root of AWS native hierarchy.
"@ "[GraphQL: awsNativeRoot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsNativeAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.awsNativeProtectionFeature = <AwsNativeProtectionFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
"@
    Write-Message "Invoke-RscQueryAws -NativeAccount" @"
    Refers to the AWS Native account that serves as a container for all your AWS resources. The AWS Native account contains information about the metadata related to the AWS Native resources.
"@ "[GraphQL: awsNativeAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeEc2Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeEc2Instance -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeEc2Instance -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.ec2InstanceRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -NativeEc2Instance" @"
    Refers to Amazon Elastic Compute Cloud (EC2) Instance represented by a specific ID. For more information, see https://aws.amazon.com/ec2/.
"@ "[GraphQL: awsNativeEc2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeEbsVolume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeEbsVolume -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeEbsVolume -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.ebsVolumeRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -NativeEbsVolume" @"
    Refers to the Amazon Elastic Block Store (EBS) Volume represented by a specific ID. For more information, see https://aws.amazon.com/ebs/.
"@ "[GraphQL: awsNativeEbsVolume]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeS3Bucket
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeS3Bucket -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeS3Bucket -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.s3BucketRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -NativeS3Bucket" @"
    Represents the Amazon S3 Bucket with a specific ID. For more information, see https://aws.amazon.com/s3/.
"@ "[GraphQL: awsNativeS3Bucket]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeAccounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeAccounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -NativeAccounts" @"
    Paginated list of all AWS Native accounts.
"@ "[GraphQL: awsNativeAccounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeEc2InstancesByName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeEc2InstancesByName -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeEc2InstancesByName -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -NativeEc2InstancesByName" @"
    Paginated list of all AWS EC2 Instances by name or substring of name.
"@ "[GraphQL: awsNativeEc2InstancesByName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeEc2Instances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeEc2Instances -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeEc2Instances -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -NativeEc2Instances" @"
    Paginated list of all AWS EC2 Instances.
"@ "[GraphQL: awsNativeEc2Instances]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeEbsVolumesByName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeEbsVolumesByName -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeEbsVolumesByName -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -NativeEbsVolumesByName" @"
    Paginated list of all AWS EBS Volumes by name or substring of name.
"@ "[GraphQL: awsNativeEbsVolumesByName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeEbsVolumes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeEbsVolumes -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeEbsVolumes -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -NativeEbsVolumes" @"
    Paginated list of all AWS EBS Volumes.
"@ "[GraphQL: awsNativeEbsVolumes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllVpcsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllVpcsByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllVpcsByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAws -AllVpcsByRegion" @"
    List of all Virtual Private Clouds (VPCs) in the AWS Native account, classified by region.
"@ "[GraphQL: allVpcsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllVpcs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllVpcs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllVpcs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.awsAccountRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -AllVpcs" @"
    List of all Virtual Private Clouds (VPCs) in the AWS Native account.
"@ "[GraphQL: allVpcsFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snapshotId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -IsNativeEbsVolumeSnapshotRestorable" @"
    Specified whether an EBS volume is restorable. For an EBS Volume to be restorable, the volume should be able to replace where attached.
"@ "[GraphQL: isAwsNativeEbsVolumeSnapshotRestorable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllAvailabilityZonesByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllAvailabilityZonesByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllAvailabilityZonesByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAws -AllAvailabilityZonesByRegion" @"
    List of Availability Zones (AZs) in the specified region on the specified AWS Native account.
"@ "[GraphQL: allAvailabilityZonesByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllKmsEncryptionKeysByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllKmsEncryptionKeysByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllKmsEncryptionKeysByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAws -AllKmsEncryptionKeysByRegion" @"
    List of encryption keys in the specified region on the specified AWS Native account. All the encrytion keys listed are managed by AWS Key Management System (KMS). For more information, see https://aws.amazon.com/kms/.
"@ "[GraphQL: allKmsEncryptionKeysByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -IsS3BucketNameAvailable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -IsS3BucketNameAvailable -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -IsS3BucketNameAvailable -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.bucketName = <System.String>
# REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -IsS3BucketNameAvailable" @"
    Specifies whether an S3 bucket name is available for use in AWS or not. When true, the bucket name is available for use.
"@ "[GraphQL: isAwsS3BucketNameAvailable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllS3Buckets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllS3Buckets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllS3Buckets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -AllS3Buckets" @"
    List of all S3 bucket names across regions for the AWS Native account.
"@ "[GraphQL: allS3BucketsFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllS3BucketsDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllS3BucketsDetails -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllS3BucketsDetails -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# OPTIONAL
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAws -AllS3BucketsDetails" @"
    List of all S3 bucket details across regions for the AWS Native account.
"@ "[GraphQL: allS3BucketsDetailsFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeRdsInstance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeRdsInstance -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeRdsInstance -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.rdsInstanceRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -NativeRdsInstance" @"
    Refers to AWS Relational Database Service (RDS) represented by a specific ID. For more information, see https://aws.amazon.com/rds/.
"@ "[GraphQL: awsNativeRdsInstance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeRdsInstances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeRdsInstances -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeRdsInstances -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -NativeRdsInstances" @"
    Paginated list of AWS RDS Instances on AWS Native account.
"@ "[GraphQL: awsNativeRdsInstances]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeRdsPointInTimeRestoreWindow
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeRdsPointInTimeRestoreWindow -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeRdsPointInTimeRestoreWindow -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -NativeRdsPointInTimeRestoreWindow" @"
    Point-in-Time (PiT) restore window of the RDS Instance in the AWS Native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information,see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PIT.html.
"@ "[GraphQL: awsNativeRdsPointInTimeRestoreWindow]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -RdsInstanceDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -RdsInstanceDetails -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -RdsInstanceDetails -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -RdsInstanceDetails" @"
    Details of the RDS Instance in the AWS Native account.
"@ "[GraphQL: rdsInstanceDetailsFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -IsNativeRdsInstanceLaunchConfigurationValid" @"
    Specifies whether the given DbInstance class, storage type, multi-az capability, encryption capability, iops value are supported for the given dbEngine, dbEngineVersion in the specified availability zone. When true, the specification is valid for a RDS Instance and can be used to create a new Instance.
"@ "[GraphQL: isAwsNativeRdsInstanceLaunchConfigurationValid]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllOptionGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllOptionGroupsByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllOptionGroupsByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -AllOptionGroupsByRegion" @"
    List of all RDS option groups in a given region. Refers to settings of how a particular option works for an RDS Instance. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
"@ "[GraphQL: allOptionGroupsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllDbParameterGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllDbParameterGroupsByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllDbParameterGroupsByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -AllDbParameterGroupsByRegion" @"
    List of all DB parameter groups in a given region. Refers to container for engine configuration that applies to one or more DB Instances. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_WorkingWithOptionGroups.html.
"@ "[GraphQL: allDbParameterGroupsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllDbSubnetGroupsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllDbSubnetGroupsByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllDbSubnetGroupsByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAws -AllDbSubnetGroupsByRegion" @"
    All DB subnet groups in a given region. Refers to logical isolation of RDS on a network. For more information, see https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_VPC.WorkingWithRDSInstanceinaVPC.html.
"@ "[GraphQL: allDbSubnetGroupsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -ValidateNativeRdsInstanceNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -ValidateNativeRdsInstanceNameForExport -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -ValidateNativeRdsInstanceNameForExport -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsInstanceName = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -ValidateNativeRdsInstanceNameForExport" @"
    Validates the name used for an RDS Instance during an export operation. Returns true if the RDS Instance name is valid. Returns false, with an error message, if the RDS Instance name validation fails. Returns false, without an error message for all other failures.
"@ "[GraphQL: validateAwsNativeRdsInstanceNameForExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -ValidateNativeRdsClusterNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -ValidateNativeRdsClusterNameForExport -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -ValidateNativeRdsClusterNameForExport -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.rdsClusterName = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -ValidateNativeRdsClusterNameForExport" @"
    Validates the name used for an RDS cluster during an export operation. Returns true if the RDS cluster name is valid. Returns false, with an error message, if the RDS cluster name validation fails. Returns false, without an error message for all other failures.
"@ "[GraphQL: validateAwsNativeRdsClusterNameForExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -NativeRdsExportDefaults
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -NativeRdsExportDefaults -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -NativeRdsExportDefaults -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.rdsInstanceRubrikId = <System.String>
# OPTIONAL
$inputs.Var.snapshotId = <System.String>
# REQUIRED
$inputs.Var.isPointInTime = <System.Boolean>
"@
    Write-Message "Invoke-RscQueryAws -NativeRdsExportDefaults" @"
    Refers to the default values for the export operation of the RDS DB Instance in the AWS Native account.
"@ "[GraphQL: awsNativeRdsExportDefaults]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllEc2KeyPairsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllEc2KeyPairsByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllEc2KeyPairsByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsAccountRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AwsNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAws -AllEc2KeyPairsByRegion" @"
    List of all key pairs for a given region. A key pair, consisting of a public key and a private key, is a set of security credentials that you use to prove your identity when connecting to an EC2 instance. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html.
"@ "[GraphQL: allEc2KeyPairsByRegionFromAws]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -AmiTypeForNativeArchivedSnapshotExport" @"
    Amazon Machine Image (AMI) type for export of an archived EC2 Instance snapshot. For more information, see https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instances-and-amis.html.
"@ "[GraphQL: amiTypeForAwsNativeArchivedSnapshotExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -AllSupportedRdsDatabaseInstanceClasses" @"
    List of all the database instance classes supported by AWS RDS database for the provided DB engine and engine version. DB engine version is a optional argument, it can be ignored if we want to retrieve all the supported instance class for a DB engine irrespective of DB engine version.
"@ "[GraphQL: allSupportedAwsRdsDatabaseInstanceClasses]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -ComputeSettings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -ComputeSettings -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -ComputeSettings -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.computeSettingId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -ComputeSettings" @"
    Retrieve aws compute settings.
"@ "[GraphQL: awsComputeSettings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllComputeSettings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllComputeSettings -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllComputeSettings -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -AllComputeSettings" @"
    List all aws compute settings.
"@ "[GraphQL: allAwsComputeSettings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllCloudAccountsWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllCloudAccountsWithFeatures -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllCloudAccountsWithFeatures -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -AllCloudAccountsWithFeatures" @"
    List of active AWS cloud accounts and the features for the accounts. A cloud account is an AWS account added to the Rubrik platform.
"@ "[GraphQL: allAwsCloudAccountsWithFeatures]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -CloudAccountWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -CloudAccountWithFeatures -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -CloudAccountWithFeatures -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -CloudAccountWithFeatures" @"
    List of AWS cloud accounts and the features for each account, classified by ID.
"@ "[GraphQL: awsCloudAccountWithFeatures]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -CloudAccountListVpcs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -CloudAccountListVpcs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -CloudAccountListVpcs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountUuid = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.region = <AwsRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAws -CloudAccountListVpcs" @"
    Retrieves a list of virtual private clouds (VPCs) in the specific cloud account.
"@ "[GraphQL: awsCloudAccountListVpcs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -CloudAccountListSubnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -CloudAccountListSubnets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -CloudAccountListSubnets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -CloudAccountListSubnets" @"
    Retrieves a list of subnets in the specified cloud account and virtual private cloud (VPC).
"@ "[GraphQL: awsCloudAccountListSubnets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -CloudAccountListSecurityGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -CloudAccountListSecurityGroups -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -CloudAccountListSecurityGroups -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -CloudAccountListSecurityGroups" @"
    Retrieves a list of security groups in the specified cloud account and virtual private cloud (VPC).
"@ "[GraphQL: awsCloudAccountListSecurityGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllExocomputeConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllExocomputeConfigs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllExocomputeConfigs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.awsNativeAccountIdOrNamePrefix = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -AllExocomputeConfigs" @"
    List of all AWS exocompute configurations filtered by a cloud account ID or a cloud account name prefix.
"@ "[GraphQL: allAwsExocomputeConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllCloudAccountConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllCloudAccountConfigs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllCloudAccountConfigs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -AllCloudAccountConfigs" @"
    List of all AWS cloud account configurations with the given search query.
"@ "[GraphQL: allAwsCloudAccountConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -TrustPolicy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -TrustPolicy -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -TrustPolicy -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -TrustPolicy" @"
    Retrieves the AWS trust policy that will be attached with each role (cross-account, exocompute, etc.) in the customer's environment.
"@ "[GraphQL: awsTrustPolicy]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllPermissionPolicies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllPermissionPolicies -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllPermissionPolicies -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -AllPermissionPolicies" @"
    Retrieves the permissions policy for all the input features along with any AWS-managed policy ARNs which need to be attached to the roles. Each policy document can be used to create an AWS-managed policy which then needs to be attached to corresponding role.
"@ "[GraphQL: allAwsPermissionPolicies]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -ArtifactsToDelete
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -ArtifactsToDelete -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -ArtifactsToDelete -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAws -ArtifactsToDelete" @"
    Retrieves the AWS artifacts that need to be deleted when an account is being deleted.
"@ "[GraphQL: awsArtifactsToDelete]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllRegions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllRegions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -AllRegions" @"
    All valid AWS regions for this cloud account.
"@ "[GraphQL: allAwsRegions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllCdmVersions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllCdmVersions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllCdmVersions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	region = <System.String>
}
"@
    Write-Message "Invoke-RscQueryAws -AllCdmVersions" @"
    Get all Rubrik CDM versions in the AWS marketplace.
"@ "[GraphQL: allAwsCdmVersions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAws -AllInstanceProfileNames
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAws -AllInstanceProfileNames -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAws -AllInstanceProfileNames -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.region = <System.String>
"@
    Write-Message "Invoke-RscQueryAws -AllInstanceProfileNames" @"
    All Rubrik CC-ES instance profiles in the AWS account.
"@ "[GraphQL: allAwsInstanceProfileNames]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeRoot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeRoot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeRoot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryAzure -NativeRoot" @"
    Root of Azure native hierarchy.
"@ "[GraphQL: azureNativeRoot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeSubscription
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeSubscription -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeSubscription -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -NativeSubscription" @"
    Retrieves an Azure Native Subscription. Refers to the logical entity that provides entitlement to deploy and consume Azure resources.
"@ "[GraphQL: azureNativeSubscription]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeSubscriptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeSubscriptions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeSubscriptions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -NativeSubscriptions" @"
    Retrieves a paginated list of all Azure Native Subscriptions.
"@ "[GraphQL: azureNativeSubscriptions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeResourceGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeResourceGroup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeResourceGroup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.resourceGroupId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -NativeResourceGroup" @"
    Retrieves an Azure Native Resource Group. Refers to a collection of resources in which multiple Azure services can reside.
"@ "[GraphQL: azureNativeResourceGroup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeResourceGroups -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeResourceGroups -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -NativeResourceGroups" @"
    Retrieves a paginated list of all Azure Native Resource Groups.
"@ "[GraphQL: azureNativeResourceGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeVirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeVirtualMachine -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeVirtualMachine -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureVirtualMachineRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -NativeVirtualMachine" @"
    Retrieves an Azure Virtual Machine that refers to the Azure infrastructure as a service (IaaS) used to deploy persistent VMs. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/.
"@ "[GraphQL: azureNativeVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeVirtualMachines
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeVirtualMachines -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeVirtualMachines -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -NativeVirtualMachines" @"
    Retrieves a paginated list of all Azure Virtual Machines (VMs).
"@ "[GraphQL: azureNativeVirtualMachines]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeManagedDisk
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeManagedDisk -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeManagedDisk -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureManagedDiskRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -NativeManagedDisk" @"
    Retrieves an Azure Native Managed Disk that refers to the block storage designed to be used with Azure Virtual Machines. Some examples are: ultra disks, premium solid-state drives (SSD), standard SSDs, and standard hard disk drives (HDD). For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/managed-disks-overview.
"@ "[GraphQL: azureNativeManagedDisk]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -NativeManagedDisks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -NativeManagedDisks -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -NativeManagedDisks -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -NativeManagedDisks" @"
    Retrieves a paginated list of all Azure Native Managed Disks.
"@ "[GraphQL: azureNativeManagedDisks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeVirtualNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeVirtualNetworks -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeVirtualNetworks -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.azureSubscriptionRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -AllNativeVirtualNetworks" @"
    Retrieves all virtual networks (VNets) in the protected subscriptions. VNet enables secure communication with other VNets, the internet, and on-premise networks. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/virtual-networks-overview.
"@ "[GraphQL: allAzureNativeVirtualNetworks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeSubnetsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeSubnetsByRegionFromAzure -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeSubnetsByRegionFromAzure -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -AllNativeSubnetsByRegionFromAzure" @"
    Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.
"@ "[GraphQL: allAzureNativeSubnetsByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -AllNativeSecurityGroupsByRegionFromAzure" @"
    Retrieves all security groups in the specified region and subscription. Security groups enable you to configure network security as a natural extension of an application's structure, allowing you to group virtual machines and define network security policies based on those groups. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/application-security-groups.
"@ "[GraphQL: allAzureNativeSecurityGroupsByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllDiskEncryptionSetsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllDiskEncryptionSetsByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllDiskEncryptionSetsByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -AllDiskEncryptionSetsByRegion" @"
    List of all Azure Disk Encryption Sets in a region.
"@ "[GraphQL: allAzureDiskEncryptionSetsByRegion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.resourceGroupName = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -AllNativeAvailabilitySetsByRegionFromAzure" @"
    Retrieves all availability sets in the specified region, resource group, and subscription. An availability set is a logical grouping of VMs to facilitate redundancy and availability. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/availability-set-overview.
"@ "[GraphQL: allAzureNativeAvailabilitySetsByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
# REQUIRED
$inputs.Var.vmSnapshotId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -AllNativeExportCompatibleVmSizesByRegionFromAzure" @"
    Retrieves all supported virtual machine (VM) sizes when exporting a particular snapshot. Not all VM sizes are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
"@ "[GraphQL: allAzureNativeExportCompatibleVmSizesByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureNativeRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -AllNativeExportCompatibleDiskTypesByRegionFromAzure" @"
    Retrieves all supported disk types when exporting a specific snapshot. Not all disk types are supported in all the regions. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/disks-types.
"@ "[GraphQL: allAzureNativeExportCompatibleDiskTypesByRegionFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeVirtualMachineSizes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeVirtualMachineSizes -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeVirtualMachineSizes -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.azureSubscriptionRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -AllNativeVirtualMachineSizes" @"
    Retrieves all virtual machine (VM) sizes in the subscriptions protected by Rubrik that have been configured for protection. For more information, see https://docs.microsoft.com/en-us/azure/virtual-machines/sizes.
"@ "[GraphQL: allAzureNativeVirtualMachineSizes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.diskSnapshotId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -IsNativeManagedDiskSnapshotRestorable" @"
    Specifies whether the Managed Disk snapshot is restorable or not. A managed disk is restorable when the restore settings of the Managed Disk are configured on the Azure portal and on the Rubrik platform. When the value is true, the managed disk snapshot is restorable.
"@ "[GraphQL: isAzureNativeManagedDiskSnapshotRestorable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -IsStorageAccountNameAvailable
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -IsStorageAccountNameAvailable -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -IsStorageAccountNameAvailable -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
# REQUIRED
$inputs.Var.storageAccountName = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -IsStorageAccountNameAvailable" @"
    Specifies whether the given storage account name is valid and available in Azure to be assigned to a new storage account. When the value is true, the specified account name is available in Azure.
"@ "[GraphQL: isAzureStorageAccountNameAvailable]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeStorageAccountsFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeStorageAccountsFromAzure -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeStorageAccountsFromAzure -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSubscriptionRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -AllNativeStorageAccountsFromAzure" @"
    Retrieves list of all storage Accounts in a subscription.
"@ "[GraphQL: allAzureNativeStorageAccountsFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlDatabaseRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -SqlDatabase" @"
    Retrieves an Azure SQL Database. Refers to the fully managed SQL database built for the cloud. For more information, see https://azure.microsoft.com/en-us/products/azure-sql/database/.
"@ "[GraphQL: azureSqlDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlDatabases -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlDatabases -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -SqlDatabases" @"
    Retrieves a paginated list of all Azure SQL Databases.
"@ "[GraphQL: azureSqlDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlDatabaseServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlDatabaseServer -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlDatabaseServer -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -SqlDatabaseServer" @"
    Retrieves an Azure SQL Database Server. Refers to the server that contains the Azure SQL Databases. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/logical-servers.
"@ "[GraphQL: azureSqlDatabaseServer]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlDatabaseServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlDatabaseServers -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlDatabaseServers -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -SqlDatabaseServers" @"
    Retrieves a paginated list of all Azure SQL Database Servers.
"@ "[GraphQL: azureSqlDatabaseServers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlManagedInstanceDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlManagedInstanceDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlManagedInstanceDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlManagedInstanceDatabaseRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -SqlManagedInstanceDatabase" @"
    Retrieves an Azure SQL Managed Instance Database. Refers to the database engine compatible with the latest SQL Server (Enterprise Edition) database engine. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/sql-managed-instance-paas-overview.
"@ "[GraphQL: azureSqlManagedInstanceDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlManagedInstanceDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlManagedInstanceDatabases -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlManagedInstanceDatabases -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -SqlManagedInstanceDatabases" @"
    Retrieves a paginated list of all Azure SQL Managed Instance Databases.
"@ "[GraphQL: azureSqlManagedInstanceDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlManagedInstanceServer
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlManagedInstanceServer -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlManagedInstanceServer -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlManagedInstanceServerRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -SqlManagedInstanceServer" @"
    Retrieves an Azure SQL Managed Instance Server. Refers to the server the Azure SQL Managed Instance Database is a part of.
"@ "[GraphQL: azureSqlManagedInstanceServer]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlManagedInstanceServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlManagedInstanceServers -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlManagedInstanceServers -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -SqlManagedInstanceServers" @"
    Retrieves a paginated list of all Azure SQL Managed Instance Servers.
"@ "[GraphQL: azureSqlManagedInstanceServers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -SqlDatabaseDbPointInTimeRestoreWindowFromAzure" @"
    Point-in-Time (PiT) restore window of the Azure SQL Database instance in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://azure.microsoft.com/en-in/blog/azure-sql-database-point-in-time-restore/.
"@ "[GraphQL: azureSqlDatabaseDbPointInTimeRestoreWindowFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -SqlManagedInstanceDbPointInTimeRestoreWindowFromAzure" @"
    Point-in-Time (PiT) restore window of the Azure SQL Managed Instance database in the Azure native account. Refers to the range of time within which the database is available to be restored to a particular point in time. For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/managed-instance/point-in-time-restore?tabs=azure-portal.
"@ "[GraphQL: azureSqlManagedInstanceDbPointInTimeRestoreWindowFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
# REQUIRED
$inputs.Var.azureSqlDatabaseServerRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -ValidateNativeSqlDatabaseDbNameForExport" @"
    Validates the name used for an Sql Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.
"@ "[GraphQL: validateAzureNativeSqlDatabaseDbNameForExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.azureSqlDatabaseName = <System.String>
# REQUIRED
$inputs.Var.azureSqlManagedInstanceServerRubrikId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -ValidateNativeSqlManagedInstanceDbNameForExport" @"
    Validates the name used for an Managed Instance Database during an export operation. Returns true if the database name is valid. Returns false, with an error message, if the database name validation fails. Returns false, without an error message for all other failures.
"@ "[GraphQL: validateAzureNativeSqlManagedInstanceDbNameForExport]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllSqlDatabaseServerElasticPools
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllSqlDatabaseServerElasticPools -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllSqlDatabaseServerElasticPools -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllSqlDatabaseServerElasticPools" @"
    Retrieves the list of elastic pools available for a SQL Database Server.For more information, see https://docs.microsoft.com/en-us/azure/azure-sql/database/elastic-pool-overview.
"@ "[GraphQL: allAzureSqlDatabaseServerElasticPools]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snapshotId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -IsNativeSqlDatabaseSnapshotPersistent" @"
    Checks if an Azure SQL Database Snapshot or an Azure SQL Managed Instance Database Snapshot is a persistent snapshot.
"@ "[GraphQL: isAzureNativeSqlDatabaseSnapshotPersistent]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllKeyVaultsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllKeyVaultsByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllKeyVaultsByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllKeyVaultsByRegion" @"
    List of all Azure Key Vaults in a region.
"@ "[GraphQL: allAzureKeyVaultsByRegion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllEncryptionKeys
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllEncryptionKeys -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllEncryptionKeys -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllEncryptionKeys" @"
    List of all Encryption Keys in an Azure Key Vault.
"@ "[GraphQL: allAzureEncryptionKeys]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -CloudAccountTenant
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -CloudAccountTenant -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -CloudAccountTenant -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -CloudAccountTenant" @"
    Retrieves the details of the Azure tenant and all the subscriptions of the tenant, for a feature.
"@ "[GraphQL: azureCloudAccountTenant]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -CloudAccountTenantWithExoConfigs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -CloudAccountTenantWithExoConfigs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -CloudAccountTenantWithExoConfigs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -CloudAccountTenantWithExoConfigs" @"
    Retrieves details about the Azure cloud account tenant including the Exocompute configurations for the tenant subscriptions, for a specified feature.
"@ "[GraphQL: azureCloudAccountTenantWithExoConfigs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllCloudAccountTenants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllCloudAccountTenants -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllCloudAccountTenants -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllCloudAccountTenants" @"
    Retrieves a list of all the Azure tenants and tenant subscriptions for features. The list can be filtered by feature status, subscription native ID, and subscription name.
"@ "[GraphQL: allAzureCloudAccountTenants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -CloudAccountSubscriptionWithFeatures
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -CloudAccountSubscriptionWithFeatures -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -CloudAccountSubscriptionWithFeatures -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -CloudAccountSubscriptionWithFeatures" @"
    Retrieves the details of the Azure cloud account.
"@ "[GraphQL: azureCloudAccountSubscriptionWithFeatures]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllCloudAccountSubscriptionsByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllCloudAccountSubscriptionsByFeature -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllCloudAccountSubscriptionsByFeature -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.subscriptionStatusFilters = @(
	<CloudAccountStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountStatus]) for enum values.
)
"@
    Write-Message "Invoke-RscQueryAzure -AllCloudAccountSubscriptionsByFeature" @"
    Retrieves a list of all Azure Subscriptions with feature details such as feature, status, and regions.
"@ "[GraphQL: allAzureCloudAccountSubscriptionsByFeature]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllSubscriptionWithExocomputeMappings
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllSubscriptionWithExocomputeMappings -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllSubscriptionWithExocomputeMappings -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllSubscriptionWithExocomputeMappings" @"
    Retrieves a list of all Azure subscriptions with Exocompute subscription mapping.
"@ "[GraphQL: allAzureSubscriptionWithExocomputeMappings]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllResourceGroupsFrom
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllResourceGroupsFrom -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllResourceGroupsFrom -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureSubscriptionNativeId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -AllResourceGroupsFrom" @"
    Retrieves a list og all resource groups in the specified account.
"@ "[GraphQL: allResourceGroupsFromAzure]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -DoesNativeResourceGroupExist
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -DoesNativeResourceGroupExist -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -DoesNativeResourceGroupExist -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -DoesNativeResourceGroupExist" @"
    Checks if a resource group with the specified name exists in the specified account.
"@ "[GraphQL: doesAzureNativeResourceGroupExist]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNativeResourceGroupsInfoIfExist
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNativeResourceGroupsInfoIfExist -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNativeResourceGroupsInfoIfExist -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllNativeResourceGroupsInfoIfExist" @"
    Retrieves a list of resource groups with the specified names which exist in the specified account.
"@ "[GraphQL: allAzureNativeResourceGroupsInfoIfExist]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllCloudAccountMissingPermissions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllCloudAccountMissingPermissions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllCloudAccountMissingPermissions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllCloudAccountMissingPermissions" @"
    Retrieves a list of all the missing permissions on Azure subscriptions that are a part of the Azure Cloud Account.
"@ "[GraphQL: allAzureCloudAccountMissingPermissions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -CloudAccountPermissionConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -CloudAccountPermissionConfig -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -CloudAccountPermissionConfig -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -CloudAccountPermissionConfig" @"
    Retrieves the configuration consisting of role permissions and feature policy version required for Azure subscription setup. Features refer to the Polaris features that the customer wants to be enabled on the cloud account.
"@ "[GraphQL: azureCloudAccountPermissionConfig]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllExocomputeConfigsInAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllExocomputeConfigsInAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllExocomputeConfigsInAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.azureExocomputeSearchQuery = <System.String>
# OPTIONAL
$inputs.Var.cloudAccountIDs = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscQueryAzure -AllExocomputeConfigsInAccount" @"
    Retrieves a list of Azure Exocompute configurations filtered by a cloud account ID or a search query.
"@ "[GraphQL: allAzureExocomputeConfigsInAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllCloudAccountSubnetsByRegion
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllCloudAccountSubnetsByRegion -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllCloudAccountSubnetsByRegion -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.region = <AzureCloudAccountRegion> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureCloudAccountRegion]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -AllCloudAccountSubnetsByRegion" @"
    Retrieves all subnets in the specified region and subscription. Subnets allow you to choose IP address range of your choice. For more information, see https://docs.microsoft.com/en-us/azure/virtual-network/network-overview#virtual-network-and-subnets.
"@ "[GraphQL: allAzureCloudAccountSubnetsByRegion]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -ValidateCloudAccountExocomputeConfigurations" @"
    Validates if Azure subnets are correctly configured for running Azure Kubernetes Service (AKS) Clusters. When correctly configured, the Azure subnets allow the required region-specific outbound connectivity and do not overlap with Azure restricted IP Address Space.
"@ "[GraphQL: validateAzureCloudAccountExocomputeConfigurations]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllArmTemplatesByFeature
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllArmTemplatesByFeature -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllArmTemplatesByFeature -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllArmTemplatesByFeature" @"
    Retrieve ARM templates for role definition and role assignment.
"@ "[GraphQL: allAzureArmTemplatesByFeature]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.feature = <CloudAccountFeature> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CloudAccountFeature]) for enum values.
# REQUIRED
$inputs.Var.unmappingValidationType = <UnmappingValidationType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmappingValidationType]) for enum values.
"@
    Write-Message "Invoke-RscQueryAzure -CheckPersistentStorageSubscriptionCanUnmap" @"
    Checks if we can unmap the archival location from the subscription.
"@ "[GraphQL: checkAzurePersistentStorageSubscriptionCanUnmap]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -Subscriptions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -Subscriptions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -Subscriptions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -Subscriptions" @"
    Gets the subscriptions for the given Azure tenant.
"@ "[GraphQL: azureSubscriptions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -Regions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -Regions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -Regions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -Regions" @"
    Gets the Azure regions for the given subscription.
"@ "[GraphQL: azureRegions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -ResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -ResourceGroups -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -ResourceGroups -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -ResourceGroups" @"
    Gets the Azure resource groups for the given subscription.
"@ "[GraphQL: azureResourceGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -VNets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -VNets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -VNets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -VNets" @"
    Gets the VNets for the given subscription.
"@ "[GraphQL: azureVNets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -Subnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -Subnets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -Subnets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.vNetId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -Subnets" @"
    Gets the subnets for the given subscription.
"@ "[GraphQL: azureSubnets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -StorageAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -StorageAccounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -StorageAccounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -StorageAccounts" @"
    Gets the storage accounts for the given subscription.
"@ "[GraphQL: azureStorageAccounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllHostedRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllHostedRegions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllHostedRegions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryAzure -AllHostedRegions" @"
    Lists all Azure regions supported by the Rubrik-Hosted SaaS protection.
"@ "[GraphQL: allHostedAzureRegions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllResourceGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllResourceGroups -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllResourceGroups -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
# REQUIRED
$inputs.Var.azureRegion = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -AllResourceGroups" @"
    Get resource groups for a service principal in Azure.
"@ "[GraphQL: allAzureResourceGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllVnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllVnets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllVnets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.vnetRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}
"@
    Write-Message "Invoke-RscQueryAzure -AllVnets" @"
    Get VNets for a given account in Azure.
"@ "[GraphQL: allAzureVnets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllSubnets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllSubnets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllSubnets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzure -AllSubnets" @"
    Get subnets for a given account in Azure.
"@ "[GraphQL: allAzureSubnets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllCdmVersions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllCdmVersions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllCdmVersions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cdmVersionRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	location = <System.String>
}
"@
    Write-Message "Invoke-RscQueryAzure -AllCdmVersions" @"
    Get all Rubrik CDM versions in the Azure marketplace.
"@ "[GraphQL: allAzureCdmVersions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllRegions
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllRegions -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllRegions -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cloudAccountId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzure -AllRegions" @"
    Get all available regions for Azure.
"@ "[GraphQL: allAzureRegions]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllNsgs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllNsgs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllNsgs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.nsgRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}
"@
    Write-Message "Invoke-RscQueryAzure -AllNsgs" @"
    Get all available network security groups for Azure.
"@ "[GraphQL: allAzureNsgs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllStorageAccounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllStorageAccounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllStorageAccounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.storageAccountsRequest = @{
	# OPTIONAL
	cloudAccountId = <System.String>
	# OPTIONAL
	resourceGroup = <System.String>
}
"@
    Write-Message "Invoke-RscQueryAzure -AllStorageAccounts" @"
    List all storage accounts from Azure.
"@ "[GraphQL: allAzureStorageAccounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzure -AllManagedIdentities
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzure -AllManagedIdentities -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzure -AllManagedIdentities -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.managedIdentitiesRequest = @{
	# REQUIRED
	cloudAccountId = <System.String>
}
"@
    Write-Message "Invoke-RscQueryAzure -AllManagedIdentities" @"
    List all managed identities for Azure resources.
"@ "[GraphQL: allAzureManagedIdentities]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -Exocompute
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -Exocompute -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -Exocompute -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.exocomputeClusterId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzureO365 -Exocompute" @"
    Gets the exocompute details of the given cluster.
"@ "[GraphQL: azureO365Exocompute]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -CheckStorageAccountName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -CheckStorageAccountName -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -CheckStorageAccountName -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.storage_account_name = <System.String>
"@
    Write-Message "Invoke-RscQueryAzureO365 -CheckStorageAccountName" @"
    Checks the storage account name.
"@ "[GraphQL: azureO365CheckStorageAccountName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -CheckStorageAccountAccessibility
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -CheckStorageAccountAccessibility -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -CheckStorageAccountAccessibility -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzureO365 -CheckStorageAccountAccessibility" @"
    Checks the accessibility of the storage account.
"@ "[GraphQL: azureO365CheckStorageAccountAccessibility]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -CheckSubscriptionQuota
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -CheckSubscriptionQuota -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -CheckSubscriptionQuota -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.regionName = <System.String>
"@
    Write-Message "Invoke-RscQueryAzureO365 -CheckSubscriptionQuota" @"
    Checks the Azure subscription quota.
"@ "[GraphQL: azureO365CheckSubscriptionQuota]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -CheckResourceGroupName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -CheckResourceGroupName -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -CheckResourceGroupName -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
# REQUIRED
$inputs.Var.groupName = <System.String>
"@
    Write-Message "Invoke-RscQueryAzureO365 -CheckResourceGroupName" @"
    Checks the resource group name.
"@ "[GraphQL: azureO365CheckResourceGroupName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -CheckVirtualNetworkName
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -CheckVirtualNetworkName -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -CheckVirtualNetworkName -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzureO365 -CheckVirtualNetworkName" @"
    Checks the virtual network name.
"@ "[GraphQL: azureO365CheckVirtualNetworkName]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -ValidateUserRoles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -ValidateUserRoles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -ValidateUserRoles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.tenantId = <System.String>
# REQUIRED
$inputs.Var.subscriptionId = <System.String>
"@
    Write-Message "Invoke-RscQueryAzureO365 -ValidateUserRoles" @"
    Validates the user roles in the subscription.
"@ "[GraphQL: azureO365ValidateUserRoles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -CheckNSGOutboundRules
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -CheckNSGOutboundRules -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -CheckNSGOutboundRules -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzureO365 -CheckNSGOutboundRules" @"
    Checks the NSG Outbound rules of the Azure resources.
"@ "[GraphQL: azureO365CheckNSGOutboundRules]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -CheckNetworkSubnet
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -CheckNetworkSubnet -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -CheckNetworkSubnet -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzureO365 -CheckNetworkSubnet" @"
    Checks the network subnet of the Azure resources.
"@ "[GraphQL: azureO365CheckNetworkSubnet]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryAzureO365 -GetNetworkSubnetUnusedAddr" @"
    Retrieves the unused addresses available in a subnet.
"@ "[GraphQL: azureO365GetNetworkSubnetUnusedAddr]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryAzureO365 -GetAzureHostType
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryAzureO365 -GetAzureHostType -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryAzureO365 -GetAzureHostType -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryAzureO365 -GetAzureHostType" @"
    Retrieves the AzureHostType of the account.
"@ "[GraphQL: azureO365GetAzureHostType]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryCassandra -Sources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCassandra -Sources -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCassandra -Sources -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCassandra -Sources" @"
    Paginated list of cassandra sources.
"@ "[GraphQL: cassandraSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCassandra -Keyspaces
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCassandra -Keyspaces -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCassandra -Keyspaces -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCassandra -Keyspaces" @"
    Paginated list of cassandra keyspaces.
"@ "[GraphQL: cassandraKeyspaces]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCassandra -ColumnFamilies
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCassandra -ColumnFamilies -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCassandra -ColumnFamilies -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCassandra -ColumnFamilies" @"
    Paginated list of cassandra column families.
"@ "[GraphQL: cassandraColumnFamilies]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCassandra -ColumnFamilyRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCassandra -ColumnFamilyRecoverableRange -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCassandra -ColumnFamilyRecoverableRange -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCassandra -ColumnFamilyRecoverableRange" @"
    Get Recoverable Range of a Cassandra Column Family.
"@ "[GraphQL: cassandraColumnFamilyRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCassandra -ColumnFamilySchema
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCassandra -ColumnFamilySchema -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCassandra -ColumnFamilySchema -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCassandra -ColumnFamilySchema" @"
    Get Schema of a Cassandra Column Family.
"@ "[GraphQL: cassandraColumnFamilySchema]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCassandra -Source
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCassandra -Source -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCassandra -Source -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryCassandra -Source" @"
    Details of a cassandra source.
"@ "[GraphQL: cassandraSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCassandra -Keyspace
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCassandra -Keyspace -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCassandra -Keyspace -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryCassandra -Keyspace" @"
    Details of a cassandra keyspace.
"@ "[GraphQL: cassandraKeyspace]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCassandra -ColumnFamily
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCassandra -ColumnFamily -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCassandra -ColumnFamily -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryCassandra -ColumnFamily" @"
    Details of a cassandra column family.
"@ "[GraphQL: cassandraColumnFamily]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Nodes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Nodes -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Nodes -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -Nodes" @"
    Get list of nodes in this Rubrik cluster

Supported in v5.0+
Returns the list of all Rubrik nodes.
"@ "[GraphQL: clusterNodes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -List -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -List -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCluster -List" @"
    List of the available cluster objects.
"@ "[GraphQL: clusterConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Cluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Cluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -Cluster" @"
    A cluster object.
"@ "[GraphQL: cluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -WithUpgradesInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -WithUpgradesInfo -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -WithUpgradesInfo -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCluster -WithUpgradesInfo" @"
    
"@ "[GraphQL: clusterWithUpgradesInfo]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Dns
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Dns -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Dns -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -Dns" @"
    Rubrik cluster DNS information.
"@ "[GraphQL: clusterDns]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Proxy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Proxy -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Proxy -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -Proxy" @"
    Rubrik cluster proxy information.
"@ "[GraphQL: clusterProxy]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -NtpServers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -NtpServers -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -NtpServers -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -NtpServers" @"
    Get NTP Servers

Supported in v5.0+
Retrieve a list of the NTP servers assigned to the Rubrik cluster. Encryption keys are not reported.
"@ "[GraphQL: clusterNtpServers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -NetworkInterfaces
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -NetworkInterfaces -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -NetworkInterfaces -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	interface = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -NetworkInterfaces" @"
    Get network interfaces for a Rubrik Cluster cluster

Supported in v5.0+
Retrieves network interfaces(including VLANs) on bond0/bond1.
"@ "[GraphQL: clusterNetworkInterfaces]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -FloatingIps
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -FloatingIps -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -FloatingIps -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -FloatingIps" @"
    Get a list of a cluster's always-available Ips

Supported in v5.0+
Get a list of a cluster's always-available Ips.
"@ "[GraphQL: clusterFloatingIps]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Vlans
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Vlans -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Vlans -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	vlan = <System.Int32>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -Vlans" @"
    Rubrik cluster VLAN information.
"@ "[GraphQL: clusterVlans]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -DefaultGateway
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -DefaultGateway -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -DefaultGateway -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -DefaultGateway" @"
    Get current default gateway

Supported in v5.0+
Get current default gateway.
"@ "[GraphQL: clusterDefaultGateway]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -WebSignedCertificate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -WebSignedCertificate -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -WebSignedCertificate -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -WebSignedCertificate" @"
    Get the signed certificate for Web server

Supported in v5.2+
If the web server uses a signed certificate, fetch it.
"@ "[GraphQL: clusterWebSignedCertificate]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Ipmi
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Ipmi -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Ipmi -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -Ipmi" @"
    Get IPMI details

Supported in v5.0+
get IPMI details of availability and enabled access in the cluster.
"@ "[GraphQL: clusterIpmi]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Certificates
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Certificates -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Certificates -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCluster -Certificates" @"
    Get all certificates

Supported in v5.1+
Get all certificates.
"@ "[GraphQL: clusterCertificates]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -WebCertsAndIpmis
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -WebCertsAndIpmis -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -WebCertsAndIpmis -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuids = @(
		<System.String>
	)
}
"@
    Write-Message "Invoke-RscQueryCluster -WebCertsAndIpmis" @"
    Get web server certificate and IPMI details for multiple clusters.
"@ "[GraphQL: allClusterWebCertsAndIpmis]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -OperationJobProgress
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -OperationJobProgress -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -OperationJobProgress -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# OPTIONAL
	clusterUuid = <System.String>
	# REQUIRED
	jobType = <CcpJobType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CcpJobType]) for enum values.
}
"@
    Write-Message "Invoke-RscQueryCluster -OperationJobProgress" @"
    Get updates on the job progress of the Rubrik cluster operation.
"@ "[GraphQL: clusterOperationJobProgress]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Ipv6Mode
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Ipv6Mode -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Ipv6Mode -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -Ipv6Mode" @"
    Rubrik cluster IPv6 mode.
"@ "[GraphQL: clusterIpv6Mode]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Csr
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Csr -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Csr -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -Csr" @"
    Get the cluster certificate signing request

Supported in v7.0+
Returns the certificate signing request generated from the private key of the Rubrik cluster.
"@ "[GraphQL: clusterCsr]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -TypeList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -TypeList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -TypeList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryCluster -TypeList" @"
    
"@ "[GraphQL: clusterTypeList]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -GroupByList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -GroupByList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -GroupByList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCluster -GroupByList" @"
    
"@ "[GraphQL: clusterGroupByConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -DatabaseLogReportingProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -DatabaseLogReportingProperties -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -DatabaseLogReportingProperties -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscQueryCluster -DatabaseLogReportingProperties" @"
    Get the database log backup report properties

Supported in v5.3+
Get the properties for the database (SQL and Oracle) log backup delay email notification creation. The properties are logDelayThresholdInMin and logDelayNotificationFrequencyInMin.
"@ "[GraphQL: databaseLogReportingPropertiesForCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -DatabaseLogReport
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -DatabaseLogReport -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -DatabaseLogReport -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCluster -DatabaseLogReport" @"
    Get the database log backup delay information

Supported in v5.3+
v5.3: 
v6.0+: Get the database log backup delay information.
"@ "[GraphQL: databaseLogReportForCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Connected
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Connected -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Connected -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.clusterFilterArg = <ClusterTypeEnum> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ClusterTypeEnum]) for enum values.
"@
    Write-Message "Invoke-RscQueryCluster -Connected" @"
    List all connected clusters.
"@ "[GraphQL: allConnectedClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -ReplicationTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -ReplicationTargets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -ReplicationTargets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -ReplicationTargets" @"
    All replication targets for a cluster.
"@ "[GraphQL: allClusterReplicationTargets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -HostFailover
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -HostFailover -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -HostFailover -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -HostFailover" @"
    Get details of the given host failover cluster.
"@ "[GraphQL: hostFailoverCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -K8s
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -K8s -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -K8s -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCluster -K8s" @"
    
"@ "[GraphQL: k8sClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -Windows
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -Windows -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -Windows -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -Windows" @"
    A Windows Cluster.
"@ "[GraphQL: windowsCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -ReportMigrationStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -ReportMigrationStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -ReportMigrationStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCluster -ReportMigrationStatus" @"
    Retrieve details of the Rubrik clusters' reports migration.
"@ "[GraphQL: clusterReportMigrationStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -ReportMigrationCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -ReportMigrationCount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -ReportMigrationCount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.status = @(
	<CdmReportMigrationStatus> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.CdmReportMigrationStatus]) for enum values.
)
"@
    Write-Message "Invoke-RscQueryCluster -ReportMigrationCount" @"
    Retrieve the counts of the Rubrik cluster reports migration.
"@ "[GraphQL: clusterReportMigrationCount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -ReportMigrationJobStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -ReportMigrationJobStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -ReportMigrationJobStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -ReportMigrationJobStatus" @"
    Retrieve the status of the cluster report migration job.
"@ "[GraphQL: clusterReportMigrationJobStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -LaDomains
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -LaDomains -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -LaDomains -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryCluster -LaDomains" @"
    Returns paginated list of SLA domains that were created on Rubrik CDM.
"@ "[GraphQL: clusterSlaDomains]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -VerifySlaWithReplicationTo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -VerifySlaWithReplicationTo -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -VerifySlaWithReplicationTo -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>
# REQUIRED
$inputs.Var.includeArchived = <System.Boolean>
"@
    Write-Message "Invoke-RscQueryCluster -VerifySlaWithReplicationTo" @"
    Verify for a Rubrik cluster if it is replication target in any SLA Domain.
"@ "[GraphQL: verifySlaWithReplicationToCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -GlobalSlas
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -GlobalSlas -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -GlobalSlas -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.cdmClusterUUID = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -GlobalSlas" @"
    Global SLA Domains protecting at least one object on the specified Rubrik cluster.
"@ "[GraphQL: allClusterGlobalSlas]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -RegistrationProductInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -RegistrationProductInfo -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -RegistrationProductInfo -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryCluster -RegistrationProductInfo" @"
    Info about the cluster product types the user is entitled to.
"@ "[GraphQL: clusterRegistrationProductInfo]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -IsTotpAckNecessary
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -IsTotpAckNecessary -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -IsTotpAckNecessary -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
"@
    Write-Message "Invoke-RscQueryCluster -IsTotpAckNecessary" @"
    Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.
"@ "[GraphQL: isTotpAckNecessaryForCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryCluster -TotpAckStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryCluster -TotpAckStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryCluster -TotpAckStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.listClusterUuid = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscQueryCluster -TotpAckStatus" @"
    Checks whether acknowledgement of the Time-based, One-Time Password (TOTP) mandate is required for upgrading the Rubrik cluster version.
"@ "[GraphQL: allClustersTotpAckStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryDb2 -Instances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryDb2 -Instances -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryDb2 -Instances -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryDb2 -Instances" @"
    Connection of filtered db2 instances based on specific filters.
"@ "[GraphQL: db2Instances]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryDb2 -Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryDb2 -Instance -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryDb2 -Instance -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.id = <System.String>
"@
    Write-Message "Invoke-RscQueryDb2 -Instance" @"
    Details of a db2 instance for a given fid.
"@ "[GraphQL: db2Instance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryDb2 -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryDb2 -Database -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryDb2 -Database -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryDb2 -Database" @"
    Details of a db2 database for a given fid.
"@ "[GraphQL: db2Database]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryDb2 -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryDb2 -Databases -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryDb2 -Databases -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryDb2 -Databases" @"
    Connection of filtered db2 databases based on specific filters.
"@ "[GraphQL: db2Databases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryDb2 -RecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryDb2 -RecoverableRange -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryDb2 -RecoverableRange -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.db2RecoverableRangeFid = <System.String>
"@
    Write-Message "Invoke-RscQueryDb2 -RecoverableRange" @"
    Details of a Db2 recoverable range for a given fid.
"@ "[GraphQL: db2RecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryDb2 -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryDb2 -RecoverableRanges -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryDb2 -RecoverableRanges -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryDb2 -RecoverableRanges" @"
    Connection of all recoverable ranges for Db2.
"@ "[GraphQL: db2RecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryDb2 -LogSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryDb2 -LogSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryDb2 -LogSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.db2LogSnapshotFid = <System.String>
"@
    Write-Message "Invoke-RscQueryDb2 -LogSnapshot" @"
    Details of a Db2 log snapshot for a given fid.
"@ "[GraphQL: db2LogSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryDb2 -LogSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryDb2 -LogSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryDb2 -LogSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryDb2 -LogSnapshots" @"
    Connection of all log snapshots for Db2.
"@ "[GraphQL: db2LogSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -TopLevelDescendants -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -TopLevelDescendants -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryHyperv -TopLevelDescendants" @"
    Paginated list of the highest-level HyperV Objects accessible by the current user.
"@ "[GraphQL: hypervTopLevelDescendants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -VirtualMachines
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -VirtualMachines -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -VirtualMachines -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryHyperv -VirtualMachines" @"
    Paginated list of HyperV Virtual Machines.
"@ "[GraphQL: hypervVirtualMachines]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -Scvmm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -Scvmm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -Scvmm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryHyperv -Scvmm" @"
    Details of the given Hyper-V SCVMM.
"@ "[GraphQL: hypervScvmm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -Cluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -Cluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryHyperv -Cluster" @"
    Details of the given Hyper-V Cluster.
"@ "[GraphQL: hypervCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -Server
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -Server -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -Server -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryHyperv -Server" @"
    Details of the given Hyper-V Server.
"@ "[GraphQL: hypervServer]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -VirtualMachine
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -VirtualMachine -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -VirtualMachine -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryHyperv -VirtualMachine" @"
    Details of the given Hyper-V Virtual Machine.
"@ "[GraphQL: hypervVirtualMachine]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -UniqueServersCount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -UniqueServersCount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -UniqueServersCount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryHyperv -UniqueServersCount" @"
    Count of unique HyperV Servers.
"@ "[GraphQL: uniqueHypervServersCount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -Scvmms
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -Scvmms -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -Scvmms -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryHyperv -Scvmms" @"
    Paginated list of HyperV SCVMMs.
"@ "[GraphQL: hypervScvmms]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -Servers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -Servers -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -Servers -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryHyperv -Servers" @"
    Get summary of all the Hyper-V hosts

Supported in v5.0+
Get summary of all the Hyper-V hosts.
"@ "[GraphQL: hypervServers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -Mounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -Mounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -Mounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryHyperv -Mounts" @"
    HyperV Live Mount Connection.
"@ "[GraphQL: hypervMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -VmDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -VmDetail -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -VmDetail -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryHyperv -VmDetail" @"
    HyperV Virtual Machine detail from CDM.
"@ "[GraphQL: hypervVmDetail]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -HostAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -HostAsyncRequestStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -HostAsyncRequestStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryHyperv -HostAsyncRequestStatus" @"
    Get Hyper-V host async request

Supported in v5.0+
Get details about a Hyper-V host related async request.
"@ "[GraphQL: hypervHostAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -ScvmmAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -ScvmmAsyncRequestStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -ScvmmAsyncRequestStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryHyperv -ScvmmAsyncRequestStatus" @"
    Get Hyper-V SCVMM async request

Supported in v5.0+
Get details about a Hyper-V SCVMM related async request.
"@ "[GraphQL: hypervScvmmAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryHyperv -VirtualMachineAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryHyperv -VirtualMachineAsyncRequestStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryHyperv -VirtualMachineAsyncRequestStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryHyperv -VirtualMachineAsyncRequestStatus" @"
    Get VM async request details

Supported in v5.0+
Get details about a Hyper-V vm related async request.
"@ "[GraphQL: hypervVirtualMachineAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryLdap -IntegrationList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryLdap -IntegrationList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryLdap -IntegrationList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryLdap -IntegrationList" @"
    Browse LDAP integrations.
"@ "[GraphQL: ldapIntegrationConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryLdap -PrincipalList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryLdap -PrincipalList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryLdap -PrincipalList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryLdap -PrincipalList" @"
    Search LDAP Principals.
"@ "[GraphQL: ldapPrincipalConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryLdap -AuthorizedPrincipalList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryLdap -AuthorizedPrincipalList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryLdap -AuthorizedPrincipalList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryLdap -AuthorizedPrincipalList" @"
    Browse LDAP-authorized principals.
"@ "[GraphQL: ldapAuthorizedPrincipalConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryMongo -Sources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -Sources -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -Sources -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -Sources" @"
    Paginated list of MongoDB sources.
"@ "[GraphQL: mongoSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -Databases -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -Databases -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -Databases" @"
    Paginated list of MongoDB databases.
"@ "[GraphQL: mongoDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -Collections
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -Collections -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -Collections -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -Collections" @"
    Paginated list of MongoDB collections.
"@ "[GraphQL: mongoCollections]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -Source
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -Source -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -Source -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMongo -Source" @"
    Provides details for the MongoDB source cluster identified by the fid.
"@ "[GraphQL: mongoSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -Database -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -Database -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMongo -Database" @"
    Provides details for a MongoDB database identified by the fid.
"@ "[GraphQL: mongoDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -Collection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -Collection -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -Collection -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMongo -Collection" @"
    Provides details for a MongoDB collection identified by the fid.
"@ "[GraphQL: mongoCollection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -RecoverableRanges -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -RecoverableRanges -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -RecoverableRanges" @"
    Provides the point in time range for MongoDB object recovery.
"@ "[GraphQL: mongoRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -BulkRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -BulkRecoverableRanges -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -BulkRecoverableRanges -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -BulkRecoverableRanges" @"
    Provides the bulk recoverable range for MongoDB object recovery, including data and log snapshots.
"@ "[GraphQL: mongoBulkRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -DbSources
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -DbSources -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -DbSources -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -DbSources" @"
    Paginated list of MongoDB sources on NoSQL cluster.
"@ "[GraphQL: mongodbSources]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -DbDatabases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -DbDatabases -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -DbDatabases -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -DbDatabases" @"
    Paginated list of MongoDB databases on NoSQL cluster.
"@ "[GraphQL: mongodbDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -DbCollections
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -DbCollections -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -DbCollections -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -DbCollections" @"
    Paginated list of MongoDB collections on NoSQL cluster.
"@ "[GraphQL: mongodbCollections]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -DbSource
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -DbSource -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -DbSource -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMongo -DbSource" @"
    MongoDB source cluster identified by FID on NoSQL cluster. 
For MongoDB, the term ""source"" is usually used for either a replica set or a sharded cluster. 
For more info on MongoDB cluster refer to : https://docs.mongodb.com/manual/introduction/
"@ "[GraphQL: mongodbSource]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -DbDatabase
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -DbDatabase -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -DbDatabase -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMongo -DbDatabase" @"
    MongoDB database identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
A database stores one or more collections of documents. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections/
"@ "[GraphQL: mongodbDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -DbCollection
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -DbCollection -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -DbCollection -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMongo -DbCollection" @"
    MongoDB collection identified by FID on NoSQL cluster. 
MongoDB stores data records as documents which are gathered together in collections. 
For more info refer to : https://docs.mongodb.com/manual/core/databases-and-collections
"@ "[GraphQL: mongodbCollection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -DbCollectionRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -DbCollectionRecoverableRange -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -DbCollectionRecoverableRange -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -DbCollectionRecoverableRange" @"
    Recoverable Range of a MongoDB collection on NoSQL cluster.
"@ "[GraphQL: mongodbCollectionRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMongo -DbBulkRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMongo -DbBulkRecoverableRange -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMongo -DbBulkRecoverableRange -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMongo -DbBulkRecoverableRange" @"
    Recoverable range for multiple Management Objects on NoSQL cluster.
"@ "[GraphQL: mongodbBulkRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryMssql -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -TopLevelDescendants -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -TopLevelDescendants -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -TopLevelDescendants" @"
    Paginated list of the highest-level Microsoft SQL Objects accessible by the current user.
"@ "[GraphQL: mssqlTopLevelDescendants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -Databases -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -Databases -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -Databases" @"
    Paginated list of Microsoft SQL Databases.
"@ "[GraphQL: mssqlDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -AvailabilityGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -AvailabilityGroup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -AvailabilityGroup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMssql -AvailabilityGroup" @"
    A Microsoft SQL Availability Group.
"@ "[GraphQL: mssqlAvailabilityGroup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -Instance
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -Instance -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -Instance -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMssql -Instance" @"
    A Microsoft SQL Instance.
"@ "[GraphQL: mssqlInstance]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -Database -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -Database -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMssql -Database" @"
    A Microsoft SQL Database.
"@ "[GraphQL: mssqlDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -RecoverableRanges -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -RecoverableRanges -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -RecoverableRanges" @"
    List of recoverable ranges for a Microsoft SQL Database.
"@ "[GraphQL: mssqlRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -DatabaseMissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -DatabaseMissedSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -DatabaseMissedSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -DatabaseMissedSnapshots" @"
    List of missed snapshots for a Microsoft SQL Database.
"@ "[GraphQL: mssqlDatabaseMissedSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -CompatibleInstances
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -CompatibleInstances -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -CompatibleInstances -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -CompatibleInstances" @"
    Returns all compatible instances for export for the specified recovery time.
"@ "[GraphQL: mssqlCompatibleInstances]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -DatabaseMissedRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -DatabaseMissedRecoverableRanges -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -DatabaseMissedRecoverableRanges -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -DatabaseMissedRecoverableRanges" @"
    List of missed recoverable ranges for a Microsoft SQL Database.
"@ "[GraphQL: mssqlDatabaseMissedRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -AllDatabaseRestoreFiles
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -AllDatabaseRestoreFiles -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -AllDatabaseRestoreFiles -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -AllDatabaseRestoreFiles" @"
    Provides a list of database files to be restored for the specified restore or export operation.
"@ "[GraphQL: allMssqlDatabaseRestoreFiles]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -DatabaseLiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -DatabaseLiveMounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -DatabaseLiveMounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -DatabaseLiveMounts" @"
    Paginated list of Microsoft SQL Database live mounts.
"@ "[GraphQL: mssqlDatabaseLiveMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -DefaultProperties
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -DefaultProperties -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -DefaultProperties -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
}
"@
    Write-Message "Invoke-RscQueryMssql -DefaultProperties" @"
    The current default properties for Microsoft SQL databases.
"@ "[GraphQL: mssqlDefaultProperties]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -DatabaseRestoreEstimate
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -DatabaseRestoreEstimate -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -DatabaseRestoreEstimate -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -DatabaseRestoreEstimate" @"
    Returns a size estimate for a restore, export, or mount.
"@ "[GraphQL: mssqlDatabaseRestoreEstimate]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -CdmLogShippingTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -CdmLogShippingTargets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -CdmLogShippingTargets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -CdmLogShippingTargets" @"
    Paginated list of Microsoft SQL log shipping target.
"@ "[GraphQL: cdmMssqlLogShippingTargets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -CdmLogShippingTarget
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -CdmLogShippingTarget -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -CdmLogShippingTarget -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryMssql -CdmLogShippingTarget" @"
    A single Microsoft SQL log shipping target.
"@ "[GraphQL: cdmMssqlLogShippingTarget]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryMssql -LogShippingTargets
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryMssql -LogShippingTargets -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryMssql -LogShippingTargets -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryMssql -LogShippingTargets" @"
    List of filtered Microsoft SQL log shipping targets.
"@ "[GraphQL: mssqlLogShippingTargets]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -TopLevelDescendants -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -TopLevelDescendants -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryNutanix -TopLevelDescendants" @"
    Paginated list of the highest-level Nutanix Objects accessible by the current user.
"@ "[GraphQL: nutanixTopLevelDescendants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -Cluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -Cluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -Cluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryNutanix -Cluster" @"
    A Nutanix Cluster.
"@ "[GraphQL: nutanixCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -Clusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -Clusters -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -Clusters -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryNutanix -Clusters" @"
    Paginated list of Nutanix Clusters.
"@ "[GraphQL: nutanixClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -PrismCentrals
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -PrismCentrals -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -PrismCentrals -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryNutanix -PrismCentrals" @"
    Paginated list of Nutanix Prism Central objects.
"@ "[GraphQL: nutanixPrismCentrals]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -PrismCentral
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -PrismCentral -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -PrismCentral -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryNutanix -PrismCentral" @"
    Details of the given Prism Central.
"@ "[GraphQL: nutanixPrismCentral]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -Category
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -Category -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -Category -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryNutanix -Category" @"
    Details of the given category.
"@ "[GraphQL: nutanixCategory]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -CategoryValue
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -CategoryValue -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -CategoryValue -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryNutanix -CategoryValue" @"
    Details of the given category value.
"@ "[GraphQL: nutanixCategoryValue]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -Vm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -Vm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -Vm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryNutanix -Vm" @"
    A Nutanix Virtual Machine.
"@ "[GraphQL: nutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -Vms
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -Vms -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -Vms -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryNutanix -Vms" @"
    Paginated list of Nutanix Virtual Machines.
"@ "[GraphQL: nutanixVms]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -Mounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -Mounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -Mounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryNutanix -Mounts" @"
    Nutanix Live Mount Connection.
"@ "[GraphQL: nutanixMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -ClusterContainers
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -ClusterContainers -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -ClusterContainers -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryNutanix -ClusterContainers" @"
    Get list of containers on this cluster

Supported in v5.0+
Query the nutanix cluster to get the list of containers, used for export purposes.
"@ "[GraphQL: nutanixClusterContainers]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -ClusterNetworks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -ClusterNetworks -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -ClusterNetworks -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryNutanix -ClusterNetworks" @"
    Get list of networks on this cluster

Supported in v8.1+
Retrieves the list of networks by querying the Nutanix cluster. The list of networks is used for restore purposes.
"@ "[GraphQL: nutanixClusterNetworks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -ClusterAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -ClusterAsyncRequestStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -ClusterAsyncRequestStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryNutanix -ClusterAsyncRequestStatus" @"
    Get Nutanix cluster async request

Supported in v5.0+
Get details about a Nutanix cluster-related async request.
"@ "[GraphQL: nutanixClusterAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -VmAsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -VmAsyncRequestStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -VmAsyncRequestStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryNutanix -VmAsyncRequestStatus" @"
    v5.0-v8.0: Get VM async request details
v8.1+: Get virtual machine async request details

Supported in v5.0+
v5.0-v8.0: Get details about a Nutanix VM-related async request.
v8.1+: Get details about a Nutanix virtual machine-related async request.
"@ "[GraphQL: nutanixVmAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -SearchVm
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -SearchVm -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -SearchVm -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryNutanix -SearchVm" @"
    v5.0-v8.0: Search for file in Nutanix VM
v8.1+: Search for file in Nutanix virtual machine

Supported in v5.0+
Search for a file within the Nutanix Virtual Machine. Search via full path prefix or filename prefix.
"@ "[GraphQL: searchNutanixVm]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -VmMissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -VmMissedSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -VmMissedSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryNutanix -VmMissedSnapshots" @"
    v5.0-v8.0: Get details about missed snapshots for a VM
v8.1+: Get details about missed snapshots for a virtual machine

Supported in v5.0+
v5.0-v8.0: Retrieve the time of the day when the snapshots were missed specific to a vm.
v8.1+: Retrieve the time of the day when the snapshots were missed specific to a virtual machine.
"@ "[GraphQL: nutanixVmMissedSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -BrowseSnapshot
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -BrowseSnapshot -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -BrowseSnapshot -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryNutanix -BrowseSnapshot" @"
    v5.0-v8.0: Lists all files in VM snapshot
v8.1+: Lists all files in virtual machine snapshot

Supported in v5.0+
Lists all files and directories in a given path.
"@ "[GraphQL: nutanixBrowseSnapshot]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryNutanix -SnapshotDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryNutanix -SnapshotDetail -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryNutanix -SnapshotDetail -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryNutanix -SnapshotDetail" @"
    Supported in v5.0+. Get Nutanix virtual machine snapshot details.
 Retrieve detailed information about a snapshot.
"@ "[GraphQL: nutanixSnapshotDetail]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Org
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Org -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Org -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -Org" @"
    Details of the O365Org.
"@ "[GraphQL: o365Org]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -OrgAtSnappableLevel
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -OrgAtSnappableLevel -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -OrgAtSnappableLevel -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
# REQUIRED
$inputs.Var.snappableType = <SnappableType> # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SnappableType]) for enum values.
"@
    Write-Message "Invoke-RscQueryO365 -OrgAtSnappableLevel" @"
    Details of the O365Org at snappable level, given the snappable type.
"@ "[GraphQL: o365OrgAtSnappableLevel]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -AllAdGroups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -AllAdGroups -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -AllAdGroups -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
# REQUIRED
$inputs.Var.adGroupSearchFilter = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -AllAdGroups" @"
    All AD Groups belonging to the O365 organization.
"@ "[GraphQL: allO365AdGroups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -User
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -User -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -User -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -User" @"
    Details for the O365 user corresponding to the ID.
"@ "[GraphQL: o365User]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Mailbox
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Mailbox -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Mailbox -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -Mailbox" @"
    Details for the Exchange mailbox corresponding to the snappable ID.
"@ "[GraphQL: o365Mailbox]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Groups
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Groups -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Groups -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -Groups" @"
    List of O365 Groups in the O365Org.
"@ "[GraphQL: o365Groups]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Mailboxes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Mailboxes -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Mailboxes -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -Mailboxes" @"
    List of Mailboxes in the O365Org.
"@ "[GraphQL: o365Mailboxes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Onedrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Onedrive -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Onedrive -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -Onedrive" @"
    Details for the OneDrive corresponding to the snappable ID.
"@ "[GraphQL: o365Onedrive]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Onedrives
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Onedrives -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Onedrives -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -Onedrives" @"
    List of Onedrives in the O365Org.
"@ "[GraphQL: o365Onedrives]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Site
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Site -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Site -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -Site" @"
    Details for the SharePoint site corresponding to the snappable ID.
"@ "[GraphQL: o365Site]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Sites
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Sites -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Sites -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -Sites" @"
    List of sites in the O365Org.
"@ "[GraphQL: o365Sites]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -SharepointDrive
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -SharepointDrive -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -SharepointDrive -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -SharepointDrive" @"
    Details for the SharePoint drive corresponding to the snappable ID.
"@ "[GraphQL: o365SharepointDrive]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -SharepointDrives
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -SharepointDrives -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -SharepointDrives -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -SharepointDrives" @"
    List of sharepoint drives (document libraries) in the O365Org.
"@ "[GraphQL: o365SharepointDrives]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -SharepointList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -SharepointList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -SharepointList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -SharepointList" @"
    Details for the SharePoint list corresponding to the snappable ID.
"@ "[GraphQL: o365SharepointList]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -SharepointLists
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -SharepointLists -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -SharepointLists -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -SharepointLists" @"
    Paginated list of sharepoint lists in the O365Org.
"@ "[GraphQL: o365SharepointLists]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -SharepointSite
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -SharepointSite -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -SharepointSite -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.siteFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -SharepointSite" @"
    Details for the SharePoint site corresponding to the site ID.
"@ "[GraphQL: o365SharepointSite]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -SharepointSites
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -SharepointSites -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -SharepointSites -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -SharepointSites" @"
    Paginated list of sharepoint sites in the O365Org.
"@ "[GraphQL: o365SharepointSites]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Team
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Team -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Team -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -Team" @"
    Details for the team corresponding to the snappable ID.
"@ "[GraphQL: o365Team]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Teams
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Teams -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Teams -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -Teams" @"
    List of O365 Teams in the O365Org.
"@ "[GraphQL: o365Teams]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -TeamChannels
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -TeamChannels -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -TeamChannels -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -TeamChannels" @"
    List of Channels for the O365Team.
"@ "[GraphQL: o365TeamChannels]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -TeamConversationsFolderID
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -TeamConversationsFolderID -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -TeamConversationsFolderID -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
# REQUIRED
$inputs.Var.snapshotFid = <System.String>
# REQUIRED
$inputs.Var.o365OrgId = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -TeamConversationsFolderID" @"
    ID for the conversations folder in the Team's Group Mailbox.
"@ "[GraphQL: o365TeamConversationsFolderID]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -TeamPostedBy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -TeamPostedBy -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -TeamPostedBy -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -TeamPostedBy" @"
    Users who have posted in a team.
"@ "[GraphQL: o365TeamPostedBy]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Calendar
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Calendar -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Calendar -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -Calendar" @"
    Details of the Exchange calendar pertaining to the snappable ID.
"@ "[GraphQL: o365Calendar]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -Orgs
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -Orgs -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -Orgs -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -Orgs" @"
    All O365 orgs for the account.
"@ "[GraphQL: o365Orgs]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -SharepointObjectList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -SharepointObjectList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -SharepointObjectList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -SharepointObjectList" @"
    Returns the sharepoint objects after filtering on the object types and includeEntireHierarchy.
"@ "[GraphQL: o365SharepointObjectList]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -SharepointObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -SharepointObjects -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -SharepointObjects -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -SharepointObjects" @"
    
"@ "[GraphQL: o365SharepointObjects]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -UserObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -UserObjects -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -UserObjects -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -UserObjects" @"
    Name, id, object type, and mail address of user descendant object.
"@ "[GraphQL: o365UserObjects]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -OrgSummaries
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -OrgSummaries -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -OrgSummaries -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryO365 -OrgSummaries" @"
    
"@ "[GraphQL: o365OrgSummaries]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -ObjectAncestors
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -ObjectAncestors -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -ObjectAncestors -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -ObjectAncestors" @"
    
"@ "[GraphQL: o365ObjectAncestors]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -BrowseTeamConvChannels
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -BrowseTeamConvChannels -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -BrowseTeamConvChannels -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -BrowseTeamConvChannels" @"
    Browse channels in a Teams conversations snapshot.
"@ "[GraphQL: browseO365TeamConvChannels]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -ServiceAccount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -ServiceAccount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -ServiceAccount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.orgId = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -ServiceAccount" @"
    Gets the service account for the given org.
"@ "[GraphQL: o365ServiceAccount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -AllOrgStatuses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -AllOrgStatuses -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -AllOrgStatuses -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryO365 -AllOrgStatuses" @"
    Gets the status of each org in the account.
"@ "[GraphQL: allO365OrgStatuses]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -License
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -License -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -License -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryO365 -License" @"
    Retrieve o365 licence details.
"@ "[GraphQL: o365License]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -ListApps
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -ListApps -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -ListApps -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryO365 -ListApps" @"
    Lists the O365 apps.
"@ "[GraphQL: listO365Apps]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -AllSubscriptionsAppTypeCounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -AllSubscriptionsAppTypeCounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -AllSubscriptionsAppTypeCounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    
"@
    Write-Message "Invoke-RscQueryO365 -AllSubscriptionsAppTypeCounts" @"
    Returns the total number of apps of each type, for each O365 org.
"@ "[GraphQL: allO365SubscriptionsAppTypeCounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -StorageStats
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -StorageStats -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -StorageStats -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.orgID = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -StorageStats" @"
    Returns the storage stats of an O365 org.
"@ "[GraphQL: o365StorageStats]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryO365 -ServiceStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryO365 -ServiceStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryO365 -ServiceStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # OPTIONAL
$inputs.Var.orgID = <System.String>
"@
    Write-Message "Invoke-RscQueryO365 -ServiceStatus" @"
    Returns the service status of the O365 service running on MSFT server.
"@ "[GraphQL: o365ServiceStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryOracle -TopLevelDescendants
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -TopLevelDescendants -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -TopLevelDescendants -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryOracle -TopLevelDescendants" @"
    Paginated list of the highest-level Oracle Objects accessible by the current user.
"@ "[GraphQL: oracleTopLevelDescendants]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -Databases
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -Databases -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -Databases -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryOracle -Databases" @"
    Paginated list of Oracle Databases.
"@ "[GraphQL: oracleDatabases]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -Host
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -Host -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -Host -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryOracle -Host" @"
    An Oracle Host.
"@ "[GraphQL: oracleHost]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -Rac
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -Rac -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -Rac -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryOracle -Rac" @"
    An Oracle Real Application Cluster.
"@ "[GraphQL: oracleRac]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -DataGuardGroup
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -DataGuardGroup -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -DataGuardGroup -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryOracle -DataGuardGroup" @"
    An Oracle Data Guard Group.
"@ "[GraphQL: oracleDataGuardGroup]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -Database
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -Database -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -Database -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryOracle -Database" @"
    An Oracle Database.
"@ "[GraphQL: oracleDatabase]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -LiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -LiveMounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -LiveMounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryOracle -LiveMounts" @"
    Paginated list of Oracle Live Mounts.
"@ "[GraphQL: oracleLiveMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -AcoParameters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -AcoParameters -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -AcoParameters -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbId = <System.String>
}
"@
    Write-Message "Invoke-RscQueryOracle -AcoParameters" @"
    List of supported Advanced Cloning Options

Supported in v6.0+
Get the list of supported Advanced Cloning Options (ACO) parameters.
"@ "[GraphQL: oracleAcoParameters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -RecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -RecoverableRanges -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -RecoverableRanges -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryOracle -RecoverableRanges" @"
    Get recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve the recoverable ranges for a specified Oracle database. A begin and/or end timestamp can be provided to retrieve only the ranges that fall within the window.
"@ "[GraphQL: oracleRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -MissedRecoverableRanges
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -MissedRecoverableRanges -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -MissedRecoverableRanges -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryOracle -MissedRecoverableRanges" @"
    Get missed recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve a list of missed recoverable ranges for a Oracle database. For each run of one type of error, the first and last occurrence of the error are given.
"@ "[GraphQL: oracleMissedRecoverableRanges]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -MissedSnapshots
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -MissedSnapshots -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -MissedSnapshots -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryOracle -MissedSnapshots" @"
    Get missed snapshots for an Oracle database

Supported in v5.0+
Retrieve summary information about the missed snapshots of an Oracle database.
"@ "[GraphQL: oracleMissedSnapshots]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -AcoExampleDownloadLink
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -AcoExampleDownloadLink -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -AcoExampleDownloadLink -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	clusterUuid = <System.String>
	# REQUIRED
	dbId = <System.String>
}
"@
    Write-Message "Invoke-RscQueryOracle -AcoExampleDownloadLink" @"
    Link to download the Advanced Recovery Options example file

Supported in v5.3+
Link to download the Advanced Recovery Options example file which can be used to customize Oracle recoveries.
"@ "[GraphQL: oracleAcoExampleDownloadLink]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -PdbDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -PdbDetails -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -PdbDetails -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryOracle -PdbDetails" @"
    Get PDB details

Supported in v8.0+
Retrieves information about available pluggable databases (PDBs) for a given recovery point.
"@ "[GraphQL: oraclePdbDetails]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -HostLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -HostLogBackupConfig -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -HostLogBackupConfig -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryOracle -HostLogBackupConfig" @"
    Oracle Log backup configuration for Oracle Host.
"@ "[GraphQL: oracleHostLogBackupConfig]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -DatabaseLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -DatabaseLogBackupConfig -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -DatabaseLogBackupConfig -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryOracle -DatabaseLogBackupConfig" @"
    Oracle log backup configuration for an Oracle Database.
"@ "[GraphQL: oracleDatabaseLogBackupConfig]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryOracle -RacLogBackupConfig
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryOracle -RacLogBackupConfig -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryOracle -RacLogBackupConfig -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryOracle -RacLogBackupConfig" @"
    Oracle log backup configuration for an Oracle RAC.
"@ "[GraphQL: oracleRacLogBackupConfig]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQuerySla -Domains
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -Domains -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -Domains -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQuerySla -Domains" @"
    Retrieves a list of SLA Domains.
"@ "[GraphQL: slaDomains]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -GlobalFilterList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -GlobalFilterList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -GlobalFilterList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQuerySla -GlobalFilterList" @"
    Retrieves a list of SLA Domains.
"@ "[GraphQL: globalSlaFilterConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -Domain
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -Domain -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -Domain -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQuerySla -Domain" @"
    Query that retrieves an SLA Domain.
"@ "[GraphQL: slaDomain]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -CountOfObjectsProtected
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -CountOfObjectsProtected -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -CountOfObjectsProtected -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQuerySla -CountOfObjectsProtected" @"
    The number of objects protected by the SLA Domains.
"@ "[GraphQL: countOfObjectsProtectedBySlas]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -AuditDetail
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -AuditDetail -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -AuditDetail -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQuerySla -AuditDetail" @"
    List of audit details for a given SLA Domain.
"@ "[GraphQL: slaAuditDetail]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -AllSummariesByIds
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -AllSummariesByIds -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -AllSummariesByIds -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.slaIds = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscQuerySla -AllSummariesByIds" @"
    List of SLA Domain summaries for the given IDs.
"@ "[GraphQL: allSlaSummariesByIds]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -GlobalStatuses
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -GlobalStatuses -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -GlobalStatuses -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQuerySla -GlobalStatuses" @"
    Status on the clusters where global SLA is synced.
"@ "[GraphQL: globalSlaStatuses]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -ConflictObjects
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -ConflictObjects -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -ConflictObjects -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fids = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscQuerySla -ConflictObjects" @"
    Conflicting objects for an SLA Domain assignment.
"@ "[GraphQL: slaConflictObjects]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -ManagedVolumes
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -ManagedVolumes -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -ManagedVolumes -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQuerySla -ManagedVolumes" @"
    Paginated list of SLA Managed Volumes.
"@ "[GraphQL: slaManagedVolumes]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -ManagedVolume
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -ManagedVolume -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -ManagedVolume -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQuerySla -ManagedVolume" @"
    Details of a SLA Managed Volume object.
"@ "[GraphQL: slaManagedVolume]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQuerySla -AllNcdComplianceData
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQuerySla -AllNcdComplianceData -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQuerySla -AllNcdComplianceData -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusters = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscQuerySla -AllNcdComplianceData" @"
    NAS Cloud Direct SLA Domain compliance data for the requested clusters.
"@ "[GraphQL: allNcdSlaComplianceData]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -Vcenter
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -Vcenter -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -Vcenter -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVcenter -Vcenter" @"
    
"@ "[GraphQL: vSphereVCenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -List
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -List -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -List -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVcenter -List" @"
    
"@ "[GraphQL: vSphereVCenterConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -PreAddInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -PreAddInfo -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -PreAddInfo -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVcenter -PreAddInfo" @"
    Get preAddInfo for a vcenter.
"@ "[GraphQL: vCenterPreAddInfo]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -Networks
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -Networks -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -Networks -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryVcenter -Networks" @"
    Get the user-configured networks in the vCenter

Supported in v5.3+
Get the names and IDs of the user configured networks in the vCenter. This information enables users to choose a desired network for backups to go through for VMware Cloud on AWS setups.
"@ "[GraphQL: vCenterNetworks]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -HotAddNetwork
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -HotAddNetwork -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -HotAddNetwork -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryVcenter -HotAddNetwork" @"
    Retrieve the user-configured network for HotAdd operations

Supported in v5.3+
Retrieve the user-configured network for HotAdd backup and recovery operations on VMware on AWS.
"@ "[GraphQL: vCenterHotAddNetwork]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -NumProxiesNeeded
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -NumProxiesNeeded -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -NumProxiesNeeded -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryVcenter -NumProxiesNeeded" @"
    Get the number of HotAdd proxies needed for the vCenter

Supported in v5.3+
Get the number of HotAdd proxies that need to be deployed to the vCenter to support the maximum number of ingest jobs.
"@ "[GraphQL: vCenterNumProxiesNeeded]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -HotAddProxy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -HotAddProxy -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -HotAddProxy -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuids = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscQueryVcenter -HotAddProxy" @"
    Get a list of HotAdd proxy virtual machines

Supported in v5.3+
Retrieve summary information for all HotAdd proxy virtual machines.
"@ "[GraphQL: allVcenterHotAddProxyVms]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -HotAddBandwidth
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -HotAddBandwidth -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -HotAddBandwidth -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryVcenter -HotAddBandwidth" @"
    Get the ingest and export bandwidth limits for HotAdd with the vCenter

Supported in v5.3+
Get the ingest and export bandwidth limits in Mbps when using HotAdd with the vCenter. These limits are shared across all HotAdd proxies for the Center.
"@ "[GraphQL: vCenterHotAddBandwidth]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVcenter -AdvancedTagPreview
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVcenter -AdvancedTagPreview -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVcenter -AdvancedTagPreview -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVcenter -AdvancedTagPreview" @"
    Preview list of virtual machines of a proposed filter condition

Supported in v7.0+
Preview list of virtual machines of a proposed filter condition. The result might not be accurate if new virtual machines were added after last vCenter refresh.
"@ "[GraphQL: vCenterAdvancedTagPreview]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -Datacenter
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -Datacenter -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -Datacenter -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -Datacenter" @"
    
"@ "[GraphQL: vSphereDatacenter]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -ComputeCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -ComputeCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -ComputeCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -ComputeCluster" @"
    
"@ "[GraphQL: vSphereComputeCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -ResourcePool
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -ResourcePool -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -ResourcePool -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -ResourcePool" @"
    
"@ "[GraphQL: vSphereResourcePool]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -Folder
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -Folder -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -Folder -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -Folder" @"
    
"@ "[GraphQL: vSphereFolder]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -Host
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -Host -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -Host -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -Host" @"
    
"@ "[GraphQL: vSphereHost]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -DatastoreCluster
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -DatastoreCluster -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -DatastoreCluster -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -DatastoreCluster" @"
    Vsphere datastore cluster based on id passed in.
"@ "[GraphQL: vSphereDatastoreCluster]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -Datastore
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -Datastore -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -Datastore -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -Datastore" @"
    Vsphere datastore based on id passed in.
"@ "[GraphQL: vSphereDatastore]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -HostsByFids
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -HostsByFids -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -HostsByFids -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fids = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscQueryVsphere -HostsByFids" @"
    All of the VSphere hosts based on fids passed in.
"@ "[GraphQL: vSphereHostsByFids]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -Tag
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -Tag -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -Tag -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -Tag" @"
    
"@ "[GraphQL: vSphereTag]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -TagCategory
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -TagCategory -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -TagCategory -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -TagCategory" @"
    
"@ "[GraphQL: vSphereTagCategory]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -Network
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -Network -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -Network -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -Network" @"
    
"@ "[GraphQL: vSphereNetwork]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -TopLevelDescendantsList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -TopLevelDescendantsList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -TopLevelDescendantsList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -TopLevelDescendantsList" @"
    
"@ "[GraphQL: vSphereTopLevelDescendantsConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -RootRecoveryHierarchy
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -RootRecoveryHierarchy -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -RootRecoveryHierarchy -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -RootRecoveryHierarchy" @"
    The root hierarchy for VMware export, which includes VMware compute clusters and standalone hosts.
"@ "[GraphQL: vSphereRootRecoveryHierarchy]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -HostList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -HostList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -HostList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -HostList" @"
    
"@ "[GraphQL: vSphereHostConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -Folders
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -Folders -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -Folders -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -Folders" @"
    Get all the vSphere folders.
"@ "[GraphQL: vSphereFolders]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -ComputeClusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -ComputeClusters -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -ComputeClusters -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -ComputeClusters" @"
    Query compute clusters
"@ "[GraphQL: vSphereComputeClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -DatastoreList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -DatastoreList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -DatastoreList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -DatastoreList" @"
    
"@ "[GraphQL: vSphereDatastoreConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -DatastoreClusters
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -DatastoreClusters -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -DatastoreClusters -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -DatastoreClusters" @"
    Query vSphere datastore clusters.
"@ "[GraphQL: vSphereDatastoreClusters]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -LiveMounts
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -LiveMounts -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -LiveMounts -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -LiveMounts" @"
    List of vSphere Live Mounts.
"@ "[GraphQL: vSphereLiveMounts]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -MountList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -MountList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -MountList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphere -MountList" @"
    vSphere Live Mount Connection
"@ "[GraphQL: vSphereMountConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -Mount
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -Mount -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -Mount -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphere -Mount" @"
    Get a vSphere Live Mount by id
"@ "[GraphQL: vSphereMount]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -HostDetails
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -HostDetails -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -HostDetails -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.input = @{
	# REQUIRED
	id = <System.String>
}
"@
    Write-Message "Invoke-RscQueryVsphere -HostDetails" @"
    Get details of a ESXi hypervisor

Supported in v5.0+
Get details of a ESXi hypervisor.
"@ "[GraphQL: vSphereHostDetails]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphere -VmwareCdpLiveInfo
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphere -VmwareCdpLiveInfo -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphere -VmwareCdpLiveInfo -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.ids = @(
	<System.String>
)
"@
    Write-Message "Invoke-RscQueryVsphere -VmwareCdpLiveInfo" @"
    
"@ "[GraphQL: vsphereVmwareCdpLiveInfo]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}


# -------------------------------------------------------------------
# Invoke-RscQueryVsphereVm -New
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphereVm -New -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphereVm -New -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.fid = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphereVm -New" @"
    
"@ "[GraphQL: vSphereVmNew]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphereVm -NewList
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphereVm -NewList -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphereVm -NewList -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphereVm -NewList" @"
    
"@ "[GraphQL: vSphereVmNewConnection]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphereVm -AsyncRequestStatus
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphereVm -AsyncRequestStatus -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphereVm -AsyncRequestStatus -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.clusterUuid = <System.String>
# REQUIRED
$inputs.Var.id = <System.String>
"@
    Write-Message "Invoke-RscQueryVsphereVm -AsyncRequestStatus" @"
    
"@ "[GraphQL: vSphereVMAsyncRequestStatus]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphereVm -RecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphereVm -RecoverableRange -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphereVm -RecoverableRange -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.beforeTime = <DateTime>
# OPTIONAL
$inputs.Var.afterTime = <DateTime>
"@
    Write-Message "Invoke-RscQueryVsphereVm -RecoverableRange" @"
    
"@ "[GraphQL: vsphereVMRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphereVm -RecoverableRangeInBatch
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphereVm -RecoverableRangeInBatch -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphereVm -RecoverableRangeInBatch -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
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
    Write-Message "Invoke-RscQueryVsphereVm -RecoverableRangeInBatch" @"
    
"@ "[GraphQL: vsphereVMRecoverableRangeInBatch]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

# -------------------------------------------------------------------
# Invoke-RscQueryVsphereVm -MissedRecoverableRange
# -------------------------------------------------------------------

if ($GetGqlRequest) {
    (Invoke-RscQueryVsphereVm -MissedRecoverableRange -GetGqlRequest).SaveQueryToFile()
} else {
    $inputs = Invoke-RscQueryVsphereVm -MissedRecoverableRange -GetInput
    $fieldTypeName = $inputs.Field.GetType().Name
    $argNames = $inputs.Arg.Keys
    Write-Message @"
    # REQUIRED
$inputs.Var.snappableFid = <System.String>
# OPTIONAL
$inputs.Var.beforeTime = <DateTime>
# OPTIONAL
$inputs.Var.afterTime = <DateTime>
"@
    Write-Message "Invoke-RscQueryVsphereVm -MissedRecoverableRange" @"
    
"@ "[GraphQL: vsphereVMMissedRecoverableRange]${nl}[Field: ${fieldTypeName}]${nl}[Args: ${argNames}]"
}

