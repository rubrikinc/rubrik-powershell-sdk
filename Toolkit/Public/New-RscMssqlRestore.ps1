#Requires -Version 3
function New-RscMssqlRestore {
    <#
    .SYNOPSIS
    Performs an in-place restore of a Microsoft SQL Server database.

    .DESCRIPTION
    Restores a SQL Server database back to its original host, instance, and database name at the specified point in time. This is an in-place recovery operation; if you need to copy a database to a different location or name, use New-RscMssqlExport instead. Omitting -FinishRecovery leaves the database in NORECOVERY mode, which is useful when you plan to apply additional log backups.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    The MSSQL database object to restore. Pipe from Get-RscMssqlDatabase.

    .PARAMETER FinishRecovery
    Bring the database fully online after restore. When omitted the database is left in NORECOVERY mode.

    .PARAMETER MaxDataStreams
    Number of parallel data streams for the restore (1-8, default 2). Test in a non-production environment before increasing.

    .PARAMETER RecoveryDateTime
    The point-in-time to recover to, in UTC. Use Get-RscMssqlDatabaseRecoveryPoint to obtain a properly formatted value.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Restore AdventureWorks2019 to a specific point in time.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlRestore -RscMssqlDatabase $db -RecoveryDateTime "2023-10-27 08:37:00.000Z" -FinishRecovery

    .EXAMPLE
    Restore a database and leave it in NORECOVERY mode for further log restores.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlRestore -RscMssqlDatabase $db -RecoveryDateTime "2023-10-27 08:37:00.000Z"
    #>

    [CmdletBinding(
    )]
    Param(
        [Parameter(
            Mandatory = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $false
        )]
        [switch]$FinishRecovery,

        [ValidateRange(1, 8)]
        [Parameter(
            Mandatory = $false
        )][int]$MaxDataStreams = 2,

        [Parameter(
            Mandatory = $true
        )][datetime]$RecoveryDateTime,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery

        # [Parameter(
        #     ParameterSetName = 'Recovery_LSN',
        #     Mandatory = $false, 
        #     ValueFromPipeline = $false
        # )]
        # [string]$RecoveryLSN,
    )
    
    Process {
        Write-Debug "- Running New-RscMssqlRestore"
        #region Create Query
        $query = New-RscMutation -Gql restoreMssqlDatabase
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.RestoreMssqlDatabaseInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"

        $query.Var.input.config = New-Object RubrikSecurityCloud.Types.RestoreMssqlDbJobConfigInput
        $query.Var.input.config.finishRecovery = $FinishRecovery
        If (![string]::IsNullOrEmpty($maxDataStreams)){$query.Var.input.config.maxDataStreams = $maxDataStreams}

        $query.Var.input.config.recoveryPoint = New-Object RubrikSecurityCloud.Types.MssqlRecoveryPointInput
        $query.Var.input.config.recoveryPoint.date = $RecoveryDateTime
        #endregion
        
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
