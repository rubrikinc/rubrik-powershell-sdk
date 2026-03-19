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

        # Shared helper: populate GlobalSlaReply field spec using Get-RscType.
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
            $gsr.SnapshotSchedule = Get-RscType -Name SnapshotSchedule -InitialProperties @(
                "minute.basicSchedule.*",
                "hourly.basicSchedule.*",
                "daily.basicSchedule.*",
                "weekly.basicSchedule.*",
                "weekly.dayOfWeek",
                "monthly.basicSchedule.*",
                "monthly.dayOfMonth",
                "quarterly.basicSchedule.*",
                "quarterly.dayOfQuarter",
                "quarterly.quarterStartMonth",
                "yearly.basicSchedule.*",
                "yearly.dayOfYear",
                "yearly.yearStartMonth"
            )

            # localRetentionLimit: Duration
            # Local retention limit.
            $gsr.localRetentionLimit = Get-RscType -Name Duration -InitialProperties @("*")

            # archivalSpec: ArchivalSpec
            # Archiving specification for the SLA Domain.
            ### Skipping this in favor of archivalSpecs

            # archivalSpecs: [ArchivalSpec!]!
            # List of archival specifications for SLA Domain.
            $gsr.ArchivalSpecs = Get-RscType -Name ArchivalSpec -InitialProperties @(
                "threshold",
                "thresholdUnit",
                "archivalTieringSpec.isInstantTieringEnabled",
                "archivalTieringSpec.minAccessibleDurationInSeconds",
                "archivalTieringSpec.coldStorageClass",
                "archivalTieringSpec.shouldTierExistingSnapshots",
                "frequencies",
                "archivalLocationToClusterMapping.cluster.id",
                "archivalLocationToClusterMapping.location.id",
                "storageSetting.id"
            )

            # replicationSpec: ReplicationSpec
            # Replication specification for the SLA Domain.
            # Skipping in favor of replicationSpecsV2

            # replicationSpecsV2: [ReplicationSpecV2!]!
            # Replication specification for the SLA Domain.
            $gsr.ReplicationSpecsV2 = Get-RscType -Name ReplicationSpecV2 -InitialProperties @(
                "retentionDuration.*",
                "replicationLocalRetentionDuration.*",
                "cascadingArchivalSpecs.archivalThreshold.*",
                "cascadingArchivalSpecs.archivalTieringSpec.isInstantTieringEnabled",
                "cascadingArchivalSpecs.archivalTieringSpec.minAccessibleDurationInSeconds",
                "cascadingArchivalSpecs.archivalTieringSpec.coldStorageClass",
                "cascadingArchivalSpecs.archivalTieringSpec.shouldTierExistingSnapshots",
                "cascadingArchivalSpecs.frequency",
                "cascadingArchivalSpecs.archivalLocation.on:RubrikManagedAwsTarget.id",
                "cluster.id",
                "cluster.name",
                "awsRegion",
                "azureRegion",
                "awsTarget.accountId",
                "awsTarget.accountName",
                "awsTarget.region",
                "azureTarget.subscriptionId",
                "azureTarget.subscriptionName",
                "azureTarget.region"
            )
            # Commented-out fields kept for reference:
            #   cascadingArchivalSpecs.archivalLocationToClusterMapping (not needed)
            #   targetMapping (not needed for SLA updates)
            #   replicationPairs (feature still in development)

            # baseFrequency: Duration
            # Base frequency for the SLA Domain.
            $gsr.baseFrequency = Get-RscType -Name Duration -InitialProperties @("*")

            # firstFullBackupWindows: [BackupWindow!]!
            # First full backup windows.
            $gsr.firstFullBackupWindows = Get-RscType -Name BackupWindow -InitialProperties @(
                "durationInHours",
                "startTimeAttributes.dayOfWeek.day",
                "startTimeAttributes.hour",
                "startTimeAttributes.minute"
            )

            # backupWindows: [BackupWindow!]!
            # Backup windows for the SLA Domain.
            $gsr.backupWindows = Get-RscType -Name BackupWindow -InitialProperties @(
                "durationInHours",
                "startTimeAttributes.dayOfWeek.day",
                "startTimeAttributes.hour",
                "startTimeAttributes.minute"
            )

            # clusterToSyncStatusMap: [GlobalSlaSyncStatus!]!
            # Sync status of the clusters.
            $gsr.clusterToSyncStatusMap = Get-RscType -Name GlobalSlaSyncStatus -InitialProperties @("*")

            # objectSpecificConfigs: ObjectSpecificConfigs
            # The object-specific configurations of the SLA Domain.
            $gsr.objectSpecificConfigs = Get-RscType -Name ObjectSpecificConfigs -InitialProperties @(
                "SapHanaConfig.incrementalFrequency.*",
                "SapHanaConfig.logRetention.*",
                "SapHanaConfig.differentialFrequency.*",
                "SapHanaConfig.storageSnapshotConfig.frequency.*",
                "SapHanaConfig.storageSnapshotConfig.retention.*",
                "awsRdsConfig.logRetention.*",
                "vmwareVmConfig.logRetentionSeconds",
                "AzureSqlDatabaseDbConfig.logRetentionInDays",
                "AzureSqlManagedInstanceDbConfig.logRetentionInDays",
                "db2Config.incrementalFrequency.*",
                "db2Config.logRetention.*",
                "db2Config.differentialFrequency.*",
                "db2Config.logArchivalMethod",
                "mssqlConfig.frequency.*",
                "mssqlConfig.logRetention.*",
                "oracleConfig.frequency.*",
                "oracleConfig.logRetention.*",
                "oracleConfig.hostLogRetention.*",
                "mongoConfig.logFrequency.*",
                "mongoConfig.logRetention.*",
                "azureBlobConfig.continuousBackupRetentionInDays",
                "azureBlobConfig.backupLocationId",
                "azureBlobConfig.backupLocationName",
                "awsNativeS3SlaConfig.continuousBackupRetentionInDays",
                "awsNativeS3SlaConfig.archivalLocationId",
                "awsNativeS3SlaConfig.archivalLocationName",
                "managedVolumeSlaConfig.logRetention.*",
                "postgresDbClusterSlaConfig.logRetention.*",
                "mysqldbSlaConfig.logFrequency.*",
                "mysqldbSlaConfig.logRetention.*"
            )

            # upgradeInfo: SlaUpgradeInfo
            # SLA Domain upgrade information.
            $gsr.upgradeInfo = Get-RscType -Name SlaUpgradeInfo -InitialProperties @(
                "eligibility.*"
            )

            # pausedClustersInfo: PausedClustersInfo
            # Information about Rubrik clusters where this SLA Domain is paused.
            $gsr.pausedClustersInfo = Get-RscType -Name PausedClustersInfo -InitialProperties @(
                "pausedClustersCount",
                "pausedClusters.id"
            )

            # allOrgsHavingAccess: [SlaAssociatedOrganization!]!
            # Specifies the list of organizations that have view access for the SLA Domain.
            $gsr.allOrgsHavingAccess = Get-RscType -Name SlaAssociatedOrganization -InitialProperties @("*")

            # ownerOrg: SlaAssociatedOrganization!
            # Specifies the owner organization of the SLA Domain.
            $gsr.ownerOrg = Get-RscType -Name SlaAssociatedOrganization -InitialProperties @("*")

            # archivalLocationsUpgradeInfo: [ArchivalLocationUpgradeInfo!]
            # Upgrade information about the configured archival locations and cascading archival locations.
            $gsr.archivalLocationsUpgradeInfo = Get-RscType -Name ArchivalLocationUpgradeInfo -InitialProperties @(
                "locationId"
            )

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
