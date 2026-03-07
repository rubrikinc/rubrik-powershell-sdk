#Requires -Version 3
function Get-RscMssqlDatabaseRecoveryPoint {
    <#
    .SYNOPSIS
    Returns a recovery point in time converted to UTC for a SQL Server database.

    .DESCRIPTION
    Determines the exact recovery point in UTC for a SQL Server database. Use -Latest
    for the most recent available recovery point, -LastFull for the last snapshot time,
    or -RestoreTime for a specific date/time. The returned value can be passed to
    other cmdlets like Get-RscMssqlDatabaseFiles or New-RscMssqlRestore.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    A SQL Server database object, typically obtained from Get-RscMssqlDatabase.

    .PARAMETER Latest
    Use the latest available recovery point.

    .PARAMETER LastFull
    Use the most recent snapshot as the recovery point.

    .PARAMETER RestoreTime
    A specific date/time to use as the recovery point. Accepts three formats:
    time only (e.g., "02:00" for 2 AM today), local time ("2024-01-15 08:00:00"),
    or UTC ("2024-01-15 08:00:00Z"). All values are converted to UTC.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get the latest recovery point
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $db -Latest

    .EXAMPLE
    # Get recovery point from the last full snapshot
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $db -LastFull

    .EXAMPLE
    # Get recovery point for a specific time
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $db -RestoreTime "2024-01-15 08:37:00.000Z"
    #>

    [CmdletBinding()]
    param(
        [Parameter(
            Position = 0,
            Mandatory = $true,
            ValueFromPipeline = $true)]
        [ValidateNotNullOrEmpty()] 
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,
        [Parameter(ParameterSetName = 'Latest')]
        [switch]$Latest,
        [Parameter(ParameterSetName = 'LastFull')]
        [switch]$LastFull,
        [Parameter(ParameterSetName = 'RestoreTime')]
        [datetime]$RestoreTime,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        Write-Debug "- Running Get-RscMssqlDatabase"

        #region Create Query
        if ($PSBoundParameters.ContainsKey('Latest')) {
            $query = New-RscQuery -Gql mssqlRecoverableRanges -AddField Data.BeginTime, Data.EndTime
            $query.Var.input.id = $RscMssqlDatabase.id
            if ( $AsQuery ) { return $query }
            $result = $query.Invoke()
            $LatestRecoveryRange = $result.Data | Sort-Object -Descending -Property EndTime 
            $RecoveryDateTime = $LatestRecoveryRange[0].EndTime.ToUniversalTime().ToString('yyyy-MM-ddTHH:mm:ss.fffZ')
        }
        if ($PSBoundParameters.ContainsKey('LastFull')) {
            $RubrikSnapshot = $RscMssqlDatabase| Get-RscSnapshot | Sort-Object date -Descending | Select-object -First 1
            $endBackupTime = [datetime]::UnixEpoch.AddSeconds(($RubrikSnapshot.MssqlAppMetadata.EndBackupTimestampMs / 1000))
            $RecoveryDateTime = $(Get-Date $endBackupTime).ToUniversalTime().ToString('yyyy-MM-ddTHH:mm:ss.fffZ')
        }
        if ($PSBoundParameters.ContainsKey('RestoreTime')) {
            $RawRestoreDate = (get-date -Date $RestoreTime)
            Write-Verbose ("RawRestoreDate is: $RawRestoreDate")
            $Now = (Get-Date).ToUniversalTime()
            if ($RawRestoreDate -ge $Now) { 
                $RecoveryDateTime = $RawRestoreDate.AddDays(-1)
                Write-Verbose ("RecoveryDateTime is: $RecoveryDateTime") 
            } 
            else { $RecoveryDateTime = $RawRestoreDate }
            $RecoveryDateTime = $RecoveryDateTime.ToUniversalTime().ToString('yyyy-MM-ddTHH:mm:ss.fffZ')
        }  
        #endregion
        return $RecoveryDateTime
    } 
}
