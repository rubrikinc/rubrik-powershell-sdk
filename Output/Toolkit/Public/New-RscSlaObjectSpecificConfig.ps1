#Requires -Version 3
function New-RscSlaObjectSpecificConfig
{
    <#
    .SYNOPSIS
    Creates a new Rubrik SLA Object Config Input

    .DESCRIPTION
    Some workloads allow additional configurations for the Global SLA domain.
    This Cmdlet can be used to specify additional workload specific configuration
    to use with New-RscSla and Set-RscSla Cmdlets.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER VmwareVm
    Use this switch to create a VMware VM specific SLA configuration.

    .PARAMETER Oracle
    Use this switch to create an Oracle specific SLA configuration.

    .PARAMETER SapHana
    Use this switch to create a SAP Hana specific SLA configuration.

    .PARAMETER AwsRds
    Use this switch to create an AWS RDS specific SLA configuration.

    .PARAMETER AzureSqlDatabaseDb
    Use this switch to create an Azure SQL Database specific SLA configuration.

    .PARAMETER AzureSqlManagedInstanceDb
    Use this switch to create an Azure SQL Managed Instance specific SLA configuration.

    .PARAMETER Db2
    Use this switch to create a Db2 specific SLA configuration.

    .PARAMETER MsSql
    Use this switch to create a MS SQL specific SLA configuration.

    .PARAMETER Mongo
    Use this switch to create a Mongo specific SLA configuration.

    .PARAMETER AzureBlob
    Use this switch to create an Azure Blob specific SLA configuration.

    .PARAMETER AwsNativeS3
    Use this switch to create an AWS Native S3 specific SLA configuration.

    .PARAMETER ManagedVolume
    Use this switch to create a Managed Volume specific SLA configuration.

    .PARAMETER PostgresDbCluster
    Use this switch to create a Postgres DB Cluster specific SLA configuration.

    .PARAMETER Frequency
    Backup frequency

    .PARAMETER LogRetention
    Log retention of the configuration

    .PARAMETER HostLogRetention
    Host log retention of the configuration

    .PARAMETER IncrementalFrequency
    Frequency value for incremental backup

    .PARAMETER DifferentialFrequency
    Frequency value for differential backup

    .PARAMETER Retention
    How long storage snapshots are retained

    .PARAMETER LogRetentionInSeconds
    Vmware VM log retention in seconds

    .PARAMETER LogRetentionInDays
    Number of days Azure Sql database logs will be retained. Must be between 1 and 35

    .PARAMETER RetentionInDays
    Azure blob retention in days

    .PARAMETER BackupLocationId
    Location Id where primary backups of Aure blob objects will be stored

    .EXAMPLE
    Use New-RscSlaDuration to create a new SLA Duration Input for use with
    various parameters of New-RscSlaObjectSpecificConfig Cmdlet.

    Specify the object type using the corresponding switch parameter.

    $duration = New-RscSlaDuration -Duration 7 -Unit DAYS
    New-RscSlaObjectSpecificConfig -Oracle -Frequency $duration -LogRetention $duration -HostLogRetention $duration

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -VmwareVm -LogRetentionInSeconds 86400

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -AzureSqlDatabaseDb -LogRetentionInDays 7

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -AzureSqlManagedInstanceDb -LogRetentionInDays 7

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -AzureBlob -BackupRetentionInDays 7 -BackupLocationId "1234-5678-90ab-cdef"

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -AwsNativeS3 -BackupRetentionInDays 7 -BackupLocationId "1234-5678-90ab-cdef"

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -ManagedVolume -LogRetention $duration

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -PostgresDbCluster -LogRetention $duration

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -SapHana -IncrementalFrequency $duration
    -DifferentialFrequency $duration -Retention $duration -Frequency $duration
    -LogRetention $duration

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -Db2 -LogRetention $duration
    -IncrementalFrequency $duration -DifferentialFrequency $duration

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -MsSql -Frequency $duration -LogRetention $duration

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -Mongo -Frequency $duration -LogRetention $duration

    .EXAMPLE
    New-RscSlaObjectSpecificConfig -AwsRds -LogRetention $duration
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
