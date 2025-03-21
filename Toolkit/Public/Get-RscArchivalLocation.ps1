#Requires -Version 3
function Get-RscArchivalLocation {
    <#
    .SYNOPSIS
    Retrieves Archival Locations in Rubrik Security Cloud

    .DESCRIPTION
    Archival Locations represent targets for long-term storage of backups.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all archival locations
    Get-RscArchivalLocation

    .EXAMPLE
    # Get Datacenter archival locations
    Get-RscArchivalLocation -

    .EXAMPLE
    # Get VMs by specifying part of a name
    Get-RscVmwareVm
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [String]$Id,
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$Name
    )
    
    Process {

        function createQuery {
            param (
                $queryName
            )
            
        }

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -GqlQuery targetMapping
            $query.var.targetMappingId = $Id

            $query.Field.id = "FETCH"
            $query.Field.name = "FETCH"
            $query.Field.groupType = [RubrikSecurityCloud.Types.ArchivalGroupType]::UNKNOWN_ARCHIVAL_GROUP
            $query.Field.targetType = [RubrikSecurityCloud.Types.TargetType]::AWS
            $query.Field.connectionStatus = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalGroupConnectionStatus
            $query.Field.connectionStatus.status = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field.tieringStatus = @([RubrikSecurityCloud.Types.ArchivalGroupTieringStatus]::UNKNOWN_ARCHIVAL_GROUP_TIERING_STATUS)

            $query.Field.targets = New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedAwsTarget
            $query.Field.targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedAzureTarget))
            #$query.Field.targets[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            #$query.Field.targets[0].cluster.name = "FETCH"
            #$query.Field.targets[0].cluster.id = "FETCH"
            #$query.Field.targets[0].targetType = [RubrikSecurityCloud.Types.TargetType]::AWS
            #$query.Field.targets[0].id = "FETCH"
            #$query.Field.targets[0].name = "FETCH"
            #$query.Field.targets[0].locationScope = [RubrikSecurityCloud.Types.LocationScope]::UNKNOWN
            #$query.Field.targets[0].isActive = $true
            #$query.Field.targets[0].isArchived = $true
            #$query.Field.targets[0].targetMapping = New-Object -TypeName RubrikSecurityCloud.Types.TargetMappingBasic
            #$query.Field.targets[0].targetMapping.name = "FETCH"
            #$query.Field.targets[0].targetMapping.id = "FETCH"
            #$query.Field.targets[0].clusterName = "FETCH"
            #$query.Field.targets[0].status = [RubrikSecurityCloud.Types.ArchivalLocationStatus]::UNKNOWN_ARCHIVAL_LOCATION_STATUS
            #$query.Field.targets[0].upgradeStatus = [RubrikSecurityCloud.Types.UpgradeStatus]::UPGRADE_UNSUPPORTED
            #$query.Field.targets[0].consumedBytes = 1
            #$query.Field.targets[0].runningTasks = 1
            #$query.Field.targets[0].failedTasks = 1
            #$query.Field.targets[0].readerRetrievalMethod = [RubrikSecurityCloud.Types.ReaderRetrievalMethod]::UNKNOWN_RETRIEVAL_METHOD
            #$query.Field.targets[0].locationConnectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
        } else {
            $query = New-RscQuery -GqlQuery allTargetMappings
            $query2 = New-RscQuery -GqlQuery targets
            $query.var.filter = @()
            $query.var.filter += New-Object -TypeName RubrikSecurityCloud.Types.TargetMappingFilterInput
            $query.var.filter[0].field = [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::ARCHIVAL_GROUP_TYPE
            $query.var.filter[0].text = "CLOUD_NATIVE_ARCHIVAL_GROUP"
            
            if ($Name) {
                $query.var.filter += New-Object -TypeName RubrikSecurityCloud.Types.TargetMappingFilterInput
                $query.var.filter[1].field = [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::NAME
                $query.var.filter[1].text = $Name
            }

            $query.Field[0].id = "FETCH"
            $query.Field[0].name = "FETCH"
            $query.Field[0].groupType = [RubrikSecurityCloud.Types.ArchivalGroupType]::UNKNOWN_ARCHIVAL_GROUP
            $query.Field[0].targetType = [RubrikSecurityCloud.Types.TargetType]::AWS
            $query.Field[0].connectionStatus = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalGroupConnectionStatus
            $query.Field[0].connectionStatus.status = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].tieringStatus = @([RubrikSecurityCloud.Types.ArchivalGroupTieringStatus]::UNKNOWN_ARCHIVAL_GROUP_TIERING_STATUS)

            $query.Field[0].targets = New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedAwsTarget
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedAzureTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedGcpTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedGlacierTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedNfsTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedRcsTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedS3CompatibleTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedTapeTargetType))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.CdmManagedAwsTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.CdmManagedAzureTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.CdmManagedGcpTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.CdmManagedGlacierTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.CdmManagedNfsTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.CdmManagedS3CompatibleTarget))
            $query.Field[0].targets.add((New-Object -TypeName RubrikSecurityCloud.Types.CdmManagedTapeTarget))

            # Add common fields to each object type in query (List of fields is from generic Target type in API)
            foreach ($targetType in $query.Field[0].targets) {
                $targetType.name = "FETCH"
                $targetType.id = "FETCH"
                $targetType.cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
                $targetType.cluster.name = "FETCH"
                $targetType.cluster.id = "FETCH"
                $targetType.targetType = [RubrikSecurityCloud.Types.TargetType]::AWS
                $targetType.locationScope = [RubrikSecurityCloud.Types.LocationScope]::UNKNOWN
                $targetType.isActive = $true
                $targetType.isArchived = $true
                $targetType.targetMapping = New-Object -TypeName RubrikSecurityCloud.Types.TargetMappingBasic
                $targetType.targetMapping.name = "FETCH"
                $targetType.targetMapping.id = "FETCH"
                $targetType.clusterName = "FETCH"
                $targetType.status = [RubrikSecurityCloud.Types.ArchivalLocationStatus]::UNKNOWN_ARCHIVAL_LOCATION_STATUS
                $targetType.upgradeStatus = [RubrikSecurityCloud.Types.UpgradeStatus]::UPGRADE_UNSUPPORTED
                $targetType.consumedBytes = 1
                $targetType.runningTasks = 1
                $targetType.failedTasks = 1
                $targetType.readerRetrievalMethod = [RubrikSecurityCloud.Types.ReaderRetrievalMethod]::UNKNOWN_RETRIEVAL_METHOD
                $targetType.locationConnectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            }

            ### CdmManagedAwsTarget
            $CdmManagedAwsTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "CdmManagedAwsTarget"})
            $query.Field[0].targets[$CdmManagedAwsTarget].region = [RubrikSecurityCloud.Types.AwsRegion]::US_EAST_1
            $query.Field[0].targets[$CdmManagedAwsTarget].immutabilitySettings = New-Object -TypeName RubrikSecurityCloud.Types.AwsImmutabilitySettingsType
            $query.Field[0].targets[$CdmManagedAwsTarget].immutabilitySettings.lockDurationDays = 1
            $query.Field[0].targets[$CdmManagedAwsTarget].storageClass = [RubrikSecurityCloud.Types.AwsStorageClass]::STANDARD

            ### CdmManagedAzureTarget
            $CdmManagedAzureTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "CdmManagedAzureTarget"})
            $query.Field[0].targets[$CdmManagedAzureTarget].immutabilitySettings = New-Object -TypeName RubrikSecurityCloud.Types.AzureImmutabilitySettingsType
            $query.Field[0].targets[$CdmManagedAzureTarget].immutabilitySettings.lockDurationDays = 1
            $query.Field[0].targets[$CdmManagedAzureTarget].immutabilitySettings.isBlobImmutabilityEnabled = $true
            $query.Field[0].targets[$CdmManagedAzureTarget].isAzureTieringSupported = $true
            $query.Field[0].targets[$CdmManagedAzureTarget].instanceType = [RubrikSecurityCloud.Types.InstanceTypeEnum]::AZURE_DEFAULT

            ### CdmManagedGcpTarget
            #$CdmManagedGcpTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "CdmManagedGcpTarget"})
            #$query.Field[0].targets[$CdmManagedGcpTarget].region = [RubrikSecurityCloud.Types.GcpRegion]::USEAS_T1

            ### CdmManagedGlacierTarget
            $CdmManagedGlacierTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "CdmManagedGlacierTarget"})
            $query.Field[0].targets[$CdmManagedGlacierTarget].region = [RubrikSecurityCloud.Types.AwsRegion]::US_EAST_1

            ### CdmManagedNfsTarget
            $CdmManagedNfsTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "CdmManagedNfsTarget"})
            $query.Field[0].targets[$CdmManagedNfsTarget].host = "FETCH"

            ### CdmManagedS3CompatibleTarget
            $CdmManagedS3CompatibleTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "CdmManagedS3CompatibleTarget"})
            $query.Field[0].targets[$CdmManagedS3CompatibleTarget].endpoint = "FETCH"

            ### CdmManagedTapeTarget
            $CdmManagedTapeTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "CdmManagedTapeTarget"})
            $query.Field[0].targets[$CdmManagedTapeTarget].hostName = "FETCH"

            ### RubrikManagedAwsTarget
            $RubrikManagedAwsTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedAwsTarget"})
            $query.Field[0].targets[$RubrikManagedAwsTarget].cloudnativeLocTemplateType = [RubrikSecurityCloud.Types.CloudNativeLocTemplateType]::INVALID
            $query.Field[0].targets[$RubrikManagedAwsTarget].s3Endpoint = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].kmsEndpoint = "FETCH"
            # May run into issues here if it's AwsRoleBasedAccount, but I don't have a constructor for generic cloudAccount
            $query.Field[0].targets[$RubrikManagedAwsTarget].cloudAccount = New-Object -TypeName RubrikSecurityCloud.Types.AwsAccount
            $query.Field[0].targets[$RubrikManagedAwsTarget].cloudAccount.cloudAccountId = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].cloudAccount.name = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].bucket = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].region = [RubrikSecurityCloud.Types.AwsRegion]::US_EAST_1
            $query.Field[0].targets[$RubrikManagedAwsTarget].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED
            $query.Field[0].targets[$RubrikManagedAwsTarget].awsRetrievalTier = [RubrikSecurityCloud.Types.AwsRetrievalTier]::STANDARD_TIER
            $query.Field[0].targets[$RubrikManagedAwsTarget].computeSettings = New-Object -TypeName RubrikSecurityCloud.Types.AwsComputeSettings
            $query.Field[0].targets[$RubrikManagedAwsTarget].computeSettings.name = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].computeSettings.id = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].proxySettings = New-Object -TypeName RubrikSecurityCloud.Types.ProxySettings
            $query.Field[0].targets[$RubrikManagedAwsTarget].proxySettings.proxyServer = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].encryptionType = [RubrikSecurityCloud.Types.TargetEncryptionTypeEnum]::KMS_MASTER_KEY_BASED
            $query.Field[0].targets[$RubrikManagedAwsTarget].kmsMasterKeyId = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].isConsolidationEnabled = $true
            $query.Field[0].targets[$RubrikManagedAwsTarget].syncFailureReason = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].targets[$RubrikManagedAwsTarget].bypassProxy = $true
            $query.Field[0].targets[$RubrikManagedAwsTarget].immutabilitySettings = New-Object -TypeName RubrikSecurityCloud.Types.AwsImmutabilitySettingsType
            $query.Field[0].targets[$RubrikManagedAwsTarget].immutabilitySettings.lockDurationDays = 1
            $query.Field[0].targets[$RubrikManagedAwsTarget].storageClass = [RubrikSecurityCloud.Types.AwsStorageClass]::STANDARD

            ### RubrikManagedAzureTarget
            $RubrikManagedAzureTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedAzureTarget"})
            $query.Field[0].targets[$RubrikManagedAzureTarget].computeSettings = New-Object -TypeName RubrikSecurityCloud.Types.AzureComputeSettings
            $query.Field[0].targets[$RubrikManagedAzureTarget].computeSettings.appId = "FETCH"
            $query.Field[0].targets[$RubrikManagedAzureTarget].cloudAccount = New-Object -TypeName RubrikSecurityCloud.Types.AzureAccount
            $query.Field[0].targets[$RubrikManagedAzureTarget].cloudAccount.cloudAccountId = "FETCH"
            $query.Field[0].targets[$RubrikManagedAzureTarget].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].targets[$RubrikManagedAzureTarget].immutabilitySettings = New-Object -TypeName RubrikSecurityCloud.Types.AzureImmutabilitySettingsType
            $query.Field[0].targets[$RubrikManagedAzureTarget].immutabilitySettings.lockDurationDays = 1
            $query.Field[0].targets[$RubrikManagedAzureTarget].immutabilitySettings.isBlobImmutabilityEnabled = $true
            $query.Field[0].targets[$RubrikManagedAzureTarget].storageAccountName = "FETCH"
            $query.Field[0].targets[$RubrikManagedAzureTarget].containerName = "FETCH"
            $query.Field[0].targets[$RubrikManagedAzureTarget].isAzureTieringSupported = $true
            $query.Field[0].targets[$RubrikManagedAzureTarget].instanceType = [RubrikSecurityCloud.Types.InstanceTypeEnum]::AZURE_DEFAULT
            $query.Field[0].targets[$RubrikManagedAzureTarget].proxySettings = New-Object -TypeName RubrikSecurityCloud.Types.ProxySettings
            $query.Field[0].targets[$RubrikManagedAzureTarget].proxySettings.proxyServer = "FETCH"
            $query.Field[0].targets[$RubrikManagedAzureTarget].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED
            $query.Field[0].targets[$RubrikManagedAzureTarget].isConsolidationEnabled = $true
            $query.Field[0].targets[$RubrikManagedAzureTarget].syncFailureReason = "FETCH"
            $query.Field[0].targets[$RubrikManagedAzureTarget].retrievalTier = [RubrikSecurityCloud.Types.AzureRetrievalTier]::STANDARD_AZURE_TIER
            $query.Field[0].targets[$RubrikManagedAzureTarget].bypassProxy = $true

            ### RubrikManagedGcpTarget
            ### TODO... Enums need fixed in SDK.

            ### RubrikManagedNfsTarget
            $RubrikManagedNfsTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedNfsTarget"})
            $query.Field[0].targets[$RubrikManagedNfsTarget].host = "FETCH"
            $query.Field[0].targets[$RubrikManagedNfsTarget].nfsAuthType = [RubrikSecurityCloud.Types.AuthTypeEnum]::KERBEROS
            $query.Field[0].targets[$RubrikManagedNfsTarget].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].targets[$RubrikManagedNfsTarget].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED
            $query.Field[0].targets[$RubrikManagedNfsTarget].exportDir = "FETCH"
            $query.Field[0].targets[$RubrikManagedNfsTarget].nfsVersion = 1
            $query.Field[0].targets[$RubrikManagedNfsTarget].otherNfsOptions = "FETCH"
            $query.Field[0].targets[$RubrikManagedNfsTarget].fileLockPeriodInSeconds = 1
            $query.Field[0].targets[$RubrikManagedNfsTarget].destinationFolder = "FETCH"
            $query.Field[0].targets[$RubrikManagedNfsTarget].isConsolidationEnabled = $true
            $query.Field[0].targets[$RubrikManagedNfsTarget].syncFailureReason = "FETCH"

            ### RubrikManagedGlacierTarget
            $RubrikManagedGlacierTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedGlacierTarget"})
            $query.Field[0].targets[$RubrikManagedGlacierTarget].cloudAccount = New-Object -TypeName RubrikSecurityCloud.Types.AwsAccount
            $query.Field[0].targets[$RubrikManagedGlacierTarget].cloudAccount.cloudAccountId = "FETCH"
            $query.Field[0].targets[$RubrikManagedGlacierTarget].cloudAccount.name = "FETCH"
            $query.Field[0].targets[$RubrikManagedGlacierTarget].vaultName = "FETCH"
            $query.Field[0].targets[$RubrikManagedGlacierTarget].region = [RubrikSecurityCloud.Types.AwsRegion]::US_EAST_1
            $query.Field[0].targets[$RubrikManagedGlacierTarget].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED
            $query.Field[0].targets[$RubrikManagedGlacierTarget].syncFailureReason = "FETCH"
            $query.Field[0].targets[$RubrikManagedGlacierTarget].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED

            ### RubrikManagedRcsTarget (RCV)
            $RubrikManagedRcsTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedRcsTarget"})
            $query.Field[0].targets[$RubrikManagedRcsTarget].shouldBypassProxy = $true
            $query.Field[0].targets[$RubrikManagedRcsTarget].isVersionLevelImmutabilityEnabled = $true
            $query.Field[0].targets[$RubrikManagedRcsTarget].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED 
            #REGION CONFLICT IN SDK
            #$query.Field[0].targets[$RubrikManagedRcsTarget].region = [RubrikSecurityCloud.Types.RcsRegionEnumType]::US_EAST
            $query.Field[0].targets[$RubrikManagedRcsTarget].tier = [RubrikSecurityCloud.Types.RcsTierEnumType]::ARCHIVE
            # MISSING ENUMS IN SDK
            #$query.Field[0].targets[$RubrikManagedRcsTarget].redundancy = [RubrikSecurityCloud.Types.RcvRedundancy]::UNKNOWN_AZURE_REDUNDANCY
            #$query.Field[0].targets[$RubrikManagedRcsTarget].redundancyState = [RubrikSecurityCloud.Types.RcvRedundancyState]::UNKNOWN_REDUNDANCY_STATE
            #$query.Field[0].targets[$RubrikManagedRcsTarget].lastRedundancySyncTime = [datetime]"2000-01-01"
            $query.Field[0].targets[$RubrikManagedRcsTarget].spaceUsageAlertThreshold = 1
            $query.Field[0].targets[$RubrikManagedRcsTarget].syncFailureReason = "FETCH"
            $query.Field[0].targets[$RubrikManagedRcsTarget].storageConsumptionValue = 1
            $query.Field[0].targets[$RubrikManagedRcsTarget].immutabilityPeriodDays = 1
            $query.Field[0].targets[$RubrikManagedRcsTarget].privateEndpointConnection = New-Object -TypeName RubrikSecurityCloud.Types.PrivateEndpointConnection
            $query.Field[0].targets[$RubrikManagedRcsTarget].privateEndpointConnection.privateEndpointId = "FETCH"
            $query.Field[0].targets[$RubrikManagedRcsTarget].privateEndpointConnection.privateEndpointConnectionStatus = [RubrikSecurityCloud.Types.PrivateEndpointConnectionStatus]::APPROVED

            ### RubrikManagedS3CompatibleTarget
            $RubrikManagedS3CompatibleTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedS3CompatibleTarget"})
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].endpoint = "FETCH"
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].bucketPrefix = "FETCH"
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].numberOfBuckets = 1
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].subType = [RubrikSecurityCloud.Types.S3CompatibleSubType]::DEFAULT
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].ibmDetail = New-Object RubrikSecurityCloud.Types.IbmCosDetailsType
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].ibmDetail.provisioningCode = "FETCH"
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].ibmDetail.deploymentType = [RubrikSecurityCloud.Types.IbmDeploymentType]::CLOUD
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].immutabilitySetting = New-Object -TypeName RubrikSecurityCloud.Types.LocationImmutabilityType
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].immutabilitySetting.bucketLockDurationDays = 1
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].isConsolidationEnabled = $true
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].encryptionType = [RubrikSecurityCloud.Types.TargetEncryptionTypeEnum]::UNKNOWN_ENCRYPTION_TYPE
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].useSystemProxy = $true
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].syncFailureReason = "FETCH"

            ### RubrikManagedTapeTarget
            $RubrikManagedTapeTargetType = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedTapeTargetType"})
            $query.Field[0].targets[$RubrikManagedTapeTargetType].hostName = "FETCH"
            $query.Field[0].targets[$RubrikManagedTapeTargetType].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].targets[$RubrikManagedTapeTargetType].hostPort = 1
            $query.Field[0].targets[$RubrikManagedTapeTargetType].integralVolumeName = "FETCH"
            $query.Field[0].targets[$RubrikManagedTapeTargetType].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED
            $query.Field[0].targets[$RubrikManagedTapeTargetType].destinationFolderName = "FETCH"
            $query.Field[0].targets[$RubrikManagedTapeTargetType].syncFailureReason = "FETCH"

        }
        $result = Invoke-Rsc $query
        $result.targets
    } 
}
