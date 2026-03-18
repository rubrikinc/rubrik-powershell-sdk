#Requires -Version 3
function Get-RscSla {
    <#
    .SYNOPSIS
    Retrieves SLA Domains defined in Rubrik Security Cloud.

    .DESCRIPTION
    Returns global SLA Domains, which are policies that define backup frequency,
    retention, replication, and archival rules for protected workloads. Use -Name
    to filter by name or -Id to retrieve a specific SLA Domain. The output can be
    piped to workload cmdlets to filter by SLA assignment.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Id
    The RSC object ID.

    .PARAMETER Name
    Filter by name. Matches SLA Domains whose name contains the specified string.

    .PARAMETER First
    Maximum number of SLA Domains to return. When omitted, all matching
    SLA Domains are returned (auto-paginated).

    .EXAMPLE
    # Get all SLA Domains
    Get-RscSla

    .EXAMPLE
    # Get the first 10 SLA Domains
    Get-RscSla -First 10

    .EXAMPLE
    # Get SLA Domains with 'Gold' in the name
    Get-RscSla "Gold"

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    # Get VMware VMs assigned to a specific SLA
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
         [String]$Name,
        [Parameter(
             Mandatory = $false,
             ParameterSetName = "Name"
         )]
         [Int]$First,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )

    Process {

        # Shared helper: populate GlobalSlaReply field spec.
        function Set-GsrFields($gsr) {
            # version: String
            # Version for the SLA Domain.
            $gsr.version = "FETCH"

            # description: String!
            # Description of the SLA Domain.
            $gsr.description = "FETCH"

            # protectedObjectCount: Int!
            # Workload count for the SLA Domain.
            $gsr.protectedObjectCount = 1

            # uiColor: String!
            # Color of the SLA Domain on the User Interface.
            # Skip this. No one here needs UI color.

            # snapshotScheduleLastUpdatedAt: DateTime
            # Last update timestamp of the snapshot schedule of the SLA Domain.
            $gsr.snapshotScheduleLastUpdatedAt = "1970-01-01"

            # isArchived: Boolean!
            # Specifies whether the SLA Domain is archived or not.
            $gsr.isArchived = $true

            # stateVersion: Long!
            # State version of the SLA Domain.
            $gsr.stateVersion = 1

            # clusterUuid: String!
            # Rubrik cluster ID of the SLA Domain.
            $gsr.clusterUuid = "What is this"

            # isDefault: Boolean!
            # Specifies whether the SLA Domain is a default SLA Domain or not.
            $gsr.isDefault = $true

            # isRetentionLockedSla: Boolean!
            # Specifies if this SLA Domain is retention-locked or not.
            $gsr.isRetentionLockedSla = $true

            # isReadOnly: Boolean
            # Specifies whether the SLA Domain is read-only.
            $gsr.isReadOnly = $true

            # retentionLockMode: RetentionLockMode!
            # Specifies the retention lock mode when enabled for the SLA Domain.
            $gsr.retentionLockMode = [RubrikSecurityCloud.Types.RetentionLockMode]::NO_MODE

            # objectTypes: [SlaObjectType!]!
            # The object-types supported by the SLA Domain.
            $gsr.objectTypes = @([RubrikSecurityCloud.Types.SlaObjectType]::KUPR_OBJECT_TYPE)

            # snapshotSchedule: SnapshotSchedule
            # Snapshot schedule for the SLA Domain.
            $gsr.SnapshotSchedule = New-Object -TypeName RubrikSecurityCloud.Types.SnapshotSchedule
                # minute: MinuteSnapshotSchedule
                # Minute schedule of the SLA Domain.
            $gsr.SnapshotSchedule.minute = New-Object -TypeName RubrikSecurityCloud.Types.MinuteSnapshotSchedule
            $gsr.SnapshotSchedule.minute.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
            $gsr.SnapshotSchedule.minute.basicSchedule.frequency = 1
            $gsr.SnapshotSchedule.minute.basicSchedule.retention = 1
            $gsr.SnapshotSchedule.minute.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # hourly: HourlySnapshotSchedule
                # Hourly schedule of the SLA Domain.
            $gsr.SnapshotSchedule.hourly = New-Object -TypeName RubrikSecurityCloud.Types.HourlySnapshotSchedule
            $gsr.SnapshotSchedule.hourly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
            $gsr.SnapshotSchedule.hourly.basicSchedule.frequency = 1
            $gsr.SnapshotSchedule.hourly.basicSchedule.retention = 1
            $gsr.SnapshotSchedule.hourly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # daily: DailySnapshotSchedule
                # Daily schedule of the SLA Domain.
            $gsr.SnapshotSchedule.daily = New-Object -TypeName RubrikSecurityCloud.Types.DailySnapshotSchedule
            $gsr.SnapshotSchedule.daily.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
            $gsr.SnapshotSchedule.daily.basicSchedule.frequency = 1
            $gsr.SnapshotSchedule.daily.basicSchedule.retention = 1
            $gsr.SnapshotSchedule.daily.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # weekly: WeeklySnapshotSchedule
                # Weekly schedule of the SLA Domain.
            $gsr.SnapshotSchedule.weekly = New-Object -TypeName RubrikSecurityCloud.Types.WeeklySnapshotSchedule
            $gsr.SnapshotSchedule.weekly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
            $gsr.SnapshotSchedule.weekly.basicSchedule.frequency = 1
            $gsr.SnapshotSchedule.weekly.basicSchedule.retention = 1
            $gsr.SnapshotSchedule.weekly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.SnapshotSchedule.weekly.dayOfWeek = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
                # monthly: MonthlySnapshotSchedule
                # Monthly schedule of the SLA Domain.
            $gsr.SnapshotSchedule.monthly = New-Object -TypeName RubrikSecurityCloud.Types.MonthlySnapshotSchedule
            $gsr.SnapshotSchedule.monthly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
            $gsr.SnapshotSchedule.monthly.basicSchedule.frequency = 1
            $gsr.SnapshotSchedule.monthly.basicSchedule.retention = 1
            $gsr.SnapshotSchedule.monthly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.SnapshotSchedule.monthly.dayOfMonth = [RubrikSecurityCloud.Types.DayOfMonth]::LAST_DAY
                # quarterly: QuarterlySnapshotSchedule
                # Quarterly schedule of the SLA Domain.
            $gsr.SnapshotSchedule.quarterly = New-Object -TypeName RubrikSecurityCloud.Types.QuarterlySnapshotSchedule
            $gsr.SnapshotSchedule.quarterly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
            $gsr.SnapshotSchedule.quarterly.basicSchedule.frequency = 1
            $gsr.SnapshotSchedule.quarterly.basicSchedule.retention = 1
            $gsr.SnapshotSchedule.quarterly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.SnapshotSchedule.quarterly.dayOfQuarter = [RubrikSecurityCloud.Types.DayOfQuarter]::FIRST_DAY
            $gsr.SnapshotSchedule.quarterly.quarterStartMonth = [RubrikSecurityCloud.Types.Month]::JANUARY
                # yearly: YearlySnapshotSchedule
                # Yearly schedule of the SLA Domain.
            $gsr.SnapshotSchedule.yearly = New-Object -TypeName RubrikSecurityCloud.Types.YearlySnapshotSchedule
            $gsr.SnapshotSchedule.yearly.basicSchedule = New-Object -TypeName RubrikSecurityCloud.Types.BasicSnapshotSchedule
            $gsr.SnapshotSchedule.yearly.basicSchedule.frequency = 1
            $gsr.SnapshotSchedule.yearly.basicSchedule.retention = 1
            $gsr.SnapshotSchedule.yearly.basicSchedule.retentionUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.SnapshotSchedule.yearly.dayOfYear = [RubrikSecurityCloud.Types.DayOfYear]::FIRST_DAY
            $gsr.SnapshotSchedule.yearly.yearStartMonth = [RubrikSecurityCloud.Types.Month]::JANUARY

            # localRetentionLimit: Duration
            # Local retention limit.
            $gsr.localRetentionLimit = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.localRetentionLimit.durationField = 1
            $gsr.localRetentionLimit.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # archivalSpec: ArchivalSpec
            # Archiving specification for the SLA Domain.
            ### Skipping this in favor of archivalSpecs

            # archivalSpecs: [ArchivalSpec!]!
            # List of archival specifications for SLA Domain.
            $gsr.ArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalSpec
                # threshold: Int!
                # Archival threshold.
                $gsr.ArchivalSpecs[0].threshold = 1

                # thresholdUnit: RetentionUnit!
                # Unit of archival threshold.
                $gsr.ArchivalSpecs[0].thresholdUnit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                # archivalTieringSpec: ArchivalTieringSpec
                # Archival tiering specification.
                $gsr.ArchivalSpecs[0].archivalTieringSpec = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalTieringSpec
                    # isInstantTieringEnabled: Boolean!
                    # True when instant tiering enabled.
                    $gsr.ArchivalSpecs[0].archivalTieringSpec.isInstantTieringEnabled = $true

                    # minAccessibleDurationInSeconds: Long!
                    # Minimum accessible duration specified for smart tiering.
                    $gsr.ArchivalSpecs[0].archivalTieringSpec.minAccessibleDurationInSeconds = 1

                    # coldStorageClass: ColdStorageClass!
                    # Cold storage class for tiering.
                    $gsr.ArchivalSpecs[0].archivalTieringSpec.coldStorageClass = [RubrikSecurityCloud.Types.ColdStorageClass]::AWS_GLACIER

                    # shouldTierExistingSnapshots: Boolean!
                    # Tier existing snapshots for instant tiering, when true.
                    $gsr.ArchivalSpecs[0].archivalTieringSpec.shouldTierExistingSnapshots = $true

                # frequencies: [RetentionUnit!]!
                # Archives all snapshots taken with the specified frequency.
                $gsr.ArchivalSpecs[0].frequencies = @([RubrikSecurityCloud.Types.RetentionUnit]::DAYS)

                # archivalLocationToClusterMapping: [ArchivalLocationToClusterMapping!]!
                # Mapping between archival location and Rubrik cluster.
                $gsr.ArchivalSpecs[0].archivalLocationToClusterMapping = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationToClusterMapping

                    # cluster: SlaArchivalCluster
                    # Cluster on which the archival location is created.
                    $gsr.ArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaArchivalCluster
                    $gsr.ArchivalSpecs[0].archivalLocationToClusterMapping[0].cluster.id = "FETCH"
                    # Only need ID for updating SLA

                    # location: DlsArchivalLocation
                    # Location used as archival target.
                    $gsr.ArchivalSpecs[0].archivalLocationToClusterMapping[0].location = New-Object -TypeName RubrikSecurityCloud.Types.DlsArchivalLocation
                    $gsr.ArchivalSpecs[0].archivalLocationToClusterMapping[0].location.id = "FETCH"
                    # Only need ID for updating SLA

                # storageSetting: TargetMapping
                # Storage settings of an archival group.
                # Don't need storageSetting for updates. Just getting ID here.
                $gsr.ArchivalSpecs[0].storageSetting = New-Object -TypeName RubrikSecurityCloud.Types.TargetMapping
                $gsr.ArchivalSpecs[0].storageSetting.id = "FETCH"

            # replicationSpec: ReplicationSpec
            # Replication specification for the SLA Domain.
            # Skipping in favor of replicationSpecsV2

            # replicationSpecsV2: [ReplicationSpecV2!]!
            # Replication specification for the SLA Domain.
            $gsr.ReplicationSpecsV2 = New-Object -TypeName RubrikSecurityCloud.Types.ReplicationSpecV2
                # retentionDuration: Duration
                # Retention duration.
                $gsr.ReplicationSpecsV2[0].retentionDuration = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                $gsr.ReplicationSpecsV2[0].retentionDuration.durationField = 1
                $gsr.ReplicationSpecsV2[0].retentionDuration.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                # replicationLocalRetentionDuration: Duration
                # Time snapshot is kept on local target cluster.
                $gsr.ReplicationSpecsV2[0].replicationLocalRetentionDuration = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                $gsr.ReplicationSpecsV2[0].replicationLocalRetentionDuration.durationField = 1
                $gsr.ReplicationSpecsV2[0].replicationLocalRetentionDuration.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                # cascadingArchivalSpecs: [CascadingArchivalSpec!]!
                # Cascading Archival Specifications.
                $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs = New-Object -TypeName RubrikSecurityCloud.Types.CascadingArchivalSpec
                    # archivalThreshold: Duration
                    # Threshold after which the snapshot will be archived.
                    $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold = New-Object -TypeName RubrikSecurityCloud.Types.Duration
                    $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold.durationField = 1
                    $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalThreshold.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

                    # archivalTieringSpec: ArchivalTieringSpec
                    # Archival tiering specification.
                    $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalTieringSpec
                        # isInstantTieringEnabled: Boolean = false
                        # Set when instant tiering enabled.
                        $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.isInstantTieringEnabled = $true

                        # minAccessibleDurationInSeconds: Long = 0
                        # Min accessible duration specified for smart tiering.
                        $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.minAccessibleDurationInSeconds = 1

                        # coldStorageClass: ColdStorageClass = COLD_STORAGE_CLASS_UNKNOWN
                        # Cold storage class for tiering.
                        $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.coldStorageClass = [RubrikSecurityCloud.Types.ColdStorageClass]::COLD_STORAGE_CLASS_UNKNOWN

                        # shouldTierExistingSnapshots: Boolean = false
                        # Set to tier existing snapshots for instant tiering.
                        $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalTieringSpec.shouldTierExistingSnapshots = $true

                    # frequency: [RetentionUnit!]!
                    # Frequencies that are associated with this cascaded archival location.
                    $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].frequency = @([RubrikSecurityCloud.Types.RetentionUnit]::DAYS)

                    # archivalLocation: Target
                    # Archival location for snapshot on target.
                    $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation = New-Object RubrikSecurityCloud.Types.RubrikManagedAwsTarget
                    $gsr.ReplicationSpecsV2[0].cascadingArchivalSpecs[0].archivalLocation.id = "FETCH"

                # cluster: SlaReplicationCluster
                # Rubrik cluster used as the replication target.
                $gsr.ReplicationSpecsV2[0].cluster = New-Object -TypeName RubrikSecurityCloud.Types.SlaReplicationCluster
                $gsr.ReplicationSpecsV2[0].cluster.id = "FETCH"
                $gsr.ReplicationSpecsV2[0].cluster.name = "FETCH"

                # awsRegion: String!
                # AWS region.
                $gsr.ReplicationSpecsV2[0].awsRegion = "FETCH"

                # azureRegion: String!
                # Azure Region.
                $gsr.ReplicationSpecsV2[0].azureRegion = "FETCH"

                # awsTarget: AwsReplicationTarget!
                # AWS location used as the replication target.
                $gsr.ReplicationSpecsV2[0].awsTarget = New-Object -TypeName RubrikSecurityCloud.Types.AwsReplicationTarget
                $gsr.ReplicationSpecsV2[0].awsTarget.accountId = "FETCH"
                $gsr.ReplicationSpecsV2[0].awsTarget.accountName = "FETCH"
                $gsr.ReplicationSpecsV2[0].awsTarget.region = [RubrikSecurityCloud.Types.AwsNativeRegionForReplication]::US_EAST_1

                # azureTarget: AzureReplicationTarget!
                # Azure location used as the replication target.
                $gsr.ReplicationSpecsV2[0].azureTarget = New-Object -TypeName RubrikSecurityCloud.Types.AzureReplicationTarget
                $gsr.ReplicationSpecsV2[0].azureTarget.subscriptionId = "FETCH"
                $gsr.ReplicationSpecsV2[0].azureTarget.subscriptionName = "FETCH"
                $gsr.ReplicationSpecsV2[0].azureTarget.region = [RubrikSecurityCloud.Types.AzureNativeRegionForReplication]::EAST_US

            # baseFrequency: Duration
            # Base frequency for the SLA Domain.
            $gsr.baseFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.baseFrequency.durationField = 1
            $gsr.baseFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # firstFullBackupWindows: [BackupWindow!]!
            # First full backup windows.
            $gsr.firstFullBackupWindows = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindow
            $gsr.firstFullBackupWindows[0].durationInHours = 1
            $gsr.firstFullBackupWindows[0].startTimeAttributes = New-Object -TypeName RubrikSecurityCloud.Types.StartTimeAttributes
            $gsr.firstFullBackupWindows[0].startTimeAttributes.dayOfWeek = New-Object RubrikSecurityCloud.Types.DayOfWeekOpt
            $gsr.firstFullBackupWindows[0].startTimeAttributes.dayOfWeek.day = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
            $gsr.firstFullBackupWindows[0].startTimeAttributes.hour = 1
            $gsr.firstFullBackupWindows[0].startTimeAttributes.minute = 1

            # backupWindows: [BackupWindow!]!
            # Backup windows for the SLA Domain.
            $gsr.backupWindows = New-Object -TypeName RubrikSecurityCloud.Types.BackupWindow
            $gsr.backupWindows[0].durationInHours = 1
            $gsr.backupWindows[0].startTimeAttributes = New-Object -TypeName RubrikSecurityCloud.Types.StartTimeAttributes
            $gsr.backupWindows[0].startTimeAttributes.dayOfWeek = New-Object RubrikSecurityCloud.Types.DayOfWeekOpt
            $gsr.backupWindows[0].startTimeAttributes.dayOfWeek.day = [RubrikSecurityCloud.Types.DayOfWeek]::FRIDAY
            $gsr.backupWindows[0].startTimeAttributes.hour = 1
            $gsr.backupWindows[0].startTimeAttributes.minute = 1

            # clusterToSyncStatusMap: [GlobalSlaSyncStatus!]!
            # Sync status of the clusters.
            $gsr.clusterToSyncStatusMap = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaSyncStatus
            $gsr.clusterToSyncStatusMap[0].clusterUuid = "FETCH"
            $gsr.clusterToSyncStatusMap[0].slaSyncStatus = [RubrikSecurityCloud.Types.SlaSyncStatus]::SUCCEEDED

            # objectSpecificConfigs: ObjectSpecificConfigs
            # The object-specific configurations of the SLA Domain.
            $gsr.objectSpecificConfigs = New-Object -TypeName RubrikSecurityCloud.Types.ObjectSpecificConfigs
                    # sapHanaConfig: SapHanaConfig
                    # SLA Domain configuration for SAP HANA object.
                    $gsr.objectSpecificConfigs.SapHanaConfig = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaConfig
            $gsr.objectSpecificConfigs.SapHanaConfig.incrementalFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.SapHanaConfig.incrementalFrequency.durationField = 1
            $gsr.objectSpecificConfigs.SapHanaConfig.incrementalFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.SapHanaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.SapHanaConfig.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.SapHanaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.SapHanaConfig.differentialFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.SapHanaConfig.differentialFrequency.durationField = 1
            $gsr.objectSpecificConfigs.SapHanaConfig.differentialFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaStorageSnapshotConfig
            $gsr.objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency.durationField = 1
            $gsr.objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention.durationField = 1
            $gsr.objectSpecificConfigs.SapHanaConfig.storageSnapshotConfig.retention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    # awsRdsConfig: AwsRdsConfig
                    # SLA Domain configuration for AWS RDS object.
                    $gsr.objectSpecificConfigs.awsRdsConfig = New-Object -TypeName RubrikSecurityCloud.Types.AwsRdsConfig
            $gsr.objectSpecificConfigs.awsRdsConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.awsRdsConfig.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.awsRdsConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    # vmwareVmConfig: VmwareVmConfig
                    # SLA Domain configuration for VMware virtual machine object.
                    $gsr.objectSpecificConfigs.vmwareVmConfig = New-Object -TypeName RubrikSecurityCloud.Types.VmwareVmConfig
            $gsr.objectSpecificConfigs.vmwareVmConfig.logRetentionSeconds = 1
                    # azureSqlDatabaseDbConfig: AzureSqlDatabaseDbConfig
                    # SLA Domain configuration for Azure SQL Database DB object.
                    $gsr.objectSpecificConfigs.AzureSqlDatabaseDbConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlDatabaseDbConfig
                    $gsr.objectSpecificConfigs.AzureSqlDatabaseDbConfig.logRetentionInDays = 1

                    # azureSqlManagedInstanceDbConfig: AzureSqlManagedInstanceDbConfig
                    # SLA Domain configuration for Azure SQL Managed Instance DB object.
                    $gsr.objectSpecificConfigs.AzureSqlManagedInstanceDbConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlManagedInstanceDbConfig
                    $gsr.objectSpecificConfigs.AzureSqlManagedInstanceDbConfig.logRetentionInDays = 1

                    # db2Config: Db2Config
                    # SLA Domain configuration for Db2 database object.
                    $gsr.objectSpecificConfigs.db2Config = New-Object -TypeName RubrikSecurityCloud.Types.Db2Config
            $gsr.objectSpecificConfigs.db2Config.incrementalFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.db2Config.incrementalFrequency.durationField = 1
            $gsr.objectSpecificConfigs.db2Config.incrementalFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.db2Config.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.db2Config.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.db2Config.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.db2Config.differentialFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.db2Config.differentialFrequency.durationField = 1
            $gsr.objectSpecificConfigs.db2Config.differentialFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.db2Config.logArchivalMethod = [RubrikSecurityCloud.Types.LogArchivalMethod]::LOGARCHMET_H1
                    # mssqlConfig: MssqlConfig
                    # SLA Domain configuration for SQL Server database object.
                    $gsr.objectSpecificConfigs.mssqlConfig = New-Object -TypeName RubrikSecurityCloud.Types.MssqlConfig
            $gsr.objectSpecificConfigs.mssqlConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.mssqlConfig.frequency.durationField = 1
            $gsr.objectSpecificConfigs.mssqlConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.mssqlConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.mssqlConfig.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.mssqlConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    # oracleConfig: OracleConfig
                    # SLA Domain configuration for Oracle database object.
                    $gsr.objectSpecificConfigs.oracleConfig = New-Object -TypeName RubrikSecurityCloud.Types.OracleConfig
            $gsr.objectSpecificConfigs.oracleConfig.frequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.oracleConfig.frequency.durationField = 1
            $gsr.objectSpecificConfigs.oracleConfig.frequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.oracleConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.oracleConfig.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.oracleConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.oracleConfig.hostLogRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.oracleConfig.hostLogRetention.durationField = 1
            $gsr.objectSpecificConfigs.oracleConfig.hostLogRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    # mongoConfig: MongoConfig
                    # SLA Domain configuration for MongoDB database object.
                    $gsr.objectSpecificConfigs.mongoConfig = New-Object -TypeName RubrikSecurityCloud.Types.MongoConfig
            $gsr.objectSpecificConfigs.mongoConfig.logFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.mongoConfig.logFrequency.durationField = 1
            $gsr.objectSpecificConfigs.mongoConfig.logFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.mongoConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.mongoConfig.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.mongoConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    # azureBlobConfig: AzureBlobConfig
                    # SLA Domain configuration for Azure Blob object.
                    $gsr.objectSpecificConfigs.azureBlobConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureBlobConfig
            $gsr.objectSpecificConfigs.azureBlobConfig.continuousBackupRetentionInDays = 1
            $gsr.objectSpecificConfigs.azureBlobConfig.backupLocationId = "FETCH"
            $gsr.objectSpecificConfigs.azureBlobConfig.backupLocationName = "FETCH"
                    # awsNativeS3SlaConfig: AwsNativeS3SlaConfig
                    # SLA Domain configuration for AWS S3 bucket.
                    $gsr.objectSpecificConfigs.awsNativeS3SlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.AwsNativeS3SlaConfig
            $gsr.objectSpecificConfigs.awsNativeS3SlaConfig.continuousBackupRetentionInDays = 1
            $gsr.objectSpecificConfigs.awsNativeS3SlaConfig.archivalLocationId = "FETCH"
            $gsr.objectSpecificConfigs.awsNativeS3SlaConfig.archivalLocationName = "FETCH"
                    # managedVolumeSlaConfig: ManagedVolumeSlaConfig
                    # SLA Domain configuration for Managed Volume object.
                    $gsr.objectSpecificConfigs.managedVolumeSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.ManagedVolumeSlaConfig
            $gsr.objectSpecificConfigs.managedVolumeSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.managedVolumeSlaConfig.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.managedVolumeSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    # postgresDbClusterSlaConfig: PostgresDbClusterSlaConfig
                    # SLA Domain configuration for Postgres DB Cluster object.
                    $gsr.objectSpecificConfigs.postgresDbClusterSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.PostgresDbClusterSlaConfig
            $gsr.objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.postgresDbClusterSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
                    # mysqldbSlaConfig: MysqldbSlaConfig
                    # SLA Domain configuration for MySQL object.
                    $gsr.objectSpecificConfigs.mysqldbSlaConfig = New-Object -TypeName RubrikSecurityCloud.Types.MysqldbSlaConfig
            $gsr.objectSpecificConfigs.mysqldbSlaConfig.logFrequency = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.mysqldbSlaConfig.logFrequency.durationField = 1
            $gsr.objectSpecificConfigs.mysqldbSlaConfig.logFrequency.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS
            $gsr.objectSpecificConfigs.mysqldbSlaConfig.logRetention = New-Object -TypeName RubrikSecurityCloud.Types.Duration
            $gsr.objectSpecificConfigs.mysqldbSlaConfig.logRetention.durationField = 1
            $gsr.objectSpecificConfigs.mysqldbSlaConfig.logRetention.unit = [RubrikSecurityCloud.Types.RetentionUnit]::DAYS

            # upgradeInfo: SlaUpgradeInfo
            # SLA Domain upgrade information.
            $gsr.upgradeInfo = New-Object -TypeName RubrikSecurityCloud.Types.SlaUpgradeInfo
            $gsr.upgradeInfo.eligibility = New-Object -TypeName RubrikSecurityCloud.Types.SlaUpgradeEligibility
            $gsr.upgradeInfo.eligibility.isEligible = $true
            $gsr.upgradeInfo.eligibility.ineligibilityReason = [RubrikSecurityCloud.Types.SlaMigrationIneligibilityReason]::CLUSTER_DISCONNECTED

            # pausedClustersInfo: PausedClustersInfo
            # Information about Rubrik clusters where this SLA Domain is paused.
            $gsr.pausedClustersInfo = New-Object -TypeName RubrikSecurityCloud.Types.PausedClustersInfo
            $gsr.pausedClustersInfo.pausedClustersCount = 1
            $gsr.pausedClustersInfo.pausedClusters = New-Object RubrikSecurityCloud.Types.Cluster
            $gsr.pausedClustersInfo.pausedClusters[0].id = "FETCH"

            # allOrgsHavingAccess: [SlaAssociatedOrganization!]!
            # Specifies the list of organizations that have view access for the SLA Domain.
            $gsr.allOrgsHavingAccess = New-Object -TypeName RubrikSecurityCloud.Types.SlaAssociatedOrganization
            $gsr.allOrgsHavingAccess[0].name = "FETCH"
            $gsr.allOrgsHavingAccess[0].id = "FETCH"

            # ownerOrg: SlaAssociatedOrganization!
            # Specifies the owner organization of the SLA Domain.
            $gsr.ownerOrg = New-Object -TypeName RubrikSecurityCloud.Types.SlaAssociatedOrganization
            $gsr.ownerOrg.name = "FETCH"
            $gsr.ownerOrg.id = "FETCH"

            # archivalLocationsUpgradeInfo: [ArchivalLocationUpgradeInfo!]
            # Upgrade information about the configured archival locations and cascading archival locations.
            $gsr.archivalLocationsUpgradeInfo = New-Object -TypeName RubrikSecurityCloud.Types.ArchivalLocationUpgradeInfo
            $gsr.archivalLocationsUpgradeInfo[0].locationId = "FETCH"

            # sourceClusters: [SlaDataLocationCluster!]!
            # Source clusters configured in the SLA Domain.
            # Intentionally skipped.
        }

        if ($Id) {
            $query = New-RscQuery -Gql slaDomain
            $query.var.id = $Id

            # SlaDomain is a GraphQL interface — the field spec is a
            # composite chain with one node per implementing type.
            $nodes = $query.field.AsList()
            $cdm = $nodes["ClusterSlaDomain"]  # ClusterSlaDomain
            $gsr = $nodes["GlobalSlaReply"]    # GlobalSlaReply

            #id: String!
            # SLA Domain ID.
            $cdm.id = "FETCH"
            # name: String!
            # SLA Domain name.
            $cdm.name = "FETCH"

            Set-GsrFields $gsr

            if ( $AsQuery ) {
                return $query
            }

            $result = $query.Invoke()
            $result
        }
        else {
            $query = New-RscQuery -Gql slaDomains
            $gsr = $query.field.nodes | Where-Object { $_.GetType().Name -eq "GlobalSlaReply" } | Select-Object -First 1
            $query.var.shouldShowProtectedObjectCount = $true
            if ($First -gt 0) {
                $query.var.first = $First
            }
            $query.var.filter = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSlaFilterInput
            $query.var.filter.Field = [RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]::NAME
            $query.var.filter.Text = $Name

            #id: String!
            # SLA Domain ID.
            $gsr.id = "FETCH"
            # name: String!
            # SLA Domain name.
            $gsr.name = "FETCH"

            Set-GsrFields $gsr

            if ( $AsQuery ) {
                return $query
            }

            $result = $query.Invoke()
            $result.Nodes
        }
    }
}
