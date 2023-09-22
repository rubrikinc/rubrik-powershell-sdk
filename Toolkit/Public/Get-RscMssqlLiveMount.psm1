#Requires -Version 3
function Get-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    Get a list of MSSQL Live Mounted Databases

    .DESCRIPTION
    Get a list of MSSQL Live Mounted Databases

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    Get-RscMssqlLiveMount

    Returns back all MSSQL Database Live Mounts
    
    .EXAMPLE
    Get-RscMssqlLiveMount -MountedDatabaseName AdventureWorks

    Returns back all MSSQL Databases named AdventureWorks that are Live Mounted
    
    .EXAMPLE
    Get-RscMssqlDatabase -Name AdventureWorks2017 | Get-RscMssqlLiveMount

    Returns back all MSSQL Databases named AdventureWorks2017 that are Live Mounted

    .EXAMPLE
    Get-RscMssqlDatabase -Name AdventureWorks2017 | Get-RscMssqlLiveMount -MountedDatabaseName AdventureWorks2017_LM

    Returns back the AdventureWorks2017_LM record based on the object returned in Get-RscMssqlDatabase 
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
        [RubrikSecurityCloud.Types.MssqlDatabase]$MssqlDatabase
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        #region Create Query
        $query = New-RscGqlQueryMssqlDatabaseLiveMounts -Patch Nodes
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
            $sourceDatabaseFilter.Texts = $MssqlDatabase.Id
            $query.Var.filters += $sourceDatabaseFilter
        }
        #endregion

        $result = $query.Invoke()
        $result = $result.Nodes | Where-Object { $_.isReady -eq "true" }
        $result
    } 
}