#Requires -Version 3
function Get-RscMssqlDatabaseRecoverableRanges {
    <#
    .SYNOPSIS
    Retrieves recoverable time ranges for a SQL Server database.

    .DESCRIPTION
    Returns date/time ranges during which a SQL Server database can be recovered to
    any point in time. Each range has a begin and end time; the database can be
    restored to any moment within that range. Use -afterTime and -beforeTime to
    narrow the results.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    A SQL Server database object, typically obtained from Get-RscMssqlDatabase.

    .PARAMETER afterTime
    Return only ranges that end after this date/time.

    .PARAMETER beforeTime
    Return only ranges that begin before this date/time.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get all recoverable ranges for a database
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $db

    .EXAMPLE
    # Get recoverable ranges after a specific date
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseRecoverableRanges -RscMssqlDatabase $db -afterTime "2024-01-01"
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
        )][datetime]$beforeTime,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        Write-Debug "- Running Get-RscMssqlDatabaseRecoverableRanges"

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlDatabaseRecoverableRanges field profile: $fieldProfile"

        $query = New-RscQuery -Gql mssqlRecoverableRanges -FieldProfile $fieldProfile -AddField Data.BeginTime, Data.EndTime
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.GetMssqlDbRecoverableRangesInput
        $query.Var.input.id = $RscMssqlDatabase.id
        if($PSBoundParameters.ContainsKey('afterTime')){
            $query.Var.input.afterTime = $afterTime
        }
        if($PSBoundParameters.ContainsKey('beforeTime')){
            $query.Var.input.beforeTime = $beforeTime
        }

        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result.Data
    } 
}
