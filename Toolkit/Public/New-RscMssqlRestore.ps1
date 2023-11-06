#Requires -Version 3
function New-RscMssqlRestore {
    <#
    .SYNOPSIS
    Starts an in-place recovery of a MSSQL Database 

    .DESCRIPTION
    Starts an in-place recovery of a MSSQL Database

    Be aware. Do not use this if you are attempting to copy a database. In that case you should use Export. This will take the point in time provided and recover your database
    back to the original host, original instance, and the original database name to the point in time provided.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase
    
    .PARAMETER FinishRecovery
    Allows the database to be fully recovered and operational. If you omit this parameter, then when the database finishes being restored, the database will be left in
    NORECOVERY mode. 

    .PARAMETER maxDataStreams
    This controls the number of streams used for the restore. By default, Rubrik will use 2 streams. This cannot exceed a value of 8. 

    In general, the default value of 2 performs best. However in some cases, increasing the value can provide better performance of the restore. Do not change this value in a
    production setting without running some tests in a non-production environment. 

    .PARAMETER Latest
    Uses the latest recovery point date and time that Rubrik has for a database

    .PARAMETER LastFull
    Uses the last snapshot date and time that Rubrik has for a database

    .PARAMETER RestoreTime
    Restore time can in 1 of 3 formats
        - Relative to the last 24 hours: 02:00 will recover a database to 2AM on today's date. 
        - Local time: 2023-11-02 08:00:000
        - UTC: 2023-11-02 08:00:000Z
    All values will be converted into UTC and used as the recovery point.

    # .PARAMETER RecoveryLSN

    .PARAMETER AsQuery
    Instead of running the command, the query and variables used for the query will be returned. 

    .EXAMPLE
    Performs an in-place recovery of AdventureWorks2019 to the latest recovery point
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlRestore -RscMssqlDatabase $RscMssqlDatabase -Latest

    .EXAMPLE
    Performs an in-place recovery of AdventureWorks2019 to the last snapshot
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlRestore -RscMssqlDatabase $RscMssqlDatabase -LastFull

    .EXAMPLE
    Performs an in-place recovery of AdventureWorks2019 to a specific point in time. 
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlRestore -RscMssqlDatabase $RscMssqlDatabase -RestoreTime "2023-10-27 08:37:00.000Z"
    #>

    [CmdletBinding(
    )]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [switch]$FinishRecovery,

        [ValidateRange(1, 8)]
        [Parameter(
            Mandatory = $false
        )][int]$MaxDataStreams = 2,

        [Parameter(
            ParameterSetName = 'Recovery_Latest',
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Latest,

        [Parameter(
            ParameterSetName = 'Recovery_LastFull',
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$LastFull,

        [Parameter(
            ParameterSetName = 'Recovery_DateTime',
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][datetime]$RestoreTime,

        # [Parameter(
        #     ParameterSetName = 'Recovery_LSN',
        #     Mandatory = $false, 
        #     ValueFromPipeline = $false
        # )]
        # [string]$RecoveryLSN,

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Create Query
        $query = New-RscMutationMssql -Operation RestoreDatabase
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.RestoreMssqlDatabaseInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"

        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.RestoreMssqlDbJobConfigInput
        $query.Var.input.config.finishRecovery = $FinishRecovery
        If (![string]::IsNullOrEmpty($maxDataStreams)){$query.Var.input.config.maxDataStreams = $maxDataStreams}
        
        if($PSBoundParameters.ContainsKey('Latest')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -Latest
            $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
            $query.Var.input.config.recoveryPoint.date = $RecoveryPoint
        }

        if($PSBoundParameters.ContainsKey('LastFull')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -LastFull
            $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
            $query.Var.input.config.recoveryPoint.date = $RecoveryPoint
        }

        if($PSBoundParameters.ContainsKey('RestoreTime')) {
            $RecoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -RestoreTime $RestoreTime
            $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
            $query.Var.input.config.recoveryPoint.date = $RecoveryPoint
        }
        # if($PSBoundParameters.ContainsKey('RecoveryLSN')) {
        #     $query.Var.input.config.recoveryPoint.lsnPoint = New-Object RubrikSecurityCloud.Types.LsnRecoveryPointInput
        #     $query.Var.input.config.recoveryPoint.lsnPoint.lsn = $RecoveryLSN
        #     # $query.Var.input.config.recoveryPoint.lsnPoint.recoveryForkGuid
        # }
        #endregion
        
        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }
        $result
    } 
}
