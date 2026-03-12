#Requires -Version 3
function Get-RscMssqlDatabaseFiles {
    <#
    .SYNOPSIS
    Return a list of database files that existed at the time of the backup

    .DESCRIPTION
    Return a list of database files that existed at the time of the backup. This is used for Export-RscMssqlDatabase

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .PARAMETER RecoveryDateTime
    Use Get-RscMssqlDatabaseRecoveryPoint to get a fully formatted date and time for the recovery point

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Returns the list of database files based on a specific point in time. 
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseFiles -RscMssqlDatabase $RscMssqlDatabase -RecoveryDateTime "2023-10-27 08:37:00.000Z"
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $true
        )][RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,
        
        [Parameter(
            Mandatory = $true
        )][datetime]$RecoveryDateTime,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Debug "- Running Get-RscMssqlDatabaseFiles"
        
        $query = New-RscQueryMssql -Operation DatabaseRestoreFiles -FieldProfile $fieldProfile -Addfield Items.fileType, Items.logicalName, Items.originalName, Items.originalPath
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.MssqlGetRestoreFilesV1Input
        $query.Var.input.id = $RscMssqlDatabase.Id
        $query.Var.input.time = $RecoveryDateTime

        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result.Items
    } 
}
