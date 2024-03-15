#Requires -Version 3
function New-RscMssqlExport{
<#
    .SYNOPSIS
    Exports a MSSQL Database

    .DESCRIPTION
    Exports a MSSQL Database. Export is a recovery operation. This lines up with our other recovery options like
    restore and live mount. Export will be the most often used recovery operation as it allows for copying a database
    from one place to another. To a DBA, Export is a database restore, but it allows for more options than in-place 
    recovery allows. 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER RecoveryDateTime
    While this is a date field, it is best if you use Get-RscMssqlDatabaseRecoveryPoint to ensure that the date and time is formatted properly. Also, using Get-RscMssqlDatabaseRecoveryPoint
    will allow for a simplier use case as you can use -Latest, -LastFull, relative point in time or exact point in time. In all cases, the output will be a properly formatted date and time in UTC. 
    Keep in mind, if you send a value that is NOT in UTC timezone, you could be doing a recovery to point in time different than when you desired. 

    .PARAMETER TargetMssqlInstance
    SQL Server Instance Object returned from Get-RscMssqlInstance

    .PARAMETER TargetDatabaseName
    Any name you want to call your database when it is recovered onto the target instance

    .PARAMETER TargetDataPath
    Single path that all data files will be placed into 

    .PARAMETER TargeLogPath
    Single path that all log files will be placed into

    .PARAMETER TargetFilePaths
    Object can be built manually like the below example, or by using Get-RscMssqlDatabaseFiles. 

    $TargetFilePaths = @()
    $TargetDataPath = @{
        exportPath = "c:\mnt\sqldata"
        logicalName = "AdventureWorks2017"
        newFilename = "Lumnah_Test.mdf"
    }
    $TargetFilePaths += $TargetDataPath
    $TargetLogPath = @{
        exportPath = "c:\mnt\sqldata"
        logicalName = "AdventureWorks2017_log"
        newFilename = "Lumnah_Test_log.ldf"
    } 

    logicalName value cannot be changed, but exportPath and newFilename values can. 

    Case matters. Make sure to use the case listed above for exportPath, logicalName, and newFilename. Variations of the spellings in different cases, will not work. 
    .PARAMETER Overwrite
    Enables the database being exported to be over written. 

    .PARAMETER FinishRecovery
    Allows the database to be fully recovered and operational. If you omit this parameter, then when the database finishes being restored, the database will be left in
    NORECOVERY mode. 

    .PARAMETER MaxDataStreams
    This controls the number of streams used for the restore. By default, Rubrik will use 2 streams. This cannot exceed a value of 8. 

    In general, the default value of 2 performs best. However in some cases, increasing the value can provide better performance of the restore. Do not change this value in a
    production setting without running some tests in a non-production environment. 

    .EXAMPLE
    Exports a database using the latest recovery point using the "Simple Method"
    This means you provide a single data and log path for all data and log files to go into. This does not allow for the 
    file names to be changed. 

    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    $RscTargetMssqlInstance = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.cm -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"
    New-RscMssqlExport -RscMssqlDatabase $RscMssqlDatabase `
        -RecoveryDateTime "2024-03-05T19:17:30.000Z" `
        -TargetMssqlInstance $RscMssqlInstance `
        -TargetDataPath = "c:\mnt\sqldata" `
        -TargeLogPath = "c:\mnt\sqllogs" `
        -Overwrite `
        -FinishRecovery

    .EXAMPLE
    Exports a database using the latest recovery point using the "Advanced Method"
    In this case, you need to build an object like the below that contains the exportPath, logicalName, newFilename of 
    each file in the database. 

    This gives you full control over each file and path. 
    The value in logicalName *MUST* be the same value that is in the database at the time of the backup. You can see these
    values by using Get-RscMssqlDatabaseFiles. 
    
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    $RscTargetMssqlInstance = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.cm -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"

    $TargetFilePaths = @()
    $TargetDataPath = @{
        exportPath = "c:\mnt\sqldata"
        logicalName = "AdventureWorks2017"
        newFilename = "Lumnah_Test.mdf"
    }
    $TargetFilePaths += $TargetDataPath
    $TargetLogPath = @{
        exportPath = "c:\mnt\sqldata"
        logicalName = "AdventureWorks2017_log"
        newFilename = "Lumnah_Test_log.ldf"
    } 
    $TargetFilePaths += $TargetLogPath
    New-RscMssqlExport -RscMssqlDatabase $RscMssqlDatabase `
        -RecoveryDateTime "2024-03-05T19:17:30.000Z" `
        -TargetMssqlInstance $RscMssqlInstance `
        -TargetFilePaths $TargetFilePaths `
        -Overwrite `
        -FinishRecovery
    #>

    [CmdletBinding()]
    Param(
        [Parameter(            
            Mandatory = $true, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $true
        )][datetime]$RecoveryDateTime,

        #Recovery Point desired in the form of an LSN (Log Sequence Number) TODO:SPARK-224340
        #[Parameter(ParameterSetName='Recovery_LSN')]
        #[string]$RecoveryLSN,

        [Parameter(
            Mandatory = $true
        )][RubrikSecurityCloud.Types.MssqlInstance]$TargetMssqlInstance, 

        [Parameter(
            Mandatory = $true
        )][String]$TargetDatabaseName,

        [Parameter(
            ParameterSetName = "Simple Method",
            Mandatory = $false
        )][String]$TargetDataPath,

        [Parameter(
            ParameterSetName = "Simple Method",
            Mandatory = $false
        )][String]$TargeLogPath,

        [Parameter(
            ParameterSetName = "Advanced Method",
            Mandatory = $false
        )][PSCustomObject]$TargetFilePaths,

        [Parameter(
            Mandatory = $false
        )][Switch]$Overwrite,

        [Parameter(
            Mandatory = $false
        )][Switch]$FinishRecovery,

        [ValidateRange(1, 8)]
        [Parameter(
            Mandatory = $false
        )][int]$MaxDataStreams = 2
    )
    
    Process {
        Write-Debug "- Running New-RscMssqlExport"
        
        #region Create Query         
        $query = New-RscMutationMssql -Op ExportDatabase
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.ExportMssqlDatabaseInput
        $query.Var.input.Id = $RscMssqlDatabase.Id
    
        $query.Var.input.Config = New-Object -TypeName RubrikSecurityCloud.Types.ExportMssqlDbJobConfigInput
        If (![string]::IsNullOrEmpty($Overwrite)){$query.Var.input.config.allowOverwrite = $Overwrite}
        If (![string]::IsNullOrEmpty($FinishRecovery)){$query.Var.input.config.FinishRecovery = $FinishRecovery}
        If (![string]::IsNullOrEmpty($maxDataStreams)){$query.Var.input.config.maxDataStreams = $maxDataStreams}
        
        $query.Var.input.Config.recoveryPoint = New-Object -TypeName RubrikSecurityCloud.Types.MssqlRecoveryPointInput
        $query.Var.input.config.recoveryPoint.date = $RecoveryDateTime

        $query.Var.input.Config.targetDatabaseName = $TargetDatabaseName

        # $query.Var.input.Config.recoveryPoint.lsnPoint = New-Object -TypeName RubrikSecurityCloud.Types.LsnRecoveryPointInput 

        # Simple Method
        If (![string]::IsNullOrEmpty($TargetDataPath) -and ![string]::IsNullOrEmpty($TargeLogPath)){
                $query.Var.input.Config.targetDataFilePath = $TargetDataPath
                $query.Var.input.Config.targetLogFilePath = $TargeLogPath
        }

        # Advanced Method
        If (![string]::IsNullOrEmpty($TargetFilePaths)){
            $query.Var.input.Config.targetFilePaths = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDbFileExportPathInput 
            $query.Var.input.Config.targetFilePaths = $TargetFilePaths
        }
    
        $query.Var.input.Config.targetInstanceId = $TargetMssqlInstance.Id
        #endregion

        $result = $query.Invoke()
        $result
    } 
}
