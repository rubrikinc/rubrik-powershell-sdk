#Requires -Version 3
function Get-RscMssqlDatabaseRecoveryPoint {
    <#
    .SYNOPSIS
    Returns back the exact point in time covereted to UTC. 

    .DESCRIPTION
    Returns back the exact point in time covereted to UTC based on input provided. 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Returns exact point in time in UTC based on the latest recovery point
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -Latest

    .EXAMPLE
    Returns exact point in time in UTC based on the last snapshot taken
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -LastFull

    .EXAMPLE
    Returns exact point in time in UTC based on a specific point in time. 
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $RscMssqlDatabase -RestoreTime "2023-10-27 08:37:00.000Z"
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

        #  Common parameter to all parameter sets:
        # [Parameter(
        #     Mandatory = $false, 
        #     ValueFromPipeline = $false
        # )][Switch]$Detail,

        # [Parameter(
        #     Mandatory = $false, 
        #     ValueFromPipeline = $false
        # )][Switch]$IncludeNullProperties,

        # [Parameter(
        #     Mandatory = $false, 
        #     ValueFromPipeline = $false
        # )][Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlDatabaseRecoveryPoint field profile: $fieldProfile"
        
        #region Create Query
        if ($PSBoundParameters.ContainsKey('Latest')) {
            $query = New-RscQueryMssql -Op RecoverableRanges -AddField Data.BeginTime, Data.EndTime
            $query.Var.input.id = $RscMssqlDatabase.id
            $result = $query.Invoke()
            $LatestRecoveryRange = $result.Data[$result.Count -1]
            $RecoveryDateTime = $LatestRecoveryRange.EndTime.ToUniversalTime().ToString('yyyy-MM-ddTHH:mm:ss.fffZ')
        }
        if ($PSBoundParameters.ContainsKey('LastFull')) {
            $RubrikSnapshot = Get-RscSnapshot -SnappableId $RscMssqlDatabase.id  | Sort-Object date -Descending | Select-object -First 1
            $RecoveryDateTime = $(Get-Date $RubrikSnapshot.Date).ToUniversalTime().ToString('yyyy-MM-ddTHH:mm:ss.fffZ')
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
