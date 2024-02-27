#Requires -Version 3
function Set-RscSla
{
    <#
    .SYNOPSIS
    Updates an existing Rubrik SLA Domain

    .DESCRIPTION
    The Set-RscSla cmdlet will update an existing SLA Domain. Rubrik SLA
    Domains are policies that define the frequency, retention, and rules for
    acrhival and replication.

    This Cmdlet offers a 'PATCH' experience over the Graphql mutation to update
    the Global SLA Domain which otherwise behaves like a 'PUT' operation. You
    only need to provide the fields that you want to update.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Id
    The ID of the SLA Domain to update.

    .PARAMETER Name
    The new name of the SLA Domain.

    .PARAMETER Description
    The new description of the SLA Domain.

    .PARAMETER MinuteSchedule
    The new Minute Schedule of the SLA Domain.

    .PARAMETER HourlySchedule
    The new Hourly Schedule of the SLA Domain.

    .PARAMETER DailySchedule
    The new Daily Schedule of the SLA Domain.

    .PARAMETER WeeklySchedule
    The new Weekly Schedule of the SLA Domain.

    .PARAMETER MonthlySchedule
    The new Monthly Schedule of the SLA Domain.

    .PARAMETER QuarterlySchedule
    The new Quarterly Schedule of the SLA Domain.

    .PARAMETER YearlySchedule
    The new Yearly Schedule of the SLA Domain.

    .PARAMETER UserNote
    An optional note to add to the SLA Domain.

    .PARAMETER ObjectTypes
    The list of object types to which this SLA Domain applies.

    .PARAMETER LocalRetentionLimit
    Retention limit for snapshots on the local Rubrik system. If none, they will remain as long as SLA requires.

    .PARAMETER BackupWindows
    The list of backup windows for the SLA Domain.

    .PARAMETER FirstFullBackupWindows
    The list of first full backup windows for the SLA Domain.

    .PARAMETER ShouldApplyToExistingSnapshots
    Should the SLA be applied to existing snapshots.

    .PARAMETER ShouldApplyToNonPolicySnapshots
    Should the SLA be applied to non-policy snapshots.

    .PARAMETER RetentionLockSla
    Should the SLA be a retention locked SLA.

    .PARAMETER RetentionLockMode
    The retention lock mode for the intended SLA Domain update.

    .PARAMETER ArchivalSpecs
    Archival specs for this SLA.

    .PARAMETER ReplicationSpecs
    Replication specs for this SLA.

    .PARAMETER VmwareVmConfig
    VmwareVm specific settings of this SLA.

    .PARAMETER OracleConfig
    Oracle specific settings of this SLA.

    .PARAMETER SapHana
    SAP HANA specific settings of this SLA.

    .PARAMETER AwsRds
    AWS RDS specific settings of this SLA.

    .PARAMETER AzureSqlDatabaseConfig
    Azure Sql DatabaseDb specific settings of this SLA.

    .PARAMETER AzureSqlManagedInstanceConfig
    Azure Sql Managed InstanceDb specific settings of this SLA.

    .PARAMETER Db2Config
    Db2 specific settings of this SLA.

    .PARAMETER MsSqlConfig
    MS Sql specific settings of this SLA.

    .PARAMETER MongoConfig
    Mongo specific settings of this SLA.

    .PARAMETER AzureBlobConfig
    Azure Blob specific settings of this SLA.

    .PARAMETER AwsNativeS3Config
    Aws Native S3 specific settings of this SLA.

    .PARAMETER ManagedVolumeConfig
    Managed Volume specific settings of this SLA.

    .PARAMETER PostgresDbClusterConfig
    Postgres Db Cluster specific settings of this SLA.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    The example below updates the SLA Domain with the ID
    '01646285-9b5f-4b54-ae0e-c829e148453e' to have a new name, description,
    and snapshot schedule.

    A new snapshot schedule is first created using the New-RscSlaSnapshotSchedule cmdlet.

    $dailySchedule = New-RscSlaSnapshotSchedule -Type Daily -Frequency 2 -Retention 1 -RetentionUnit MONTHS
    $name = 'New SLA Domain Name'
    $description = 'New SLA Domain Description'
    Set-RscSla -ID '01646285-9b5f-4b54-ae0e-c829e148453e' -Name $name -Description $description -DailySchedule $dailySchedule

    .EXAMPLE
    A more complicated example. Here we update oracle specific config of the
    SLA along with backup window and archival specifcations of the SLA.

    $name='Name assigned via Powershell-SDK'
    $description = 'Description updated by SDK.'
    $objectTypes = @('ORACLE_OBJECT_TYPE', 'VSPHERE_OBJECT_TYPE')

    $dailySchedule = New-RscSlaSnapshotSchedule -Type Daily
    -Frequency 2 -Retention 6 -RetentionUnit DAYS

    $monthlySchedule = New-RscSlaSnapshotSchedule -Type Monthly
    -Frequency 1 -Retention 7 -RetentionUnit MONTHS

    $yearlySchedule = New-RscSlaSnapshotSchedule -Type Yearly
    -Frequency 1 -Retention 3 -RetentionUnit YEARS

    $backupWindow=New-RscSlaBackupWindow -Duration 2
    -DayOfWeek TUESDAY -Hour 1 -Minute 30

    $slaDuration = New-RscSlaDuration -Duration 10 -Unit DAYS

    $oracle = New-RscSlaObjectSpecificConfig -Oracle
    -Frequency $slaDuration -LogRetention $slaDuration

    $archivalSpec = New-RscSlaArchivalSpecs -ArchivalThreshold 230
    -Frequencies @('MONTHS','YEARS') -ArchivalThresholdUnit DAYS
    -ClusterUuids @('9c930153-2a3c-4b7d-8603-48145315e71f')
    -LocationIds @('aa137af1-6abf-59aa-984f-a9ac21301f0e')

    Set-RscSla -ID '6dd0b7ed-15b9-431b-bc15-89d539aee65e'
    -Name $name -Description $description -ObjectTypes $objectTypes
    -DailySchedule $dailySchedule -MonthlySchedule $monthlySchedule
    -YearlySchedule $yearlySchedule -BackupWindows @($backupWindow)
    -LocalRetentionLimit $slaDuration -OracleConfig $oracle
    -ArchivalSpecs @($archivalSpec) -UserNote $userNote

    .EXAMPLE
    $replicationSpec = New-RscSlaReplicationSpecs
    -ClusterUuid '33eab10e-c0d8-459d-907c-b19c6958ef76'
    -RetentionDuration (New-RscSlaDuration -Duration 12 -Unit DAYS)

    Set-RscSlaDomain -ID 'daa1807c-c766-4826-9ddb-fa3e87774a77' -Name $name
    -Description $description -ObjectTypes $objectTypes
    -HourlySchedule $hourlySchedule -WeeklySchedule $weeklySchedule
    -LocalRetentionLimit $slaDuration -ReplicationSpecs @($replicationSpec)
    #>

    [CmdletBinding()]
    Param(
        # Global SLA ID
        [Parameter(Mandatory)]
        [ValidateNotNullOrEmpty()]
        [String]$Id,

        # SLA Domain Name
        [Parameter()]
        [String]$Name,

        # SLA Domain Description
        [Parameter()]
        [String]$Description,

        # Minute Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.MinuteSnapshotScheduleInput]$MinuteSchedule,

        # Hourly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.HourlySnapshotScheduleInput]$HourlySchedule,

        # Daily Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.DailySnapshotScheduleInput]$DailySchedule,

        # Weekly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.WeeklySnapshotScheduleInput]$WeeklySchedule,

        # Monthly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.MonthlySnapshotScheduleInput]$MonthlySchedule,

        # Quarterly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.QuarterlySnapshotScheduleInput]$QuarterlySchedule,

        # Yearly Schedule object
        [Parameter()]
        [RubrikSecurityCloud.Types.YearlySnapshotScheduleInput]$YearlySchedule,

        # SLA Domain object type
        [Parameter()]
        [RubrikSecurityCloud.Types.SlaObjectType[]]$ObjectTypes,

        # Local Retention Limit
        [Parameter()]
        [RubrikSecurityCloud.Types.SlaDurationInput]$LocalRetentionLimit,

        # Backup Windows
        [Parameter()]
        [RubrikSecurityCloud.Types.BackupWindowInput[]]$BackupWindows,

        # First full Backup Windows
        [Parameter()]
        [RubrikSecurityCloud.Types.BackupWindowInput[]]$FirstFullBackupWindows,

        # Should the SLA be applied to existing snapshots
        [Parameter()]
        [Switch]$ShouldApplyToExistingSnapshots,

        # Should the SLA be applied to non-policy snapshots
        [Parameter()]
        [Switch]$ShouldApplyToNonPolicySnapshots,

        # Retention Lock SLA
        [Parameter()]
        [Switch]$RetentionLockSla,

        # The retention lock mode for the intended SLA Domain update.
        [Parameter()]
        [RubrikSecurityCloud.Types.RetentionLockMode]
        $RetentionLockMode = [RubrikSecurityCloud.Types.RetentionLockMode]::NO_MODE,

        # Archival specs for this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.ArchivalSpecInput[]]$ArchivalSpecs,

        # Replication specs for this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.ReplicationSpecV2Input[]]$ReplicationSpecs,

        # VmwareVm specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.VmwareVmConfigInput]$VmwareVmConfig,

        # Oracle specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.OracleConfigInput]$OracleConfig,

        # SAP HANA specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.SapHanaConfigInput]$SapHanaConfig,

        # AWS RDS specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AwsRdsConfigInput]$AwsRdsConfig,

        # Azure Sql DatabaseDb specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AzureSqlDatabaseDbConfigInput]$AzureSqlDatabaseConfig,

        # Azure Sql Managed InstanceDb specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AzureSqlManagedInstanceDbConfigInput]$AzureSqlManagedInstanceConfig,

        # Db2 specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.Db2ConfigInput]$Db2Config,

        # MS Sql specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.MsSqlConfigInput]$MsSqlConfig,

        # Mongo specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.MongoConfigInput]$MongoConfig,

        # AzureBlob specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AzureBlobConfigInput]$AzureBlobConfig,

        # Aws Native S3 specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.AwsNativeS3SlaConfigInput]$AwsNativeS3Config,

        # Managed Volume specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.ManagedVolumeSlaConfigInput]$ManagedVolumeConfig,

        # Postgres Db Cluster specific settings of this SLA.
        [Parameter()]
        [RubrikSecurityCloud.Types.PostgresDbClusterSlaConfigInput]$PostgresDbClusterConfig,

        # User Note
        [Parameter()]
        [String]$UserNote,

        # Should Cmdlet return the query object instead of running it
        [Parameter()]
        [Switch]$AsQuery
    )

    Process {
        $mutation = New-RscMutationSla -Operation UpdateGlobal
        $mutation.Var.Input =
            New-Object -TypeName RubrikSecurityCloud.Types.UpdateGlobalSlaInput
        $mutation.Var.Input.id = $Id

        # TODO(Aman) [SPARK-330821]: fetch the current configuration of SLA from
        # the server and initialise the input object with the current values

        if ($Name) {
            $mutation.Var.Input.Name = $Name
        }
        if ($Description) {
            $mutation.Var.Input.Description = $Description
        }
        if ($UserNote) {
            $mutation.Var.Input.UserNote = $UserNote
        }
        if ($ObjectTypes) {
            $mutation.Var.Input.ObjectTypes = $ObjectTypes
        }

        $mutation.Var.Input.SnapshotSchedule =
            New-Object -TypeName RubrikSecurityCloud.Types.GlobalSnapshotScheduleInput
        if ($MinuteSchedule) {
            $mutation.Var.Input.SnapshotSchedule.Minute = $MinuteSchedule
        }
        if ($HourlySchedule) {
            $mutation.Var.Input.SnapshotSchedule.Hourly = $HourlySchedule
        }
        if ($DailySchedule) {
            $mutation.Var.Input.SnapshotSchedule.Daily = $DailySchedule
        }
        if ($WeeklySchedule) {
            $mutation.Var.Input.SnapshotSchedule.Weekly = $WeeklySchedule
        }
        if ($MonthlySchedule) {
            $mutation.Var.Input.SnapshotSchedule.Monthly = $MonthlySchedule
        }
        if ($QuarterlySchedule) {
            $mutation.Var.Input.SnapshotSchedule.Quarterly = $QuarterlySchedule
        }
        if ($YearlySchedule) {
            $mutation.Var.Input.SnapshotSchedule.Yearly = $YearlySchedule
        }

        if ($LocalRetentionLimit) {
            $mutation.Var.Input.LocalRetentionLimit = $LocalRetentionLimit
        }
        if ($BackupWindows) {
            $mutation.Var.Input.BackupWindows = $BackupWindows
        }
        if ($FirstFullBackupWindows) {
            $mutation.Var.Input.FirstFullBackupWindows = $FirstFullBackupWindows
        }

        if ($ShouldApplyToExistingSnapshots) {
            $obj = New-Object -TypeName RubrikSecurityCloud.Types.ShouldApplyToExistingSnapshots
            $obj.Value = $true
            $mutation.Var.Input.ShouldApplyToExistingSnapshots = $obj
        }
        if ($ShouldApplyToNonPolicySnapshots) {
            $obj = New-Object -TypeName RubrikSecurityCloud.Types.ShouldApplyToNonPolicySnapshots
            $obj.Value = $true
            $mutation.Var.Input.ShouldApplyToNonPolicySnapshots = $obj
        }
        if ($RetentionLockSla) {
            $mutation.Var.Input.IsRetentionLockedSla = $true
        }
        if ($RetentionLockMode) {
            $mutation.Var.Input.RetentionLockMode = $RetentionLockMode
        }

        if ($ArchivalSpecs) {
            $mutation.Var.Input.ArchivalSpecs = $ArchivalSpecs
        }
        if ($ReplicationSpecs) {
            $mutation.Var.Input.ReplicationSpecsV2 = $ReplicationSpecs
        }

        # Update workload specific settings here.
        $objectSpecificConfig = New-Object -TypeName RubrikSecurityCloud.Types.ObjectSpecificConfigsInput
        if ($VmwareVmConfig) {
            $objectSpecificConfig.VmwareVmConfigInput = $VmwareVmConfig
        }
        if ($OracleConfig) {
            $objectSpecificConfig.OracleConfigInput = $OracleConfig
        }
        if ($SapHanaConfig) {
            $objectSpecificConfig.SapHanaConfigInput = $SapHanaConfig
        }
        if ($AwsRdsConfig) {
            $objectSpecificConfig.AwsRdsConfigInput = $AwsRdsConfig
        }
        if ($AzureSqlDatabaseConfig) {
            $objectSpecificConfig.AzureSqlDatabaseDbConfigInput = $AzureSqlDatabaseConfig
        }
        if ($AzureSqlManagedInstanceConfig) {
            $objectSpecificConfig.AzureSqlManagedInstanceDbConfigInput = $AzureSqlManagedInstanceConfig
        }
        if ($Db2Config) {
            $objectSpecificConfig.Db2ConfigInput = $Db2Config
        }
        if ($MsSqlConfig) {
            $objectSpecificConfig.MsSqlConfigInput = $MsSqlConfig
        }
        if ($MongoConfig) {
            $objectSpecificConfig.MongoConfigInput = $MongoConfig
        }
        if ($AzureBlobConfig) {
            $objectSpecificConfig.AzureBlobConfigInput = $AzureBlobConfig
        }
        if ($AwsNativeS3Config) {
            $objectSpecificConfig.AwsNativeS3SlaConfigInput = $AwsNativeS3Config
        }
        if ($ManagedVolumeConfig) {
            $objectSpecificConfig.ManagedVolumeSlaConfigInput = $ManagedVolumeConfig
        }
        if ($PostgresDbClusterConfig) {
            $objectSpecificConfig.PostgresDbClusterSlaConfigInput = $PostgresDbClusterConfig
        }
        $mutation.Var.Input.ObjectSpecificConfigsInput = $objectSpecificConfig

        if ($AsQuery) {
            return $mutation
        }

        $result = Invoke-Rsc -Query $mutation
        $result
    }
}
