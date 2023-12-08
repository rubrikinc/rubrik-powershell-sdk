#Requires -Version 3
function Get-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    Returns information about a Live Mounted MSSQL Database

    .DESCRIPTION
    Returns information about a Live Mounted MSSQL Database

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER MountedDatabaseName
    Name of the database that was Live Mounted
    
    .PARAMETER MssqlDatabase
    Database object returned from Get-RscMssqlDatabase

    .EXAMPLE
    Returns the list of database files based on the latest recovery point
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlLiveMount -RscMssqlDatabase $RscMssqlDatabase -MountedDatabaseName AdventureWorks2019_LiveMount
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
        [RubrikSecurityCloud.Types.MssqlDatabase]$RscMssqlDatabase
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
        $query = New-RscQueryMssql -Operation DatabaseLiveMounts -FieldProfile $fieldProfile
        #endregion

        #region Filters
        $query.Var.filters = @()
        $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterInput
        $nameFilter.Field = "MOUNTED_DATABASE_NAME"
        $nameFilter.texts = $MountedDatabaseName
        $query.Var.filters += $nameFilter

        If ( $PSBoundParameters.ContainsKey('MssqlDatabase') ) {
            $sourceDatabaseFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterInput
            $sourceDatabaseFilter.Field = "SOURCE_DATABASE_ID"
            $sourceDatabaseFilter.Texts = $RscMssqlDatabase.Id
            $query.Var.filters += $sourceDatabaseFilter
        }
        #endregion
        $result = $query.Invoke()
        $result
    } 
}
