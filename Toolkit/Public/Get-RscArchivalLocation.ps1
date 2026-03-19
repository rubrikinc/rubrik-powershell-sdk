#Requires -Version 3
function Get-RscArchivalLocation {
    <#
    .SYNOPSIS
    Retrieves archival locations configured in Rubrik Security Cloud.

    .DESCRIPTION
    Returns archival locations (target mappings) that represent long-term storage
    targets for backups, such as AWS S3, Azure Blob, GCP, NFS, tape, and
    Rubrik Cloud Vault (RCV). Use -Name to filter by location name, or -Id to
    retrieve a single archival location by its RSC identifier.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Id
    The RSC object ID.

    .PARAMETER Name
    Filter by name. Matches archival locations whose name contains the specified string.

    .PARAMETER GroupType
    Filter by archival group type. If not specified, all group types are returned.
    Valid values: CLOUD_NATIVE_ARCHIVAL_GROUP, DATACENTER_ARCHIVAL_GROUP,
    AUTOMATIC_ARCHIVAL_GROUP, MANUAL_ARCHIVAL_GROUP.

    .EXAMPLE
    # Get all archival locations
    Get-RscArchivalLocation

    .EXAMPLE
    # Get archival locations matching a name
    Get-RscArchivalLocation -Name "S3-Production"

    .EXAMPLE
    # Get only cloud-native archival locations
    Get-RscArchivalLocation -GroupType CLOUD_NATIVE_ARCHIVAL_GROUP

    .EXAMPLE
    # Get a specific archival location by ID
    Get-RscArchivalLocation -Id "a1b2c3d4-e5f6-7890-abcd-ef1234567890"
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
        [String]$Name,
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [ValidateSet(
            "CLOUD_NATIVE_ARCHIVAL_GROUP",
            "DATACENTER_ARCHIVAL_GROUP",
            "AUTOMATIC_ARCHIVAL_GROUP",
            "MANUAL_ARCHIVAL_GROUP"
        )]
        [String]$GroupType,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )

    Process {

        # Shared helper: populate top-level TargetMapping field spec.
        function Set-MappingFields($mapping) {
            $mapping.id = "FETCH"
            $mapping.name = "FETCH"
            $mapping.groupType = [RubrikSecurityCloud.Types.ArchivalGroupType]::UNKNOWN_ARCHIVAL_GROUP
            $mapping.targetType = [RubrikSecurityCloud.Types.TargetType]::AWS
            $mapping.connectionStatus = Get-RscType -Name ArchivalGroupConnectionStatus -InitialProperties @("status")
            $mapping.tieringStatus = @([RubrikSecurityCloud.Types.ArchivalGroupTieringStatus]::UNKNOWN_ARCHIVAL_GROUP_TIERING_STATUS)
        }

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -Gql targetMapping
            $query.var.targetMappingId = $Id
            Set-MappingFields $query.Field

            $query.Field.targets = New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedAwsTarget
            $query.Field.targets.add((New-Object -TypeName RubrikSecurityCloud.Types.RubrikManagedAzureTarget))
        } else {
            $query = New-RscQuery -Gql allTargetMappings
            $query.var.filter = @()
            if ($GroupType) {
                $f = New-Object -TypeName RubrikSecurityCloud.Types.TargetMappingFilterInput
                $f.field = [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::ARCHIVAL_GROUP_TYPE
                $f.text = $GroupType
                $query.var.filter += $f
            }
            if ($Name) {
                $f = New-Object -TypeName RubrikSecurityCloud.Types.TargetMappingFilterInput
                $f.field = [RubrikSecurityCloud.Types.TargetMappingQueryFilterField]::NAME
                $f.text = $Name
                $query.var.filter += $f
            }

            Set-MappingFields $query.Field[0]

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
                $targetType.cluster = Get-RscType -Name Cluster -InitialProperties Name, Id
                $targetType.targetType = [RubrikSecurityCloud.Types.TargetType]::AWS
                $targetType.locationScope = [RubrikSecurityCloud.Types.LocationScope]::UNKNOWN
                $targetType.isActive = $true
                $targetType.isArchived = $true
                $targetType.targetMapping = Get-RscType -Name TargetMappingBasic -InitialProperties Name, Id
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
            $query.Field[0].targets[$CdmManagedAwsTarget].immutabilitySettings = Get-RscType -Name AwsImmutabilitySettingsType -InitialProperties @("lockDurationDays")
            $query.Field[0].targets[$CdmManagedAwsTarget].storageClass = [RubrikSecurityCloud.Types.AwsStorageClass]::STANDARD

            ### CdmManagedAzureTarget
            $CdmManagedAzureTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "CdmManagedAzureTarget"})
            $query.Field[0].targets[$CdmManagedAzureTarget].immutabilitySettings = Get-RscType -Name AzureImmutabilitySettingsType -InitialProperties @("lockDurationDays", "isBlobImmutabilityEnabled")
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
            $query.Field[0].targets[$RubrikManagedAwsTarget].cloudAccount = Get-RscType -Name AwsAccount -InitialProperties @("cloudAccountId", "name")
            $query.Field[0].targets[$RubrikManagedAwsTarget].bucket = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].region = [RubrikSecurityCloud.Types.AwsRegion]::US_EAST_1
            $query.Field[0].targets[$RubrikManagedAwsTarget].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED
            $query.Field[0].targets[$RubrikManagedAwsTarget].awsRetrievalTier = [RubrikSecurityCloud.Types.AwsRetrievalTier]::STANDARD_TIER
            $query.Field[0].targets[$RubrikManagedAwsTarget].computeSettings = Get-RscType -Name AwsComputeSettings -InitialProperties Name, Id
            $query.Field[0].targets[$RubrikManagedAwsTarget].proxySettings = Get-RscType -Name ProxySettings -InitialProperties @("proxyServer")
            $query.Field[0].targets[$RubrikManagedAwsTarget].encryptionType = [RubrikSecurityCloud.Types.TargetEncryptionTypeEnum]::KMS_MASTER_KEY_BASED
            $query.Field[0].targets[$RubrikManagedAwsTarget].kmsMasterKeyId = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].isConsolidationEnabled = $true
            $query.Field[0].targets[$RubrikManagedAwsTarget].syncFailureReason = "FETCH"
            $query.Field[0].targets[$RubrikManagedAwsTarget].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].targets[$RubrikManagedAwsTarget].bypassProxy = $true
            $query.Field[0].targets[$RubrikManagedAwsTarget].immutabilitySettings = Get-RscType -Name AwsImmutabilitySettingsType -InitialProperties @("lockDurationDays")
            $query.Field[0].targets[$RubrikManagedAwsTarget].storageClass = [RubrikSecurityCloud.Types.AwsStorageClass]::STANDARD

            ### RubrikManagedAzureTarget
            $RubrikManagedAzureTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedAzureTarget"})
            $query.Field[0].targets[$RubrikManagedAzureTarget].computeSettings = Get-RscType -Name AzureComputeSettings -InitialProperties @("appId")
            $query.Field[0].targets[$RubrikManagedAzureTarget].cloudAccount = Get-RscType -Name AzureAccount -InitialProperties @("cloudAccountId")
            $query.Field[0].targets[$RubrikManagedAzureTarget].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].targets[$RubrikManagedAzureTarget].immutabilitySettings = Get-RscType -Name AzureImmutabilitySettingsType -InitialProperties @("lockDurationDays", "isBlobImmutabilityEnabled")
            $query.Field[0].targets[$RubrikManagedAzureTarget].storageAccountName = "FETCH"
            $query.Field[0].targets[$RubrikManagedAzureTarget].containerName = "FETCH"
            $query.Field[0].targets[$RubrikManagedAzureTarget].isAzureTieringSupported = $true
            $query.Field[0].targets[$RubrikManagedAzureTarget].instanceType = [RubrikSecurityCloud.Types.InstanceTypeEnum]::AZURE_DEFAULT
            $query.Field[0].targets[$RubrikManagedAzureTarget].proxySettings = Get-RscType -Name ProxySettings -InitialProperties @("proxyServer")
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
            $query.Field[0].targets[$RubrikManagedGlacierTarget].cloudAccount = Get-RscType -Name AwsAccount -InitialProperties @("cloudAccountId", "name")
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
            $query.Field[0].targets[$RubrikManagedRcsTarget].privateEndpointConnection = Get-RscType -Name PrivateEndpointConnection -InitialProperties @("privateEndpointId", "privateEndpointConnectionStatus")

            ### RubrikManagedS3CompatibleTarget
            $RubrikManagedS3CompatibleTarget = $query.field[0].targets.findIndex({param($item) $item.gettype().name -eq "RubrikManagedS3CompatibleTarget"})
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].endpoint = "FETCH"
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].connectionStatus = [RubrikSecurityCloud.Types.ConnectionStatusType]::CONNECTED
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].syncStatus = [RubrikSecurityCloud.Types.TargetSyncStatus]::SYNCED
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].bucketPrefix = "FETCH"
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].numberOfBuckets = 1
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].subType = [RubrikSecurityCloud.Types.S3CompatibleSubType]::DEFAULT
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].ibmDetail = Get-RscType -Name IbmCosDetailsType -InitialProperties @("provisioningCode", "deploymentType")
            $query.Field[0].targets[$RubrikManagedS3CompatibleTarget].immutabilitySetting = Get-RscType -Name LocationImmutabilityType -InitialProperties @("bucketLockDurationDays")
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
        if ( $AsQuery ) { return $query }
        $result = Invoke-Rsc $query
        $result.targets
    }
}
