#Requires -Version 3
function Get-RscMssqlDatabaseRecoveryPoint {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>

    [CmdletBinding()]
    param(
        # Rubrik's database id value
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
        [datetime]$RestoreTime
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
        return $RecoveryDateTime
    } 
}
