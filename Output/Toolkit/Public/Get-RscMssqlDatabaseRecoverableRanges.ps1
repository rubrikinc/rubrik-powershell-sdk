#Requires -Version 3
function Get-RscMssqlDatabaseRecoverableRanges {
    <#
    .SYNOPSIS
    Return a list of ranges of dates that shows when a database can be recovered to. 

    .DESCRIPTION
    Return a list of ranges of dates that shows when a database can be recovered to. The returned information will reflect similar information that is displayed in the Rubrik Security Cloud
    UI. Points between the begin and end times can be recovered to any point in time inside that range. 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER afterTime
    Used to filter ranges 
    
    .PARAMETER beforeTime
    Used to filter ranges 

    .EXAMPLE
    Returns all of the ranges the database can be recovered to. 
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $RscMssqlDatabase

    .EXAMPLE
    Returns all of the ranges the database can be recovered to filtered to be only after a specific date/time
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $RscMssqlDatabase -afterTime

    .EXAMPLE
    Returns all of the ranges the database can be recovered to filtered to be only before a specific date/time
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $RscMssqlDatabase -beforeTime
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $true, 
            ValueFromPipeline = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,
        
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false
        )][datetime]$afterTime,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false
        )][datetime]$beforeTime
    )
    
    Process {
        Write-Debug "- Running Get-RscMssqlDatabaseRecoverableRanges"

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlDatabaseRecoverableRanges field profile: $fieldProfile"

        $query = New-RscQueryMssql -Operation RecoverableRanges -FieldProfile $fieldProfile -AddField Data.BeginTime, Data.EndTime
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.GetMssqlDbRecoverableRangesInput
        $query.Var.input.id = $RscMssqlDatabase.id
        if($PSBoundParameters.ContainsKey('afterTime')){
            $query.Var.input.afterTime = $afterTime
        }
        if($PSBoundParameters.ContainsKey('beforeTime')){
            $query.Var.input.beforeTime = $beforeTime
        }

        $result = Get-RscPages -Query $query   
        $result
    } 
}
