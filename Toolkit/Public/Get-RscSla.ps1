#Requires -Version 3
function Get-RscSla {
    <#
    .SYNOPSIS
    Retrieves Global SLA Domains defined in Rubrik Security Cloud 

    .DESCRIPTION
    SLA Domains are policies that define how frequently an object is backed up, how long to retain it,
    and rules regarding replication and archival of protected data.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Return all SLA Domains
    Get-RscSla

    .EXAMPLE
    # Return an SLA Domain with 'Gold' in the name
    Get-RscSla "Gold"

    .EXAMPLE
    # You can pipe the output of the cmdlet to another cmdlet. 
    # In this case, we get a list of VMware VMs that are a member of SLAs with 'gold' in the name.
    Get-RscSla "Gold" | Get-RscVmwareVm
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
             Position = 0,
             ParameterSetName = "Name"
         )]
         [String]$Name
    )
    
    Process {

        if ($Id) {
            $query = New-RscQuery -GqlQuery slaDomain
            $query.var.id = $Id

            #id: String!
            # SLA Domain ID.
            $query.field.id = "FETCH"
            # name: String!
            # SLA Domain name.
            $query.field.name = "FETCH"

            # version: String
            # Version for the SLA Domain.
            $query.field.getNext().version = "FETCH"

            # description: String!
            # Description of the SLA Domain.
            $query.field.getNext().description = "FETCH"

            # protectedObjectCount: Int!
            # Workload count for the SLA Domain.
            $query.field.getNext().protectedObjectCount = 1

            # uiColor: String!
            # Color of the SLA Domain on the User Interface.
            # Skip this. No one here needs UI color.

            # snapshotSchedule: SnapshotSchedule
            # Snapshot schedule for the SLA Domain.
            $query.field.getNext().SnapshotSchedule = New-Object -TypeName RubrikSecurityCloud.Types.SnapshotSchedule
                # minute: MinuteSnapshotSchedule
                # Minute schedule of the SLA Domain.
                $query.field.getNext().SnapshotSchedule.minute = New-Object -TypeName RubrikSecurityCloud.Types.MinuteSnapshotSchedule
                $query.field.getNext().SnapshotSchedule.minute.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.getNext().SnapshotSchedule.minute.basicSchedule.frequency = 1
                $query.field.getNext().SnapshotSchedule.minute.basicSchedule.retention = 1
                $query.field.getNext().SnapshotSchedule.minute.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # hourly: HourlySnapshotSchedule
                # Hourly schedule of the SLA Domain.
                $query.field.getNext().SnapshotSchedule.hourly = New-Object -TypeName RubrikSecurityCloud.Types.HourlySnapshotSchedule
                $query.field.getNext().SnapshotSchedule.hourly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.getNext().SnapshotSchedule.hourly.basicSchedule.frequency = 1
                $query.field.getNext().SnapshotSchedule.hourly.basicSchedule.retention = 1
                $query.field.getNext().SnapshotSchedule.hourly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # daily: DailySnapshotSchedule
                # Daily schedule of the SLA Domain.
                $query.field.getNext().SnapshotSchedule.daily = New-Object -TypeName RubrikSecurityCloud.Types.DailySnapshotSchedule
                $query.field.getNext().SnapshotSchedule.daily.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.getNext().SnapshotSchedule.daily.basicSchedule.frequency = 1
                $query.field.getNext().SnapshotSchedule.daily.basicSchedule.retention = 1
                $query.field.getNext().SnapshotSchedule.daily.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # weekly: WeeklySnapshotSchedule
                # Weekly schedule of the SLA Domain.
                $query.field.getNext().SnapshotSchedule.weekly = New-Object -TypeName RubrikSecurityCloud.Types.WeeklySnapshotSchedule
                $query.field.getNext().SnapshotSchedule.weekly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.getNext().SnapshotSchedule.weekly.basicSchedule.frequency = 1
                $query.field.getNext().SnapshotSchedule.weekly.basicSchedule.retention = 1
                $query.field.getNext().SnapshotSchedule.weekly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                $query.field.getNext().SnapshotSchedule.weekly.dayOfWeek = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
                # monthly: MonthlySnapshotSchedule
                # Monthly schedule of the SLA Domain.
                $query.field.getNext().SnapshotSchedule.monthly = New-Object -TypeName RubrikSecurityCloud.Types.MonthlySnapshotSchedule
                $query.field.getNext().SnapshotSchedule.monthly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.getNext().SnapshotSchedule.monthly.basicSchedule.frequency = 1
                $query.field.getNext().SnapshotSchedule.monthly.basicSchedule.retention = 1
                $query.field.getNext().SnapshotSchedule.monthly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                $query.field.getNext().SnapshotSchedule.monthly.dayOfMonth = [RubrikSecurityCloud.Types.DayOfMonth]::LAST_DAY
                # quarterly: QuarterlySnapshotSchedule
                # Quarterly schedule of the SLA Domain.
                $query.field.getNext().SnapshotSchedule.quarterly = New-Object -TypeName RubrikSecurityCloud.Types.QuarterlySnapshotSchedule
                $query.field.getNext().SnapshotSchedule.quarterly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.getNext().SnapshotSchedule.quarterly.basicSchedule.frequency = 1
                $query.field.getNext().SnapshotSchedule.quarterly.basicSchedule.retention = 1
                $query.field.getNext().SnapshotSchedule.quarterly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                $query.field.getNext().SnapshotSchedule.quarterly.dayOfQuarter = [RubrikSecurityCloud.Types.DayOfQuarter]::FIRST_DAY
                $query.field.getNext().SnapshotSchedule.quarterly.quarterStartMonth = [RubrikSecurityCloud.Types.Month]::JANUARY
                # yearly: YearlySnapshotSchedule
                # Yearly schedule of the SLA Domain.
                $query.field.getNext().SnapshotSchedule.yearly = New-Object -TypeName RubrikSecurityCloud.Types.YearlySnapshotSchedule
                $query.field.getNext().SnapshotSchedule.yearly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.getNext().SnapshotSchedule.yearly.basicSchedule.frequency = 1
                $query.field.getNext().SnapshotSchedule.yearly.basicSchedule.retention = 1
                $query.field.getNext().SnapshotSchedule.yearly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                $query.field.getNext().SnapshotSchedule.yearly.dayOfYear = [RubrikSecurityCloud.Types.DayOfYear]::FIRST_DAY
                $query.field.getNext().SnapshotSchedule.yearly.yearStartMonth = [RubrikSecurityCloud.Types.Month]::JANUARY
            # localRetentionLimit: Duration
            # Local retention limit.
            $query.field.getNext().localRetentionLimit = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $query.field.getNext().localRetentionLimit.durationField = 1
            $query.field.getNext().localRetentionLimit.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # archivalSpec: ArchivalSpec
            # Archiving specification for the SLA Domain.
            ### Skipping this in favor of archivalSpecs

            # archivalSpecs: [ArchivalSpec!]!
            # List of archival specifications for SLA Domain.
            $query.field.getNext().ArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalSpec
                # threshold: Int!
                # Archival threshold.
                $query.field.getNext().ArchivalSpecs[0].threshold = 1

                # thresholdUnit: RetentionUnit!
                # Unit of archival threshold.
                $query.field.getNext().ArchivalSpecs[0].thresholdUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                # archivalTieringSpec: ArchivalTieringSpec
                # Archival tiering specification.
                $query.field.getNext().ArchivalSpecs[0].archivalTieringSpec = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalTieringSpec
                    # isInstantTieringEnabled: Boolean!
                    # True when instant tiering enabled.
                    $query.field.getNext().ArchivalSpecs[0].archivalTieringSpec.isInstantTieringEnabled = $true

                    # minAccessibleDurationInSeconds: Long!
                    # Minimum accessible duration specified for smart tiering.
                    $query.field.getNext().ArchivalSpecs[0].archivalTieringSpec.minAccessibleDurationInSeconds = 1

                    # coldStorageClass: ColdStorageClass!
                    # Cold storage class for tiering.
                    $query.field.getNext().ArchivalSpecs[0].archivalTieringSpec.coldStorageClass = [RubrikSecurityCloud.Types.ColdStorageClass]::AWS_GLACIER

                    # shouldTierExistingSnapshots: Boolean!
                    # Tier existing snapshots for instant tiering, when true.
                    $query.field.getNext().ArchivalSpecs[0].archivalTieringSpec.shouldTierExistingSnapshots = $true

                # frequencies: [RetentionUnit!]!
                # Archives all snapshots taken with the specified frequency.
                $query.field.getNext().ArchivalSpecs[0].frequencies = [RubrikSecurityCloud.Types.RetentionUnit[]]@([RubrikSecurityCloud.Types.RetentionUnit]::DAYS)

                # archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]!
                # Mapping between archival location and Rubrik cluster.
                $query.field.getNext().ArchivalSpecs[0].archivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping

                    # cluster: SlaArchivalCluster
                    # Cluster on which the archival location is created.
                    $query.field.getNext().ArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaArchivalCluster
                    $query.field.getNext().ArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster.id = "FETCH"
                    # Only need ID for updating SLA

                    # location: DlsArchivalLocation
                    # Location used as archival target.
                    $query.field.getNext().ArchivalSpecs[0].archivalLocationToClusterMapping[0].location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
                    $query.field.getNext().ArchivalSpecs[0].archivalLocationToClusterMapping[0].location.id = "FETCH"
                    # Only need ID for updating SLA

                # storageSetting: TargetMapping
                # Storage settings of an archival group.
                # Don't need storageSetting for updates. Just getting ID here.
                $query.field.getNext().ArchivalSpecs[0].storageSetting = New-Object -TypeName RubrikSecurityCloud.Types.TargetMapping
                $query.field.getNext().ArchivalSpecs[0].storageSetting.id = "FETCH"

            # replicationSpec: ReplicationSpec
            # Replication specification for the SLA Domain.
            # Skipping in favor of replicationSpecsV2

            # replicationSpecsV2: [ReplicationSpecV2!]!
            # Replication specification for the SLA Domain.
            $query.field.getNext().ReplicationSpecsV2 = New-Object -TypeName RubrikSecurityCloud.Types.ReplicationSpecV2
                # retentionDuration: Duration
                # Retention duration.
                $query.field.getNext().ReplicationSpecsV2[0].retentionDuration = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                $query.field.getNext().ReplicationSpecsV2[0].retentionDuration.durationField = 1
                $query.field.getNext().ReplicationSpecsV2[0].retentionDuration.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                # replicationLocalRetentionDuration: Duration
                # Time snapshot is kept on local target cluster.
                $query.field.getNext().ReplicationSpecsV2[0].replicationLocalRetentionDuration = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                $query.field.getNext().ReplicationSpecsV2[0].replicationLocalRetentionDuration.durationField = 1
                $query.field.getNext().ReplicationSpecsV2[0].replicationLocalRetentionDuration.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # cascadingArchivalSpecs: [CascadingArchivalSpec!]!
                # Cascading Archival Specifications.
                $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.CascadingArchivalSpec
                    # archivalThreshold: Duration
                    # Threshold after which the snapshot will be archived.
                    $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold.durationField = 1
                    $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                    # archivalTieringSpec: ArchivalTieringSpec
                    # Archival tiering specification.
                    $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalTieringSpec
                        # isInstantTieringEnabled: Boolean = false
                        # Set when instant tiering enabled.
                        $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.isInstantTieringEnabled = $true

                        # minAccessibleDurationInSeconds: Long = 0
                        # Min accessible duration specified for smart tiering.
                        $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.minAccessibleDurationInSeconds = 1
                        
                        # coldStorageClass: ColdStorageClass = COLD_STORAGE_CLASS_UNKNOWN
                        # Cold storage class for tiering.
                        $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.coldStorageClass = [RubrikSecurityCloud.Types.ColdStorageClass]::COLD_STORAGE_CLASS_UNKNOWN
                        
                        # shouldTierExistingSnapshots: Boolean = false
                        # Set to tier existing snapshots for instant tiering.
                        $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.shouldTierExistingSnapshots = $true

                    # frequency: [RetentionUnit!]!
                    # Frequencies that are associated with this cascaded archival location.
                    $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].frequency = [RubrikSecurityCloud.Types.RetentionUnit[]]@([RubrikSecurityCloud.Types.RetentionUnit]::DAYS)

                    # archivalLocation: Target
                    # Archival location for snapshot on target.
                    # No constructor on target type, so I have to construct an object for each implementation, but I can't because archivalLocation is not a list.
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation = 
                    $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation = New-Object RubrikSecurityCloud.Types.RubrikManagedAwsTarget
                    $query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation.id = "FETCH"
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedAzureTarget
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedGcpTarget
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedGlacierTarget
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedNfsTarget
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedRcsTarget
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedS3CompatibleTarget
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedTapeTargetType

                    # archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]
                    # Mapping between archival location and Rubrik cluster.
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaArchivalCluster
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster.id = "FETCH"
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster.name = "FETCH"
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].location.id = "FETCH"
                    #$query.field.getNext().ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].location.name = "FETCH"

                # targetMapping: TargetMapping
                # Replication target mapping.
                # Skipping for now as it's not needed to update an SLA

                # cluster: SlaReplicationCluster
                # Rubrik cluster used as the replication target.
                $query.field.getNext().ReplicationSpecsV2[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaReplicationCluster
                $query.field.getNext().ReplicationSpecsV2[0].cluster.id = "FETCH"
                $query.field.getNext().ReplicationSpecsV2[0].cluster.name = "FETCH"

                # replicationPairs: [SlaReplicationPair!]
                # Datacenter replication pairs.
                # Feature still in development
                #$query.field.getNext().ReplicationSpecsV2[0].replicationPairs = New-Object -TypeName RubrikSecurityCloud.Types.SlaReplicationPair
                #$query.field.getNext().ReplicationSpecsV2[0].replicationPairs[0].sourceCluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaDataLocationCluster
                #$query.field.getNext().ReplicationSpecsV2[0].replicationPairs[0].sourceCluster.id = "FETCH"
                #$query.field.getNext().ReplicationSpecsV2[0].replicationPairs[0].sourceCluster.name = "FETCH"
                #$query.field.getNext().ReplicationSpecsV2[0].replicationPairs[0].targetCluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaDataLocationCluster
                #$query.field.getNext().ReplicationSpecsV2[0].replicationPairs[0].targetCluster.id = "FETCH"
                #$query.field.getNext().ReplicationSpecsV2[0].replicationPairs[0].targetCluster.name = "FETCH"

                # awsRegion: String!
                # AWS region.
                $query.field.getNext().ReplicationSpecsV2[0].awsRegion = "FETCH"

                # azureRegion: String!
                # Azure Region.
                $query.field.getNext().ReplicationSpecsV2[0].azureRegion = "FETCH"

                # awsTarget: AwsReplicationTarget!
                # AWS location used as the replication target.
                $query.field.getNext().ReplicationSpecsV2[0].awsTarget = New-Object -TypeName RubrikSecurityCloud.Types.AwsReplicationTarget
                $query.field.getNext().ReplicationSpecsV2[0].awsTarget.accountId = "FETCH"
                $query.field.getNext().ReplicationSpecsV2[0].awsTarget.accountName = "FETCH"
                $query.field.getNext().ReplicationSpecsV2[0].awsTarget.region = [RubrikSecurityCloud.Types.AwsNativeRegionForReplication]::US_EAST_1

                # azureTarget: AzureReplicationTarget!
                # Azure location used as the replication target.
                $query.field.getNext().ReplicationSpecsV2[0].azureTarget = New-Object -TypeName RubrikSecurityCloud.Types.AzureReplicationTarget
                $query.field.getNext().ReplicationSpecsV2[0].azureTarget.subscriptionId = "FETCH"
                $query.field.getNext().ReplicationSpecsV2[0].azureTarget.subscriptionName = "FETCH"
                $query.field.getNext().ReplicationSpecsV2[0].azureTarget.region = [RubrikSecurityCloud.Types.AzureNativeRegionForReplication]::EAST_US


            # snapshotScheduleLastUpdatedAt: DateTime
            # Last update timestamp of the snapshot schedule of the SLA Domain.
            $query.field.getNext().snapshotScheduleLastUpdatedAt = "1970-01-01"

            # baseFrequency: Duration
            # Base frequency for the SLA Domain.
            $query.field.getNext().baseFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $query.field.getNext().baseFrequency.durationField = 1
            $query.field.getNext().baseFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # isArchived: Boolean!
            # Specifies whether the SLA Domain is archived or not.
            $query.field.getNext().isArchived = $true

            # stateVersion: Long!
            # State version of the SLA Domain.
            $query.field.getNext().stateVersion = 1

            # firstFullBackupWindows: [BackupWindow!]!
            # First full backup windows.
            $query.field.getNext().firstFullBackupWindows = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindow
            $query.field.getNext().firstFullBackupWindows[0].durationInHours = 1
            $query.field.getNext().firstFullBackupWindows[0].startTimeAttributes = New-Object -TypeName RubrikSecurityCloud.Types.StartTimeAttributes
            $query.field.getNext().firstFullBackupWindows[0].startTimeAttributes.dayOfWeek = New-Object RubrikSecurityCloud.Types.DayOfWeekOpt
            $query.field.getNext().firstFullBackupWindows[0].startTimeAttributes.dayOfWeek.day = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
            $query.field.getNext().firstFullBackupWindows[0].startTimeAttributes.hour = 1
            $query.field.getNext().firstFullBackupWindows[0].startTimeAttributes.minute = 1
            

            # backupWindows: [BackupWindow!]!
            # Backup windows for the SLA Domain.
            $query.field.getNext().backupWindows = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindow
            $query.field.getNext().backupWindows[0].durationInHours = 1
            $query.field.getNext().backupWindows[0].startTimeAttributes = New-Object -TypeName RubrikSecurityCloud.Types.StartTimeAttributes
            $query.field.getNext().backupWindows[0].startTimeAttributes.dayOfWeek = New-Object RubrikSecurityCloud.Types.DayOfWeekOpt
            $query.field.getNext().backupWindows[0].startTimeAttributes.dayOfWeek.day = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
            $query.field.getNext().backupWindows[0].startTimeAttributes.hour = 1
            $query.field.getNext().backupWindows[0].startTimeAttributes.minute = 1

            # clusterToSyncStatusMap: [GlobalSlaSyncStatus!]!
            # Sync status of the clusters.
            $query.field.getNext().clusterToSyncStatusMap = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaSyncStatus
            $query.field.getNext().clusterToSyncStatusMap[0].clusterUuid = "FETCH"
            $query.field.getNext().clusterToSyncStatusMap[0].slaSyncStatus = [RubrikSecurityCloud.Types.SlaSyncStatus]::SUCCEEDED

            # objectSpecificConfigs: ObjectSpecificConfigs
            # The object-specific configurations of the SLA Domain.
            $query.field.getNext().objectSpecificConfigs = New-Object -TypeName RubrikSecurityCloud.Types.ObjectSpecificConfigs
                    # sapHanaConfig: SapHanaConfig
                    # SLA Domain configuration for SAP HANA object.
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaConfig
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.incrementalFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.incrementalFrequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.incrementalFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.differentialFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.differentialFrequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.differentialFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaStorageSnapshotConfig
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS


                    # awsRdsConfig: AwsRdsConfig
                    # SLA Domain configuration for AWS RDS object.
                    $query.field.getNext().objectSpecificConfigs.awsRdsConfig = New-Object -TypeName RubrikSecurityCloud.Types.AwsRdsConfig
                    $query.field.getNext().objectSpecificConfigs.awsRdsConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.awsRdsConfig.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.awsRdsConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # vmwareVmConfig: VmwareVmConfig
                    # SLA Domain configuration for VMware virtual machine object.
                    $query.field.getNext().objectSpecificConfigs.vmwareVmConfig = New-Object -TypeName RubrikSecurityCloud.Types.VmwareVmConfig
                    $query.field.getNext().objectSpecificConfigs.vmwareVmConfig.logRetentionSeconds = 1
                    
                    # azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig
                    # SLA Domain configuration for Azure SQL Database DB object.
                    $query.field.getNext().objectSpecificConfigs.AzureSqlDatabaseDbConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlDatabaseDbConfig
                    $query.field.getNext().objectSpecificConfigs.AzureSqlDatabaseDbConfig.logRetentionInDays = 1
                    
                    # azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig
                    # SLA Domain configuration for Azure SQL Managed Instance DB object.
                    $query.field.getNext().objectSpecificConfigs.AzureSqlManagedInstanceDbConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlManagedInstanceDbConfig
                    $query.field.getNext().objectSpecificConfigs.AzureSqlManagedInstanceDbConfig.logRetentionInDays = 1
                    
                    # db2Config: Db2Config
                    # SLA Domain configuration for Db2 database object.
                    $query.field.getNext().objectSpecificConfigs.db2Config = New-Object -TypeName RubrikSecurityCloud.Types.Db2Config
                    $query.field.getNext().objectSpecificConfigs.db2Config.incrementalFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.db2Config.incrementalFrequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.db2Config.incrementalFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.db2Config.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.db2Config.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.db2Config.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.db2Config.differentialFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.db2Config.differentialFrequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.db2Config.differentialFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.db2Config.logArchivalMethod = [RubrikSecurityCloud.Types.LogArchivalMethod]::LOGARCHMET_H1
                    
                    # mssqlConfig: MssqlConfig
                    # SLA Domain configuration for SQL Server database object.
                    $query.field.getNext().objectSpecificConfigs.mssqlConfig = New-Object -TypeName RubrikSecurityCloud.Types.MssqlConfig
                    $query.field.getNext().objectSpecificConfigs.mssqlConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.mssqlConfig.frequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.mssqlConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.mssqlConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.mssqlConfig.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.mssqlConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # oracleConfig: OracleConfig
                    # SLA Domain configuration for Oracle database object.
                    $query.field.getNext().objectSpecificConfigs.oracleConfig = New-Object -TypeName RubrikSecurityCloud.Types.OracleConfig
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.frequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.hostLogRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.hostLogRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.oracleConfig.hostLogRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # mongoConfig: MongoConfig
                    # SLA Domain configuration for MongoDB database object.
                    $query.field.getNext().objectSpecificConfigs.mongoConfig = New-Object -TypeName RubrikSecurityCloud.Types.MongoConfig
                    $query.field.getNext().objectSpecificConfigs.mongoConfig.logFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.mongoConfig.logFrequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.mongoConfig.logFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.mongoConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.mongoConfig.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.mongoConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # azureBlobConfig: AzureBlobConfig
                    # SLA Domain configuration for Azure Blob object.
                    $query.field.getNext().objectSpecificConfigs.azureBlobConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureBlobConfig
                    $query.field.getNext().objectSpecificConfigs.azureBlobConfig.continuousBackupRetentionInDays = 1
                    $query.field.getNext().objectSpecificConfigs.azureBlobConfig.backupLocationId = "FETCH"
                    $query.field.getNext().objectSpecificConfigs.azureBlobConfig.backupLocationName = "FETCH"
                    
                    # awsNativeS3SlaConfig: AwsNativeS3SlaConfig
                    # SLA Domain configuration for AWS S3 bucket.
                    $query.field.getNext().objectSpecificConfigs.awsNativeS3SlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.AwsNativeS3SlaConfig
                    $query.field.getNext().objectSpecificConfigs.awsNativeS3SlaConfig.continuousBackupRetentionInDays = 1
                    $query.field.getNext().objectSpecificConfigs.awsNativeS3SlaConfig.archivalLocationId = "FETCH"
                    $query.field.getNext().objectSpecificConfigs.awsNativeS3SlaConfig.archivalLocationName = "FETCH"
                    
                    # managedVolumeSlaConfig: ManagedVolumeSlaConfig
                    # SLA Domain configuration for Managed Volume object.
                    $query.field.getNext().objectSpecificConfigs.managedVolumeSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.ManagedVolumeSlaConfig
                    $query.field.getNext().objectSpecificConfigs.managedVolumeSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.managedVolumeSlaConfig.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.managedVolumeSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # postgresDbClusterSlaConfig: PostgresDbClusterSlaConfig
                    # SLA Domain configuration for Postgres DB Cluster object.
                    $query.field.getNext().objectSpecificConfigs.postgresDbClusterSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.PostgresDbClusterSlaConfig
                    $query.field.getNext().objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                    
                    # mysqldbSlaConfig: MysqldbSlaConfig
                    # SLA Domain configuration for MySQL object.
                    $query.field.getNext().objectSpecificConfigs.mysqldbSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.MysqldbSlaConfig
                    $query.field.getNext().objectSpecificConfigs.mysqldbSlaConfig.logFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.mysqldbSlaConfig.logFrequency.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.mysqldbSlaConfig.logFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.getNext().objectSpecificConfigs.mysqldbSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.getNext().objectSpecificConfigs.mysqldbSlaConfig.logRetention.durationField = 1
                    $query.field.getNext().objectSpecificConfigs.mysqldbSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # objectTypes: [SlaObjectType!]!
            # The object-types supported by the SLA Domain.
            $query.field.getNext().objectTypes = [RubrikSecurityCloud.Types.SlaObjectType[]]@([RubrikSecurityCloud.Types.SlaObjectType]::KUPR_OBJECT_TYPE)

            # clusterUuid: String!
            # Rubrik cluster ID of the SLA Domain.
            $query.field.getNext().clusterUuid = "What is this"

            # isDefault: Boolean!
            # Specifies whether the SLA Domain is a default SLA Domain or not.
            $query.field.getNext().isDefault = $true

            # upgradeInfo: SlaUpgradeInfo
            # SLA Domain upgrade information.
            $query.field.getNext().upgradeInfo = New-Object -TypeName RubrikSecurityCloud.Types.SlaUpgradeInfo
            $query.field.getNext().upgradeInfo.eligibility = New-Object -TypeName RubrikSecurityCloud.Types.SlaUpgradeEligibility
            $query.field.getNext().upgradeInfo.eligibility.isEligible = $true
            $query.field.getNext().upgradeInfo.eligibility.ineligibilityReason = [RubrikSecurityCloud.Types.SlaMigrationIneligibilityReason]::CLUSTER_DISCONNECTED


            # pausedClustersInfo: PausedClustersInfo
            # Information about Rubrik clusters where this SLA Domain is paused.
            $query.field.getNext().pausedClustersInfo = New-Object -TypeName RubrikSecurityCloud.Types.PausedClustersInfo
            $query.field.getNext().pausedClustersInfo.pausedClustersCount = 1
            $query.field.getNext().pausedClustersInfo.pausedClusters = New-Object RubrikSecurityCloud.Types.Cluster
            $query.field.getNext().pausedClustersInfo.pausedClusters[0].id = "FETCH"

            # isRetentionLockedSla: Boolean!
            # Specifies if this SLA Domain is retention-locked or not.
            $query.field.getNext().isRetentionLockedSla = $true

            # isReadOnly: Boolean
            # Specifies whether the SLA Domain is read-only.
            $query.field.getNext().isReadOnly = $true

            # retentionLockMode: RetentionLockMode!
            # Specifies the retention lock mode when enabled for the SLA Domain.
            $query.field.getNext().retentionLockMode = [RubrikSecurityCloud.Types.RetentionLockMode]::NO_MODE

            # allOrgsHavingAccess: [SlaAssociatedOrganization!]!
            # Specifies the list of organizations that have view access for the SLA Domain.
            $query.field.getNext().allOrgsHavingAccess = New-Object -TypeName RubrikSecurityCloud.Types.SlaAssociatedOrganization
            $query.field.getNext().allOrgsHavingAccess[0].name = "FETCH"
            $query.field.getNext().allOrgsHavingAccess[0].id = "FETCH"

            # ownerOrg: SlaAssociatedOrganization!
            # Specifies the owner organization of the SLA Domain.
            $query.field.getNext().ownerOrg = New-Object -TypeName RubrikSecurityCloud.Types.SlaAssociatedOrganization
            $query.field.getNext().ownerOrg.name = "FETCH"
            $query.field.getNext().ownerOrg.id = "FETCH"

            # archivalLocationsUpgradeInfo: [ArchivalLocationUpgradeInfo!]
            # Upgrade information about the configured archival locations and cascading archival locations.
            $query.field.getNext().archivalLocationsUpgradeInfo = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationUpgradeInfo
            $query.field.getNext().archivalLocationsUpgradeInfo[0].locationId = "FETCH"

            # sourceClusters: [SlaDataLocationCluster!]!
            # Source clusters configured in the SLA Domain.
            #$query.field.getNext().sourceClusters = New-Object -TypeName RubrikSecurityCloud.Types.SlaDataLocationCluster
            #$query.field.getNext().sourceClusters[0].id = "FETCH"

            $result = $query.Invoke()
            $result
        } 
        else {
            $query = New-RscQuery -GqlQuery slaDomains -FieldProfile EMPTY
            $globalSlaReply = $query.field.nodes.FindIndex({param($item) $item.gettype().name -eq "globalSlaReply"})
            $query.var.shouldShowProtectedObjectCount = $true
            $query.var.filter = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaFilterInput
            $query.var.filter.Field = [RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]::NAME
            $query.var.filter.Text = $Name

            #id: String!
            # SLA Domain ID.
            $query.field.nodes[$globalSlaReply].id = "FETCH"
            # name: String!
            # SLA Domain name.
            $query.field.nodes[$globalSlaReply].name = "FETCH"

            # version: String
            # Version for the SLA Domain.
            $query.field.nodes[$globalSlaReply].version = "FETCH"

            # description: String!
            # Description of the SLA Domain.
            $query.field.nodes[$globalSlaReply].description = "FETCH"

            # protectedObjectCount: Int!
            # Workload count for the SLA Domain.
            $query.field.nodes[$globalSlaReply].protectedObjectCount = 1

            # uiColor: String!
            # Color of the SLA Domain on the User Interface.
            # Skip this. No one here needs UI color.

            # snapshotSchedule: SnapshotSchedule
            # Snapshot schedule for the SLA Domain.
            $query.field.nodes[$globalSlaReply].SnapshotSchedule = New-Object -TypeName RubrikSecurityCloud.Types.SnapshotSchedule
                # minute: MinuteSnapshotSchedule
                # Minute schedule of the SLA Domain.
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.minute = New-Object -TypeName RubrikSecurityCloud.Types.MinuteSnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.minute.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.minute.basicSchedule.frequency = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.minute.basicSchedule.retention = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.minute.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # hourly: HourlySnapshotSchedule
                # Hourly schedule of the SLA Domain.
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.hourly = New-Object -TypeName RubrikSecurityCloud.Types.HourlySnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.hourly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.hourly.basicSchedule.frequency = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.hourly.basicSchedule.retention = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.hourly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # daily: DailySnapshotSchedule
                # Daily schedule of the SLA Domain.
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.daily = New-Object -TypeName RubrikSecurityCloud.Types.DailySnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.daily.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.daily.basicSchedule.frequency = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.daily.basicSchedule.retention = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.daily.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # weekly: WeeklySnapshotSchedule
                # Weekly schedule of the SLA Domain.
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.weekly = New-Object -TypeName RubrikSecurityCloud.Types.WeeklySnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.weekly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.weekly.basicSchedule.frequency = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.weekly.basicSchedule.retention = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.weekly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.weekly.dayOfWeek = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
                # monthly: MonthlySnapshotSchedule
                # Monthly schedule of the SLA Domain.
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.monthly = New-Object -TypeName RubrikSecurityCloud.Types.MonthlySnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.monthly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.monthly.basicSchedule.frequency = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.monthly.basicSchedule.retention = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.monthly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.monthly.dayOfMonth = [RubrikSecurityCloud.Types.DayOfMonth]::LAST_DAY
                # quarterly: QuarterlySnapshotSchedule
                # Quarterly schedule of the SLA Domain.
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.quarterly = New-Object -TypeName RubrikSecurityCloud.Types.QuarterlySnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.quarterly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.quarterly.basicSchedule.frequency = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.quarterly.basicSchedule.retention = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.quarterly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.quarterly.dayOfQuarter = [RubrikSecurityCloud.Types.DayOfQuarter]::FIRST_DAY
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.quarterly.quarterStartMonth = [RubrikSecurityCloud.Types.Month]::JANUARY
                # yearly: YearlySnapshotSchedule
                # Yearly schedule of the SLA Domain.
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.yearly = New-Object -TypeName RubrikSecurityCloud.Types.YearlySnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.yearly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.yearly.basicSchedule.frequency = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.yearly.basicSchedule.retention = 1
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.yearly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.yearly.dayOfYear = [RubrikSecurityCloud.Types.DayOfYear]::FIRST_DAY
                $query.field.nodes[$globalSlaReply].SnapshotSchedule.yearly.yearStartMonth = [RubrikSecurityCloud.Types.Month]::JANUARY
            # localRetentionLimit: Duration
            # Local retention limit.
            $query.field.nodes[$globalSlaReply].localRetentionLimit = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $query.field.nodes[$globalSlaReply].localRetentionLimit.durationField = 1
            $query.field.nodes[$globalSlaReply].localRetentionLimit.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # archivalSpec: ArchivalSpec
            # Archiving specification for the SLA Domain.
            ### Skipping this in favor of archivalSpecs

            # archivalSpecs: [ArchivalSpec!]!
            # List of archival specifications for SLA Domain.
            $query.field.nodes[$globalSlaReply].ArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalSpec
                # threshold: Int!
                # Archival threshold.
                $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].threshold = 1

                # thresholdUnit: RetentionUnit!
                # Unit of archival threshold.
                $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].thresholdUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                # archivalTieringSpec: ArchivalTieringSpec
                # Archival tiering specification.
                $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalTieringSpec = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalTieringSpec
                    # isInstantTieringEnabled: Boolean!
                    # True when instant tiering enabled.
                    $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalTieringSpec.isInstantTieringEnabled = $true

                    # minAccessibleDurationInSeconds: Long!
                    # Minimum accessible duration specified for smart tiering.
                    $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalTieringSpec.minAccessibleDurationInSeconds = 1

                    # coldStorageClass: ColdStorageClass!
                    # Cold storage class for tiering.
                    $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalTieringSpec.coldStorageClass = [RubrikSecurityCloud.Types.ColdStorageClass]::AWS_GLACIER

                    # shouldTierExistingSnapshots: Boolean!
                    # Tier existing snapshots for instant tiering, when true.
                    $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalTieringSpec.shouldTierExistingSnapshots = $true

                # frequencies: [RetentionUnit!]!
                # Archives all snapshots taken with the specified frequency.
                $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].frequencies = [RubrikSecurityCloud.Types.RetentionUnit[]]@([RubrikSecurityCloud.Types.RetentionUnit]::DAYS)

                # archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]!
                # Mapping between archival location and Rubrik cluster.
                $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping

                    # cluster: SlaArchivalCluster
                    # Cluster on which the archival location is created.
                    $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaArchivalCluster
                    $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster.id = "FETCH"
                    # Only need ID for updating SLA

                    # location: DlsArchivalLocation
                    # Location used as archival target.
                    $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalLocationToClusterMapping[0].location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
                    $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].archivalLocationToClusterMapping[0].location.id = "FETCH"
                    # Only need ID for updating SLA

                # storageSetting: TargetMapping
                # Storage settings of an archival group.
                # Don't need storageSetting for updates. Just getting ID here.
                $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].storageSetting = New-Object -TypeName RubrikSecurityCloud.Types.TargetMapping
                $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].storageSetting.id = "FETCH"

            # replicationSpec: ReplicationSpec
            # Replication specification for the SLA Domain.
            # Skipping in favor of replicationSpecsV2

            # replicationSpecsV2: [ReplicationSpecV2!]!
            # Replication specification for the SLA Domain.
            $query.field.nodes[$globalSlaReply].ReplicationSpecsV2 = New-Object -TypeName RubrikSecurityCloud.Types.ReplicationSpecV2
                # retentionDuration: Duration
                # Retention duration.
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].retentionDuration = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].retentionDuration.durationField = 1
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].retentionDuration.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                # replicationLocalRetentionDuration: Duration
                # Time snapshot is kept on local target cluster.
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationLocalRetentionDuration = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationLocalRetentionDuration.durationField = 1
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationLocalRetentionDuration.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # cascadingArchivalSpecs: [CascadingArchivalSpec!]!
                # Cascading Archival Specifications.
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.CascadingArchivalSpec
                    # archivalThreshold: Duration
                    # Threshold after which the snapshot will be archived.
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold.durationField = 1
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                    # archivalTieringSpec: ArchivalTieringSpec
                    # Archival tiering specification.
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalTieringSpec
                        # isInstantTieringEnabled: Boolean = false
                        # Set when instant tiering enabled.
                        $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.isInstantTieringEnabled = $true

                        # minAccessibleDurationInSeconds: Long = 0
                        # Min accessible duration specified for smart tiering.
                        $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.minAccessibleDurationInSeconds = 1
                        
                        # coldStorageClass: ColdStorageClass = COLD_STORAGE_CLASS_UNKNOWN
                        # Cold storage class for tiering.
                        $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.coldStorageClass = [RubrikSecurityCloud.Types.ColdStorageClass]::COLD_STORAGE_CLASS_UNKNOWN
                        
                        # shouldTierExistingSnapshots: Boolean = false
                        # Set to tier existing snapshots for instant tiering.
                        $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.shouldTierExistingSnapshots = $true

                    # frequency: [RetentionUnit!]!
                    # Frequencies that are associated with this cascaded archival location.
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].frequency = [RubrikSecurityCloud.Types.RetentionUnit[]]@([RubrikSecurityCloud.Types.RetentionUnit]::DAYS)

                    # archivalLocation: Target
                    # Archival location for snapshot on target.
                    # No constructor on target type, so I have to construct an object for each implementation, but I can't because archivalLocation is not a list.
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation = 
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation = New-Object RubrikSecurityCloud.Types.RubrikManagedAwsTarget
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation.id = "FETCH"
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedAzureTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedGcpTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedGlacierTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedNfsTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedRcsTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedS3CompatibleTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedTapeTargetType

                    # archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]
                    # Mapping between archival location and Rubrik cluster.
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaArchivalCluster
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster.id = "FETCH"
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster.name = "FETCH"
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].location.id = "FETCH"
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocationToClusterMapping[0].location.name = "FETCH"

                # targetMapping: TargetMapping
                # Replication target mapping.
                # Skipping for now as it's not needed to update an SLA

                # cluster: SlaReplicationCluster
                # Rubrik cluster used as the replication target.
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaReplicationCluster
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cluster.id = "FETCH"
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cluster.name = "FETCH"

                # replicationPairs: [SlaReplicationPair!]
                # Datacenter replication pairs.
                # Feature still in development
                #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationPairs = New-Object -TypeName RubrikSecurityCloud.Types.SlaReplicationPair
                #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationPairs[0].sourceCluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaDataLocationCluster
                #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationPairs[0].sourceCluster.id = "FETCH"
                #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationPairs[0].sourceCluster.name = "FETCH"
                #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationPairs[0].targetCluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaDataLocationCluster
                #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationPairs[0].targetCluster.id = "FETCH"
                #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].replicationPairs[0].targetCluster.name = "FETCH"

                # awsRegion: String!
                # AWS region.
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].awsRegion = "FETCH"

                # azureRegion: String!
                # Azure Region.
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].azureRegion = "FETCH"

                # awsTarget: AwsReplicationTarget!
                # AWS location used as the replication target.
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].awsTarget = New-Object -TypeName RubrikSecurityCloud.Types.AwsReplicationTarget
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].awsTarget.accountId = "FETCH"
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].awsTarget.accountName = "FETCH"
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].awsTarget.region = [RubrikSecurityCloud.Types.AwsNativeRegionForReplication]::US_EAST_1

                # azureTarget: AzureReplicationTarget!
                # Azure location used as the replication target.
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].azureTarget = New-Object -TypeName RubrikSecurityCloud.Types.AzureReplicationTarget
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].azureTarget.subscriptionId = "FETCH"
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].azureTarget.subscriptionName = "FETCH"
                $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].azureTarget.region = [RubrikSecurityCloud.Types.AzureNativeRegionForReplication]::EAST_US


            # snapshotScheduleLastUpdatedAt: DateTime
            # Last update timestamp of the snapshot schedule of the SLA Domain.
            $query.field.nodes[$globalSlaReply].snapshotScheduleLastUpdatedAt = "1970-01-01"

            # baseFrequency: Duration
            # Base frequency for the SLA Domain.
            $query.field.nodes[$globalSlaReply].baseFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $query.field.nodes[$globalSlaReply].baseFrequency.durationField = 1
            $query.field.nodes[$globalSlaReply].baseFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # isArchived: Boolean!
            # Specifies whether the SLA Domain is archived or not.
            $query.field.nodes[$globalSlaReply].isArchived = $true

            # stateVersion: Long!
            # State version of the SLA Domain.
            $query.field.nodes[$globalSlaReply].stateVersion = 1

            # firstFullBackupWindows: [BackupWindow!]!
            # First full backup windows.
            $query.field.nodes[$globalSlaReply].firstFullBackupWindows = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindow
            $query.field.nodes[$globalSlaReply].firstFullBackupWindows[0].durationInHours = 1
            $query.field.nodes[$globalSlaReply].firstFullBackupWindows[0].startTimeAttributes = New-Object -TypeName RubrikSecurityCloud.Types.StartTimeAttributes
            $query.field.nodes[$globalSlaReply].firstFullBackupWindows[0].startTimeAttributes.dayOfWeek = New-Object RubrikSecurityCloud.Types.DayOfWeekOpt
            $query.field.nodes[$globalSlaReply].firstFullBackupWindows[0].startTimeAttributes.dayOfWeek.day = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
            $query.field.nodes[$globalSlaReply].firstFullBackupWindows[0].startTimeAttributes.hour = 1
            $query.field.nodes[$globalSlaReply].firstFullBackupWindows[0].startTimeAttributes.minute = 1
            

            # backupWindows: [BackupWindow!]!
            # Backup windows for the SLA Domain.
            $query.field.nodes[$globalSlaReply].backupWindows = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindow
            $query.field.nodes[$globalSlaReply].backupWindows[0].durationInHours = 1
            $query.field.nodes[$globalSlaReply].backupWindows[0].startTimeAttributes = New-Object -TypeName RubrikSecurityCloud.Types.StartTimeAttributes
            $query.field.nodes[$globalSlaReply].backupWindows[0].startTimeAttributes.dayOfWeek = New-Object RubrikSecurityCloud.Types.DayOfWeekOpt
            $query.field.nodes[$globalSlaReply].backupWindows[0].startTimeAttributes.dayOfWeek.day = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
            $query.field.nodes[$globalSlaReply].backupWindows[0].startTimeAttributes.hour = 1
            $query.field.nodes[$globalSlaReply].backupWindows[0].startTimeAttributes.minute = 1

            # clusterToSyncStatusMap: [GlobalSlaSyncStatus!]!
            # Sync status of the clusters.
            $query.field.nodes[$globalSlaReply].clusterToSyncStatusMap = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaSyncStatus
            $query.field.nodes[$globalSlaReply].clusterToSyncStatusMap[0].clusterUuid = "FETCH"
            $query.field.nodes[$globalSlaReply].clusterToSyncStatusMap[0].slaSyncStatus = [RubrikSecurityCloud.Types.SlaSyncStatus]::SUCCEEDED

            # objectSpecificConfigs: ObjectSpecificConfigs
            # The object-specific configurations of the SLA Domain.
            $query.field.nodes[$globalSlaReply].objectSpecificConfigs = New-Object -TypeName RubrikSecurityCloud.Types.ObjectSpecificConfigs
                    # sapHanaConfig: SapHanaConfig
                    # SLA Domain configuration for SAP HANA object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.incrementalFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.incrementalFrequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.incrementalFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.differentialFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.differentialFrequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.differentialFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaStorageSnapshotConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS


                    # awsRdsConfig: AwsRdsConfig
                    # SLA Domain configuration for AWS RDS object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.awsRdsConfig = New-Object -TypeName RubrikSecurityCloud.Types.AwsRdsConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.awsRdsConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.awsRdsConfig.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.awsRdsConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # vmwareVmConfig: VmwareVmConfig
                    # SLA Domain configuration for VMware virtual machine object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.vmwareVmConfig = New-Object -TypeName RubrikSecurityCloud.Types.VmwareVmConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.vmwareVmConfig.logRetentionSeconds = 1
                    
                    # azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig
                    # SLA Domain configuration for Azure SQL Database DB object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.AzureSqlDatabaseDbConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlDatabaseDbConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.AzureSqlDatabaseDbConfig.logRetentionInDays = 1
                    
                    # azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig
                    # SLA Domain configuration for Azure SQL Managed Instance DB object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.AzureSqlManagedInstanceDbConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlManagedInstanceDbConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.AzureSqlManagedInstanceDbConfig.logRetentionInDays = 1
                    
                    # db2Config: Db2Config
                    # SLA Domain configuration for Db2 database object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config = New-Object -TypeName RubrikSecurityCloud.Types.Db2Config
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.incrementalFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.incrementalFrequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.incrementalFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.differentialFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.differentialFrequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.differentialFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.db2Config.logArchivalMethod = [RubrikSecurityCloud.Types.LogArchivalMethod]::LOGARCHMET_H1
                    
                    # mssqlConfig: MssqlConfig
                    # SLA Domain configuration for SQL Server database object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mssqlConfig = New-Object -TypeName RubrikSecurityCloud.Types.MssqlConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mssqlConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mssqlConfig.frequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mssqlConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mssqlConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mssqlConfig.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mssqlConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # oracleConfig: OracleConfig
                    # SLA Domain configuration for Oracle database object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig = New-Object -TypeName RubrikSecurityCloud.Types.OracleConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.frequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.hostLogRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.hostLogRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.oracleConfig.hostLogRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # mongoConfig: MongoConfig
                    # SLA Domain configuration for MongoDB database object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mongoConfig = New-Object -TypeName RubrikSecurityCloud.Types.MongoConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mongoConfig.logFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mongoConfig.logFrequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mongoConfig.logFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mongoConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mongoConfig.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mongoConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # azureBlobConfig: AzureBlobConfig
                    # SLA Domain configuration for Azure Blob object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.azureBlobConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureBlobConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.azureBlobConfig.continuousBackupRetentionInDays = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.azureBlobConfig.backupLocationId = "FETCH"
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.azureBlobConfig.backupLocationName = "FETCH"
                    
                    # awsNativeS3SlaConfig: AwsNativeS3SlaConfig
                    # SLA Domain configuration for AWS S3 bucket.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.awsNativeS3SlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.AwsNativeS3SlaConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.awsNativeS3SlaConfig.continuousBackupRetentionInDays = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.awsNativeS3SlaConfig.archivalLocationId = "FETCH"
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.awsNativeS3SlaConfig.archivalLocationName = "FETCH"
                    
                    # managedVolumeSlaConfig: ManagedVolumeSlaConfig
                    # SLA Domain configuration for Managed Volume object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.managedVolumeSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.ManagedVolumeSlaConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.managedVolumeSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.managedVolumeSlaConfig.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.managedVolumeSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    
                    # postgresDbClusterSlaConfig: PostgresDbClusterSlaConfig
                    # SLA Domain configuration for Postgres DB Cluster object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.postgresDbClusterSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.PostgresDbClusterSlaConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                    
                    # mysqldbSlaConfig: MysqldbSlaConfig
                    # SLA Domain configuration for MySQL object.
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mysqldbSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.MysqldbSlaConfig
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mysqldbSlaConfig.logFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mysqldbSlaConfig.logFrequency.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mysqldbSlaConfig.logFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mysqldbSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mysqldbSlaConfig.logRetention.durationField = 1
                    $query.field.nodes[$globalSlaReply].objectSpecificConfigs.mysqldbSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # objectTypes: [SlaObjectType!]!
            # The object-types supported by the SLA Domain.
            $query.field.nodes[$globalSlaReply].objectTypes = [RubrikSecurityCloud.Types.SlaObjectType[]]@([RubrikSecurityCloud.Types.SlaObjectType]::KUPR_OBJECT_TYPE)

            # clusterUuid: String!
            # Rubrik cluster ID of the SLA Domain.
            $query.field.nodes[$globalSlaReply].clusterUuid = "What is this"

            # isDefault: Boolean!
            # Specifies whether the SLA Domain is a default SLA Domain or not.
            $query.field.nodes[$globalSlaReply].isDefault = $true

            # upgradeInfo: SlaUpgradeInfo
            # SLA Domain upgrade information.
            $query.field.nodes[$globalSlaReply].upgradeInfo = New-Object -TypeName RubrikSecurityCloud.Types.SlaUpgradeInfo
            $query.field.nodes[$globalSlaReply].upgradeInfo.eligibility = New-Object -TypeName RubrikSecurityCloud.Types.SlaUpgradeEligibility
            $query.field.nodes[$globalSlaReply].upgradeInfo.eligibility.isEligible = $true
            $query.field.nodes[$globalSlaReply].upgradeInfo.eligibility.ineligibilityReason = [RubrikSecurityCloud.Types.SlaMigrationIneligibilityReason]::CLUSTER_DISCONNECTED


            # pausedClustersInfo: PausedClustersInfo
            # Information about Rubrik clusters where this SLA Domain is paused.
            $query.field.nodes[$globalSlaReply].pausedClustersInfo = New-Object -TypeName RubrikSecurityCloud.Types.PausedClustersInfo
            $query.field.nodes[$globalSlaReply].pausedClustersInfo.pausedClustersCount = 1
            $query.field.nodes[$globalSlaReply].pausedClustersInfo.pausedClusters = New-Object RubrikSecurityCloud.Types.Cluster
            $query.field.nodes[$globalSlaReply].pausedClustersInfo.pausedClusters[0].id = "FETCH"

            # isRetentionLockedSla: Boolean!
            # Specifies if this SLA Domain is retention-locked or not.
            $query.field.nodes[$globalSlaReply].isRetentionLockedSla = $true

            # isReadOnly: Boolean
            # Specifies whether the SLA Domain is read-only.
            $query.field.nodes[$globalSlaReply].isReadOnly = $true

            # retentionLockMode: RetentionLockMode!
            # Specifies the retention lock mode when enabled for the SLA Domain.
            $query.field.nodes[$globalSlaReply].retentionLockMode = [RubrikSecurityCloud.Types.RetentionLockMode]::NO_MODE

            # allOrgsHavingAccess: [SlaAssociatedOrganization!]!
            # Specifies the list of organizations that have view access for the SLA Domain.
            $query.field.nodes[$globalSlaReply].allOrgsHavingAccess = New-Object -TypeName RubrikSecurityCloud.Types.SlaAssociatedOrganization
            $query.field.nodes[$globalSlaReply].allOrgsHavingAccess[0].name = "FETCH"
            $query.field.nodes[$globalSlaReply].allOrgsHavingAccess[0].id = "FETCH"

            # ownerOrg: SlaAssociatedOrganization!
            # Specifies the owner organization of the SLA Domain.
            $query.field.nodes[$globalSlaReply].ownerOrg = New-Object -TypeName RubrikSecurityCloud.Types.SlaAssociatedOrganization
            $query.field.nodes[$globalSlaReply].ownerOrg.name = "FETCH"
            $query.field.nodes[$globalSlaReply].ownerOrg.id = "FETCH"

            # archivalLocationsUpgradeInfo: [ArchivalLocationUpgradeInfo!]
            # Upgrade information about the configured archival locations and cascading archival locations.
            $query.field.nodes[$globalSlaReply].archivalLocationsUpgradeInfo = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationUpgradeInfo
            $query.field.nodes[$globalSlaReply].archivalLocationsUpgradeInfo[0].locationId = "FETCH"

            # sourceClusters: [SlaDataLocationCluster!]!
            # Source clusters configured in the SLA Domain.
            #$query.field.nodes[$globalSlaReply].sourceClusters = New-Object -TypeName RubrikSecurityCloud.Types.SlaDataLocationCluster
            #$query.field.nodes[$globalSlaReply].sourceClusters[0].id = "FETCH"

            $result = $query.Invoke()
            $result.Nodes
        }
    } 
}
