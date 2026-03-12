#Requires -Version 3
function New-RscMssqlLogBackup {
    <#
    .SYNOPSIS
    Starts an Log Backup of a MSSQL Database

    .DESCRIPTION
    Starts an Log Backup of a MSSQL Database

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlDatabase
    Database object returned from Get-RscMssqlDatabase
    
    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Returns the list of database files based on the latest recovery point
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    New-RscMssqlLogBackup -RscMssqlDatabase $RscMssqlDatabase
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
        $query = New-RscMutationMssql -Operation TakeLogBackup
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.TakeMssqlLogBackupInput
        $query.Var.input.id = "$($RscMssqlDatabase.Id)"
        #endregion
        
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
