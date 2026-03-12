#Requires -Version 3
function New-RscMssqlLogBackup {
    <#
    .SYNOPSIS
    Triggers an on-demand transaction log backup of a Microsoft SQL Server database.

    .DESCRIPTION
    Initiates an immediate transaction log backup for the specified SQL Server database. Use this to capture the latest log activity before a planned recovery operation or to shorten the recovery point window between scheduled log backups.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase
    
    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

The MSSQL database object to back up. Pipe from Get-RscMssqlDatabase.

    .EXAMPLE
    Trigger a log backup for a specific database.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlLogBackup -RscMssqlDatabase $db

    .EXAMPLE
    Pipe the database object directly.

    Get-RscMssqlDatabase -Name AdventureWorks2019 | New-RscMssqlLogBackup
    #>

    [CmdletBinding(
    )]
    Param(
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )]
        [Switch]$AsQuery
    )
    Process {
        Write-Debug "- Running New-RscMssqlLogBackup"
        #region Create Query
        $query = New-RscMutation -Gql takeMssqlLogBackup
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.TakeMssqlLogBackupInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        #endregion
        
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
