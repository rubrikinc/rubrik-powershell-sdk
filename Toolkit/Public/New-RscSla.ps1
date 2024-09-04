#Requires -Version 3
function New-RscSla
{
  <#
    .SYNOPSIS
    Creates a new Rubrik SLA Domain

    .DESCRIPTION
    The New-RscSla cmdlet will create a new SLA Domain. Rubrik SLA Domains are policies that define the frequency, retention, and rules for acrhival and replication.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Create a Snapshot schedule to take a snapshot every 1 hour and retain that snapshot for 7 days. Then create the SLA Domain with that schedule.
    
    $hourlySchedule = New-RscSlaSnapshotSchedule -Type Hourly -Frequency 1 -Retention 7 -RetentionUnit DAYS
    New-RscSla -Name "Platinum" -HourlySchedule $hourlySchedule -ObjectType VSPHERE_OBJECT_TYPE
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
    [RubrikSecurityCloud.Types.PostgresDbClusterSlaConfigInput]$PostgresDbClusterConfig
  )
    Process {

        $query = New-RscMutation -GqlMutation createGlobalSla
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
        $mutation.Var.Input.ObjectSpecificConfigsInput = $objectSpecificConfig

        $result = Invoke-Rsc -Query $query
        $result
    }
} 
