#Requires -Version 3
function New-RscSla
{
  <#
    .SYNOPSIS
    Creates a new SLA Domain in Rubrik Security Cloud.

    .DESCRIPTION
    Use this cmdlet to create an SLA Domain policy that defines snapshot frequency, retention, archival, and replication rules. You can attach snapshot schedules at hourly through yearly intervals, scope the policy to specific object types, and optionally configure workload-specific settings for VMware, Oracle, MSSQL, SAP HANA, and other supported platforms.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Name
    The name of the new SLA Domain.

    .PARAMETER HourlySchedule
    An hourly snapshot schedule object. Create with New-RscSlaSnapshotSchedule -Type Hourly.

    .PARAMETER DailySchedule
    A daily snapshot schedule object. Create with New-RscSlaSnapshotSchedule -Type Daily.

    .PARAMETER WeeklySchedule
    A weekly snapshot schedule object. Create with New-RscSlaSnapshotSchedule -Type Weekly.

    .PARAMETER MonthlySchedule
    A monthly snapshot schedule object. Create with New-RscSlaSnapshotSchedule -Type Monthly.

    .PARAMETER QuarterlySchedule
    A quarterly snapshot schedule object. Create with New-RscSlaSnapshotSchedule -Type Quarterly.

    .PARAMETER YearlySchedule
    A yearly snapshot schedule object. Create with New-RscSlaSnapshotSchedule -Type Yearly.

    .PARAMETER ObjectType
    One or more workload object types this SLA Domain applies to (e.g., VSPHERE_OBJECT_TYPE).

    .PARAMETER LocalRetentionLimit
    Retention limit for local snapshots on the Rubrik cluster.

    .PARAMETER BackupWindows
    One or more backup window objects restricting when snapshots may run.

    .PARAMETER FirstFullBackupWindows
    One or more backup window objects restricting when the first full backup may run.

    .PARAMETER RetentionLockSla
    Enable retention lock on this SLA Domain.

    .PARAMETER RetentionLockMode
    The retention lock mode for the SLA Domain.

    .PARAMETER ArchivalSpecs
    Archival specifications for this SLA Domain.

    .PARAMETER ReplicationSpecs
    Replication specifications for this SLA Domain.

    .PARAMETER VmwareVmConfig
    VMware VM-specific settings for this SLA Domain.

    .PARAMETER OracleConfig
    Oracle-specific settings for this SLA Domain.

    .PARAMETER SapHanaConfig
    SAP HANA-specific settings for this SLA Domain.

    .PARAMETER AwsRdsConfig
    AWS RDS-specific settings for this SLA Domain.

    .PARAMETER AzureSqlDatabaseConfig
    Azure SQL Database-specific settings for this SLA Domain.

    .PARAMETER AzureSqlManagedInstanceConfig
    Azure SQL Managed Instance-specific settings for this SLA Domain.

    .PARAMETER Db2Config
    Db2-specific settings for this SLA Domain.

    .PARAMETER MsSqlConfig
    MSSQL-specific settings for this SLA Domain.

    .PARAMETER MongoConfig
    MongoDB-specific settings for this SLA Domain.

    .PARAMETER AzureBlobConfig
    Azure Blob-specific settings for this SLA Domain.

    .PARAMETER AwsNativeS3Config
    AWS S3-specific settings for this SLA Domain.

    .PARAMETER ManagedVolumeConfig
    Managed Volume-specific settings for this SLA Domain.

    .PARAMETER PostgresDbClusterConfig
    PostgreSQL DB Cluster-specific settings for this SLA Domain.

    .EXAMPLE
    Create an hourly schedule and use it to create a new SLA Domain for vSphere objects.

    $hourlySchedule = New-RscSlaSnapshotSchedule -Type Hourly -Frequency 1 -Retention 7 -RetentionUnit DAYS
    New-RscSla -Name "Platinum" -HourlySchedule $hourlySchedule -ObjectType VSPHERE_OBJECT_TYPE

    .EXAMPLE
    Create an SLA Domain with daily and monthly schedules plus archival.

    $daily = New-RscSlaSnapshotSchedule -Type Daily -Frequency 1 -Retention 30 -RetentionUnit DAYS
    $monthly = New-RscSlaSnapshotSchedule -Type Monthly -Frequency 1 -Retention 12 -RetentionUnit MONTHS
    $archival = New-RscSlaArchivalSpecs -ArchivalThreshold 30 -Frequencies @('MONTHS') -ArchivalThresholdUnit DAYS -ClusterUuids @('cluster-uuid') -LocationIds @('location-id')
    New-RscSla -Name "Gold" -DailySchedule $daily -MonthlySchedule $monthly -ArchivalSpecs @($archival) -ObjectType VSPHERE_OBJECT_TYPE
  #>

  [CmdletBinding()]
  Param(
    # SLA Domain Name
    [Parameter(Mandatory)]
    [ValidateNotNullOrEmpty()]
    [String]$Name,

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

    # Object Types
    [Parameter()]
    [RubrikSecurityCloud.Types.SlaObjectType[]]$ObjectType,

    # Local Retention Limit
    [Parameter()]
    [RubrikSecurityCloud.Types.SlaDurationInput]$LocalRetentionLimit,
    
    # Backup Windows
    [Parameter()]
    [RubrikSecurityCloud.Types.BackupWindowInput[]]$BackupWindows,
    
    # First full Backup Windows
    [Parameter()]
    [RubrikSecurityCloud.Types.BackupWindowInput[]]$FirstFullBackupWindows,

    # Retention Lock SLA
    [Parameter()]
    [Switch]$RetentionLockSla,

    # The retention lock mode for the intended SLA Domain update.
    [Parameter()]
    [RubrikSecurityCloud.Types.RetentionLockMode]$RetentionLockMode,

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

    [Parameter(
        Mandatory = $false,
        ValueFromPipeline = $false,
        HelpMessage = "Return the query object instead of running the query"
    )][Switch]$AsQuery
  )
    Process {

        $query = New-RscMutation -Gql createGlobalSla
        $query.Var.Input = New-Object -TypeName RubrikSecurityCloud.Types.CreateGlobalSlaInput
        $query.Var.Input.name = $Name
        $query.Var.Input.SnapshotSchedule = New-Object -TypeName RubrikSecurityCloud.Types.GlobalSnapshotScheduleInput
        $query.Var.Input.ObjectTypes = @($ObjectType)

        if ($HourlySchedule) {
            $query.var.input.SnapshotSchedule.Hourly = $HourlySchedule
        }
        if ($DailySchedule) {
            $query.var.input.SnapshotSchedule.Daily = $DailySchedule
        }
        if ($WeeklySchedule) {
            $query.var.input.SnapshotSchedule.Weekly = $WeeklySchedule
        }
        if ($MonthlySchedule) {
            $query.var.input.SnapshotSchedule.Monthly = $MonthlySchedule
        }
        if ($QuarterlySchedule) {
            $query.var.input.SnapshotSchedule.Quarterly = $QuarterlySchedule
        }
        if ($YearlySchedule) {
            $query.var.input.SnapshotSchedule.Yearly = $YearlySchedule
        }
        if ($LocalRetentionLimit) {
            $query.Var.Input.LocalRetentionLimit = $LocalRetentionLimit
        }
        if ($BackupWindows) {
            $query.Var.Input.BackupWindows = $BackupWindows
        }
        if ($FirstFullBackupWindows) {
            $query.Var.Input.FirstFullBackupWindows = $FirstFullBackupWindows
        }
        if ($RetentionLockSla) {
            $query.Var.Input.IsRetentionLockedSla = $true
        }
        if ($RetentionLockMode) {
            $query.Var.Input.RetentionLockMode = $RetentionLockMode
        }
        if ($ArchivalSpecs) {
            $query.Var.Input.ArchivalSpecs = $ArchivalSpecs
        }
        if ($ReplicationSpecs) {
            $query.Var.Input.ReplicationSpecsV2 = $ReplicationSpecs
        }

        # object specific config
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
        $query.Var.Input.ObjectSpecificConfigsInput = $objectSpecificConfig

        if ( $AsQuery ) { return $query }
        $result = Invoke-Rsc -Query $query
        $result
    }
} 
