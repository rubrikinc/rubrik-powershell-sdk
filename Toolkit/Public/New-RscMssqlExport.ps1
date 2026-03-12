#Requires -Version 3
function New-RscMssqlExport{
<#
    .SYNOPSIS
    Exports a Microsoft SQL Server database to a different instance or with a different name.

    .DESCRIPTION
    Recovers a SQL Server database to any target instance with full control over the database name and file paths. This is the most flexible recovery operation for MSSQL: use it to copy a database across instances, rename it, or relocate data and log files. For in-place recovery to the original location, use New-RscMssqlRestore instead. Two modes are available: a simple mode where you supply a single data path and log path, and an advanced mode where you specify individual file paths for each database file.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    The MSSQL database object to export. Pipe from Get-RscMssqlDatabase.

    .PARAMETER RecoveryDateTime
    The point-in-time to recover to, in UTC. Use Get-RscMssqlDatabaseRecoveryPoint to obtain a properly formatted value.

    .PARAMETER TargetMssqlInstance
    The destination SQL Server instance. Pipe from Get-RscMssqlInstance.

    .PARAMETER TargetDatabaseName
    The name for the exported database on the target instance.

    .PARAMETER TargetDataPath
    A single directory path where all data files will be placed (simple mode).

    .PARAMETER TargeLogPath
    A single directory path where all log files will be placed (simple mode).

    .PARAMETER TargetFilePaths
    An array of objects specifying per-file exportPath, logicalName, and newFilename (advanced mode). Build manually or use Get-RscMssqlDatabaseFiles. The logicalName must match the original database; exportPath and newFilename can be customized.

    .PARAMETER Overwrite
    Allow overwriting an existing database with the same name on the target instance.

    .PARAMETER FinishRecovery
    Bring the database fully online after export. When omitted the database is left in NORECOVERY mode.

    .PARAMETER MaxDataStreams
    Number of parallel data streams for the export (1-8, default 2). Test in a non-production environment before increasing.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Export a database to another instance using simple file paths.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    $inst = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.com -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"
    New-RscMssqlExport -RscMssqlDatabase $db `
        -RecoveryDateTime "2024-03-05T19:17:30.000Z" `
        -TargetMssqlInstance $inst `
        -TargetDatabaseName "AW2019_Copy" `
        -TargetDataPath "c:\mnt\sqldata" `
        -TargeLogPath "c:\mnt\sqllogs" `
        -Overwrite -FinishRecovery

    .EXAMPLE
    Export a database using per-file path control (advanced mode).

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    $inst = Get-RscMssqlInstance -HostName rp-sql1.rubrik-demo.com -clusterId "124d26df-c31f-49a3-a8c3-77b10c9470c2"
    $filePaths = @(
        @{ exportPath = "c:\mnt\sqldata"; logicalName = "AdventureWorks2019"; newFilename = "AW_Copy.mdf" },
        @{ exportPath = "c:\mnt\sqllogs"; logicalName = "AdventureWorks2019_log"; newFilename = "AW_Copy_log.ldf" }
    )
    New-RscMssqlExport -RscMssqlDatabase $db `
        -RecoveryDateTime "2024-03-05T19:17:30.000Z" `
        -TargetMssqlInstance $inst `
        -TargetDatabaseName "AW2019_Copy" `
        -TargetFilePaths $filePaths `
        -Overwrite -FinishRecovery
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
        )][int]$MaxDataStreams = 2,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        Write-Debug "- Running New-RscMssqlExport"
        
        #region Create Query         
        $query = New-RscMutation -Gql exportMssqlDatabase
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

        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
