#Requires -Version 3
function Get-RscMssqlDatabaseFiles {
    <#
    .SYNOPSIS
    Retrieves the file list for a SQL Server database at a given recovery point.

    .DESCRIPTION
    Returns the data and log files that existed for a SQL Server database at a
    specified point in time. This information is needed when performing database
    exports to map files to new locations. Use Get-RscMssqlDatabaseRecoveryPoint
    to obtain a valid recovery date/time.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    A SQL Server database object, typically obtained from Get-RscMssqlDatabase.

    .PARAMETER RecoveryDateTime
    The recovery point in time. Use Get-RscMssqlDatabaseRecoveryPoint to obtain a valid value.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get database files at a specific recovery point
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlDatabaseFiles -RscMssqlDatabase $db -RecoveryDateTime "2024-01-15 08:00:00.000Z"

    .EXAMPLE
    # Get database files at the latest recovery point
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    $recoveryPoint = Get-RscMssqlDatabaseRecoveryPoint -RscMssqlDatabase $db -Latest
    Get-RscMssqlDatabaseFiles -RscMssqlDatabase $db -RecoveryDateTime $recoveryPoint
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
        
        $query = New-RscQuery -Gql allMssqlDatabaseRestoreFiles -FieldProfile $fieldProfile -Addfield Items.fileType, Items.logicalName, Items.originalName, Items.originalPath
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.MssqlGetRestoreFilesV1Input
        $query.Var.input.id = $RscMssqlDatabase.Id
        $query.Var.input.time = $RecoveryDateTime

        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result.Items
    } 
}
