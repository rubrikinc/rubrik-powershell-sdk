#Requires -Version 3
function Get-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    Retrieves SQL Server Live Mount information from Rubrik Security Cloud.

    .DESCRIPTION
    Returns details about SQL Server databases that have been Live Mounted through
    Rubrik. A Live Mount is a writable copy of a database mounted from a Rubrik
    snapshot. You can filter by the mounted database name or the source database object.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER MountedDatabaseName
    The name of the Live Mounted database on the target SQL Server.

    .PARAMETER RscMssqlDatabase
    A SQL Server database object, typically obtained from Get-RscMssqlDatabase.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    # Get Live Mount info for a specific mounted database
    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlLiveMount -RscMssqlDatabase $db -MountedDatabaseName AdventureWorks2019_LiveMount

    .EXAMPLE
    # Get all Live Mounts for a source database
    Get-RscMssqlDatabase -Name AdventureWorks2019 | Get-RscMssqlLiveMount
    #>
    [CmdletBinding()]
    Param(        
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [String]$MountedDatabaseName,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        Write-Debug "-Running Get-RscMssqlLiveMount"

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlLiveMount field profile: $fieldProfile"
        
        #region Create Query
        $query = New-RscQuery -Gql mssqlDatabaseLiveMounts `
            -AddField Nodes.MountedDatabaseName, `
                Nodes.CreationDate, `
                Nodes.RecoveryPoint #, `
                # Nodes.TargetInstance
                # Nodes.SourceDatabase
                # Nodes.Cluster #, `
                # Nodes.SourceDatabase #, `
                
        #endregion

        #region Filters
        $query.Var.filters = @()
        $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterInput
        $nameFilter.Field = "MOUNTED_DATABASE_NAME"
        $nameFilter.texts = $MountedDatabaseName
        $query.Var.filters += $nameFilter

        If ( $PSBoundParameters.ContainsKey('RscMssqlDatabase') ) {
            $sourceDatabaseFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterInput
            $sourceDatabaseFilter.Field = "SOURCE_DATABASE_ID"
            $sourceDatabaseFilter.Texts = $RscMssqlDatabase.Id
            $query.Var.filters += $sourceDatabaseFilter
        }
        #endregion
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result.Nodes
    } 
}
