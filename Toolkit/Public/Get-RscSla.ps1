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
            # TODO: SDK currently treating as a clusterSlaDomain, so we can't get globalSlaReply fields.
            #$query.field.BaseFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            #$query.field.BaseFrequency.Unit = New-Object -TypeName RubrikSecurityCloud.Types.RetentionUnit
            #$query.field.BaseFrequency.DurationField = 1
            #$query.field.ProtectedObjectCount = 1
            #$query.field.ArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalSpec
            #$query.field.ArchivalSpecs[0].ArchivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping
            #$query.field.ArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
            #$query.field.ArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location.Name = "Foo"
            #$query.field.ReplicationSpecsV2 = New-Object RubrikSecurityCloud.Types.ReplicationSpecV2
            #$query.field.ReplicationSpecsV2[0].Cluster = New-Object RubrikSecurityCloud.Types.SlaReplicationCluster
            #$query.field.ReplicationSpecsV2[0].Cluster.Name = "This is just here as a placeholder string to indicate that the field should be fetched"
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
                $query.field.nodes[$globalSlaReply].ArchivalSpecs[0].frequencies = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

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
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].frequency = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                    # archivalLocation: Target
                    # Archival location for snapshot on target.
                    # No constructor on target type, so I have to construct an object for each implementation
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation = @()
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation = New-Object RubrikSecurityCloud.Types.RubrikManagedAwsTarget
                    $query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation.id = "FETCH"
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedAzureTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedGcpTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedGlacierTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedNfsTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedRcsTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedS3CompatibleTarget
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation += New-Object RubrikSecurityCloud.Types.RubrikManagedTapeTargetType
                    #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation | ForEach-Object {$_.id = "FETCH"}


                    # archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]
                    # Mapping between archival location and Rubrik cluster.

                # targetMapping: TargetMapping
                # Replication target mapping.

                # cluster: SlaReplicationCluster
                # Rubrik cluster used as the replication target.

                # replicationPairs: [SlaReplicationPair!]
                # Datacenter replication pairs.

                # awsRegion: String!
                # AWS region.

                # azureRegion: String!
                # Azure Region.

                # awsTarget: AwsReplicationTarget!
                # AWS location used as the replication target.

                # azureTarget: AzureReplicationTarget!
                # Azure location used as the replication target.

            # snapshotScheduleLastUpdatedAt: DateTime
            # Last update timestamp of the snapshot schedule of the SLA Domain.
            $query.field.nodes[$globalSlaReply].snapshotScheduleLastUpdatedAt = "1970-01-01"

            # baseFrequency: Duration
            # Base frequency for the SLA Domain.
            $query.field.nodes[$globalSlaReply].baseFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration

            # isArchived: Boolean!
            # Specifies whether the SLA Domain is archived or not.
            $query.field.nodes[$globalSlaReply].isArchived = $true

            # stateVersion: Long!
            # State version of the SLA Domain.
            $query.field.nodes[$globalSlaReply].stateVersion = 1

            # firstFullBackupWindows: [BackupWindow!]!
            # First full backup windows.
            $query.field.nodes[$globalSlaReply].firstFullBackupWindows = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindow

            # backupWindows: [BackupWindow!]!
            # Backup windows for the SLA Domain.
            $query.field.nodes[$globalSlaReply].backupWindows = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindow

            # clusterToSyncStatusMap: [GlobalSlaSyncStatus!]!
            # Sync status of the clusters.
            $query.field.nodes[$globalSlaReply].clusterToSyncStatusMap = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaSyncStatus

            # objectSpecificConfigs: ObjectSpecificConfigs
            # The object-specific configurations of the SLA Domain.
            $query.field.nodes[$globalSlaReply].objectSpecificConfigs = New-Object -TypeName RubrikSecurityCloud.Types.ObjectSpecificConfigs

            # objectTypes: [SlaObjectType!]!
            # The object-types supported by the SLA Domain.
            #$query.field.nodes[$globalSlaReply].objectTypes = [RubrikSecurityCloud.Types.SlaObjectType]::KUPR_OBJECT_TYPE

            # clusterUuid: String!
            # Rubrik cluster ID of the SLA Domain.
            $query.field.nodes[$globalSlaReply].clusterUuid = "What is this"

            # isDefault: Boolean!
            # Specifies whether the SLA Domain is a default SLA Domain or not.
            $query.field.nodes[$globalSlaReply].isDefault = $true

            # upgradeInfo: SlaUpgradeInfo
            # SLA Domain upgrade information.
            $query.field.nodes[$globalSlaReply].upgradeInfo = New-Object -TypeName RubrikSecurityCloud.Types.SlaUpgradeInfo

            # pausedClustersInfo: PausedClustersInfo
            # Information about Rubrik clusters where this SLA Domain is paused.
            $query.field.nodes[$globalSlaReply].pausedClustersInfo = New-Object -TypeName RubrikSecurityCloud.Types.PausedClustersInfo

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

            # ownerOrg: SlaAssociatedOrganization!
            # Specifies the owner organization of the SLA Domain.
            $query.field.nodes[$globalSlaReply].ownerOrg = New-Object -TypeName RubrikSecurityCloud.Types.SlaAssociatedOrganization

            # archivalLocationsUpgradeInfo: [ArchivalLocationUpgradeInfo!]
            # Upgrade information about the configured archival locations and cascading archival locations.
            $query.field.nodes[$globalSlaReply].archivalLocationsUpgradeInfo = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationUpgradeInfo

            # sourceClusters: [SlaDataLocationCluster!]!
            # Source clusters configured in the SLA Domain.
            $query.field.nodes[$globalSlaReply].sourceClusters = New-Object -TypeName RubrikSecurityCloud.Types.SlaDataLocationCluster

            #$query.field.nodes[$globalSlaReply].BaseFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            #$query.field.nodes[$globalSlaReply].BaseFrequency.Unit = New-Object -TypeName RubrikSecurityCloud.Types.RetentionUnit
            #$query.field.nodes[$globalSlaReply].BaseFrequency.DurationField = 1
            #$query.field.nodes[$globalSlaReply].ProtectedObjectCount = 1
            #$query.field.nodes[$globalSlaReply].ArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalSpec
            #$query.field.nodes[$globalSlaReply].ArchivalSpecs[0].ArchivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping
            #$query.field.nodes[$globalSlaReply].ArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
            #$query.field.nodes[$globalSlaReply].ArchivalSpecs[0].ArchivalLocationToClusterMapping[0].Location.Name = "Foo"
            #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2 = New-Object RubrikSecurityCloud.Types.ReplicationSpecV2
            #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].Cluster = New-Object RubrikSecurityCloud.Types.SlaReplicationCluster
            #$query.field.nodes[$globalSlaReply].ReplicationSpecsV2[0].Cluster.Name = "This is just here as a placeholder string to indicate that the field should be fetched"
            $result = $query.Invoke()
            $result.Nodes
        }
    } 
}
