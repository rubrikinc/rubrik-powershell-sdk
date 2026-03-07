#Requires -Version 3
function New-RscSlaObjectSpecificConfig
{
    <#
    .SYNOPSIS
    Creates a workload-specific configuration input object for use with New-RscSla or Set-RscSla.

    .DESCRIPTION
    Some workloads support extra SLA settings beyond the base snapshot
    schedule, such as log retention or incremental backup frequency. Use
    one of the workload switch parameters to select the target type, then
    supply the relevant settings. The output is passed to New-RscSla or
    Set-RscSla via the -ObjectSpecificConfigs parameter. Duration values
    are created with New-RscSlaDuration.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER VmwareVm
    Select VMware VM as the workload type.

    .PARAMETER Oracle
    Select Oracle as the workload type.

    .PARAMETER SapHana
    Select SAP HANA as the workload type.

    .PARAMETER AwsRds
    Select AWS RDS as the workload type.

    .PARAMETER AzureSqlDatabaseDb
    Select Azure SQL Database as the workload type.

    .PARAMETER AzureSqlManagedInstanceDb
    Select Azure SQL Managed Instance as the workload type.

    .PARAMETER Db2
    Select Db2 as the workload type.

    .PARAMETER MsSql
    Select Microsoft SQL Server as the workload type.

    .PARAMETER Mongo
    Select MongoDB as the workload type.

    .PARAMETER AzureBlob
    Select Azure Blob Storage as the workload type.

    .PARAMETER AwsNativeS3
    Select AWS S3 as the workload type.

    .PARAMETER ManagedVolume
    Select Managed Volume as the workload type.

    .PARAMETER PostgresDbCluster
    Select Postgres DB Cluster as the workload type.

    .PARAMETER Frequency
    Backup frequency for workloads that support it. Create with New-RscSlaDuration.

    .PARAMETER LogRetention
    How long transaction logs are retained. Create with New-RscSlaDuration.

    .PARAMETER HostLogRetention
    How long host-level logs are retained (Oracle only). Create with New-RscSlaDuration.

    .PARAMETER IncrementalFrequency
    How often incremental backups run (SAP HANA, Db2). Create with New-RscSlaDuration.

    .PARAMETER DifferentialFrequency
    How often differential backups run (SAP HANA, Db2). Create with New-RscSlaDuration.

    .PARAMETER Retention
    How long storage snapshots are retained (SAP HANA). Create with New-RscSlaDuration.

    .PARAMETER LogRetentionInSeconds
    VMware VM log retention expressed in seconds.

    .PARAMETER LogRetentionInDays
    Number of days to retain Azure SQL logs. Must be between 1 and 35.

    .PARAMETER BackupRetentionInDays
    Number of days to retain continuous backups (Azure Blob, AWS S3).

    .PARAMETER BackupLocationId
    Location ID where primary backups are stored (Azure Blob, AWS S3).

    .EXAMPLE
    Configure Oracle log and host-log retention, then create an SLA.

    $dur = New-RscSlaDuration -Duration 7 -Unit DAYS
    $oracleCfg = New-RscSlaObjectSpecificConfig -Oracle -Frequency $dur -LogRetention $dur -HostLogRetention $dur
    New-RscSla -Name "Oracle-Gold" -ObjectSpecificConfigs @($oracleCfg)

    .EXAMPLE
    Configure VMware VM log retention of 24 hours (in seconds).

    New-RscSlaObjectSpecificConfig -VmwareVm -LogRetentionInSeconds 86400
    #>

    [CmdletBinding()]
    Param(
        # The switch parameters are used to determine the workload type

        # The object type is VMware VM
        [Parameter(ParameterSetName="VmwareVm")]
        [Switch]$VmwareVm,

        # The object type is Oracle
        [Parameter(ParameterSetName="Oracle")]
        [Switch]$Oracle,

        # The object type is Sap Hana
        [Parameter(ParameterSetName="SapHana")]
        [Switch]$SapHana,

        # The object type is Aws Rds
        [Parameter(ParameterSetName="AwsRds")]
        [Switch]$AwsRds,

        # The object type is Azure Sql Database Db
        [Parameter(ParameterSetName="AzureSqlDatabaseDb")]
        [Switch]$AzureSqlDatabaseDb,

        # The object type is Azure Sql Database Db
        [Parameter(ParameterSetName="AzureSqlManagedInstanceDb")]
        [Switch]$AzureSqlManagedInstanceDb,

        # The object type is Db2
        [Parameter(ParameterSetName="Db2")]
        [Switch]$Db2,

        # The object type is MsSql
        [Parameter(ParameterSetName="MsSql")]
        [Switch]$MsSql,

        # The object type is Mongo
        [Parameter(ParameterSetName="Mongo")]
        [Switch]$Mongo,

        # The object type is Azure Blob
        [Parameter(ParameterSetName="AzureBlob")]
        [Switch]$AzureBlob,

        # The object type is Aws Native S3
        [Parameter(ParameterSetName="AwsNativeS3")]
        [Switch]$AwsNativeS3,

        # The object type is Managed Volume
        [Parameter(ParameterSetName="ManagedVolume")]
        [Switch]$ManagedVolume,

        # The object type is Postgres Db cluster
        [Parameter(ParameterSetName="PostgresDbCluster")]
        [Switch]$PostgresDbCluster,

        # Backup frequency
        [Parameter(ParameterSetName="Oracle")]
        [Parameter(ParameterSetName="SapHana")]
        [Parameter(ParameterSetName="MsSql")]
        [Parameter(ParameterSetName="Mongo")]
        [RubrikSecurityCloud.Types.SlaDurationInput]$Frequency,

        # Log retention of the configuration
        [Parameter(ParameterSetName="Oracle")]
        [Parameter(ParameterSetName="SapHana")]
        [Parameter(Mandatory, ParameterSetName="AwsRds")]
        [Parameter(Mandatory, ParameterSetName="ManagedVolume")]
        [Parameter(Mandatory, ParameterSetName="PostgresDbCluster")]
        [Parameter(ParameterSetName="Db2")]
        [Parameter(ParameterSetName="MsSql")]
        [Parameter(ParameterSetName="Mongo")]
        [RubrikSecurityCloud.Types.SlaDurationInput]$LogRetention,

        # Host log retention of the configuration
        [Parameter(ParameterSetName="Oracle")]
        [RubrikSecurityCloud.Types.SlaDurationInput]$HostLogRetention,

        # Frequency value for incremental backup
        [Parameter(ParameterSetName="SapHana")]
        [Parameter(ParameterSetName="Db2")]
        [RubrikSecurityCloud.Types.SlaDurationInput]$IncrementalFrequency,

        # Frequency value for differential backup
        [Parameter(ParameterSetName="SapHana")]
        [Parameter(ParameterSetName="Db2")]
        [RubrikSecurityCloud.Types.SlaDurationInput]$DifferentialFrequency,

        # How long storage snapshots are retained
        [Parameter(ParameterSetName="SapHana")]
        [RubrikSecurityCloud.Types.SlaDurationInput]$Retention,

        # Vmware VM log retention in seconds
        [Parameter(Mandatory, ParameterSetName="VmwareVm")]
        [Long]$LogRetentionInSeconds,

        # Number of days Azure Sql database logs will be retained
        [Parameter(Mandatory, ParameterSetName="AzureSqlDatabaseDb")]
        [Parameter(Mandatory, ParameterSetName="AzureSqlManagedInstanceDb")]
        [Int]$LogRetentionInDays,

        # Azure blob retention in days
        [Parameter(ParameterSetName="AzureBlob")]
        [Parameter(ParameterSetName="AwsNativeS3")]
        [Int]$BackupRetentionInDays,

        # Location Id where primary backups of Aure blob objects will be stored
        [Parameter(ParameterSetName="AzureBlob")]
        [Parameter(ParameterSetName="AwsNativeS3")]
        [String]$BackupLocationId
    )

    Process {
        if ($VmwareVm) {
            $vmwareVmConfig = New-Object -TypeName RubrikSecurityCloud.Types.VmwareVmConfigInput
            $vmwareVmConfig.LogRetentionSeconds = $LogRetentionInSeconds
            $vmwareVmConfig
        }
        elseif ($Oracle) {
            $oracleConfig = New-Object -TypeName RubrikSecurityCloud.Types.OracleConfigInput
            $oracleConfig.Frequency = $Frequency
            $oracleConfig.LogRetention = $LogRetention
            $oracleConfig.HostLogRetention = $HostLogRetention
            $oracleConfig
        }
        elseif ($SapHana)
        {
            $sapHanaConfig = New-Object -TypeName RubrikSecurityCloud.Types.SapHanaConfigInput
            $sapHanaConfig.IncrementalFrequency = $IncrementalFrequency
            $sapHanaConfig.DifferentialFrequency = $DifferentialFrequency
            $sapHanaConfig.LogRetention = $LogRetention
            $sapHanaConfig.StorageSnapshotConfig =
                New-Object -TypeName RubrikSecurityCloud.Types.SapHanaStorageSnapshotConfigInput
            $sapHanaConfig.StorageSnapshotConfig.Retention = $Retention
            $sapHanaConfig.StorageSnapshotConfig.Frequency = $Frequency
            $sapHanaConfig
        }
        elseif ($AwsRds)
        {
            $awsRdsConfig = New-Object -TypeName RubrikSecurityCloud.Types.AwsRdsConfigInput
            $awsRdsConfig.LogRetention = $LogRetention
            $awsRdsConfig
        }
        elseif ($AzureSqlDatabaseDb)
        {
            $azureSqlConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlDatabaseDbConfigInput
            $azureSqlConfig.LogRetentionInDays = $LogRetentionInDays
            $azureSqlConfig
        }
        elseif ($AzureSqlManagedInstanceDb)
        {
            $azureSqlConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureSqlManagedInstanceDbConfigInput
            $azureSqlConfig.LogRetentionInDays = $LogRetentionInDays
            $azureSqlConfig
        }
        elseif ($Db2)
        {
            $db2Config = New-Object -TypeName RubrikSecurityCloud.Types.Db2ConfigInput
            $db2Config.IncrementalFrequency = $IncrementalFrequency
            $db2Config.DifferentialFrequency = $DifferentialFrequency
            $db2Config.LogRetention = $LogRetention
            $db2Config
        }
        elseif ($MsSql)
        {
            $msSqlConfig = New-Object -TypeName RubrikSecurityCloud.Types.MsSqlConfigInput
            $msSqlConfig.Frequency = $Frequency
            $msSqlConfig.LogRetention = $LogRetention
            $msSqlConfig
        }
        elseif ($Mongo)
        {
            $mongoConfig = New-Object -TypeName RubrikSecurityCloud.Types.MongoConfigInput
            $mongoConfig.LogFrequency = $Frequency
            $mongoConfig.LogRetention = $LogRetention
            $mongoConfig
        }
        elseif ($AzureBlob)
        {
            $azureBlobConfig = New-Object -TypeName RubrikSecurityCloud.Types.AzureBlobConfigInput
            $azureBlobConfig.ContinuousBackupRetentionInDays = $BackupRetentionInDays
            $azureBlobConfig.BackupLocationId = $BackupLocationId
            $azureBlobConfig
        }
        elseif ($AwsNativeS3)
        {
            $awsNativeS3Config = New-Object -TypeName RubrikSecurityCloud.Types.AwsNativeS3SlaConfigInput
            $awsNativeS3Config.ContinuousBackupRetentionInDays = $BackupRetentionInDays
            $awsNativeS3Config.ArchivalLocationId = $BackupLocationId
            $awsNativeS3Config
        }
        elseif ($ManagedVolume)
        {
            $managedVolumeConfig = New-Object -TypeName RubrikSecurityCloud.Types.ManagedVolumeSlaConfigInput
            $managedVolumeConfig.LogRetention = $LogRetention
            $managedVolumeConfig
        }
        elseif ($PostgresDbCluster)
        {
            $postgresDbClusterConfig = New-Object -TypeName RubrikSecurityCloud.Types.PostgresDbClusterSlaConfigInput
            $postgresDbClusterConfig.LogRetention = $LogRetention
            $postgresDbClusterConfig
        }
    }
}
