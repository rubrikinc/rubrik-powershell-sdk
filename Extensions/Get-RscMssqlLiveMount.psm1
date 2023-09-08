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
            ValueFromPipelineByPropertyName = $false
        )]
        [String]$MountedDatabaseName,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabase]$MssqlDatabase
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }
        Write-Host "Get-RscMssqlLiveMount: $inputProfile"

        $mssqlInputs = Invoke-RscQueryMssql -DatabaseLiveMounts -InputProfile $inputProfile -GetInput

        #region Filters
        $mssqlInputs.Var.filters = @()
        $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterInput
        $nameFilter.Field = "MOUNTED_DATABASE_NAME"
        $nameFilter.texts = $MountedDatabaseName
        $mssqlInputs.Var.filters += $nameFilter

        If ( $PSBoundParameters.ContainsKey('RscMssqlInstance') ) {
            $sourceDatabaseFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlDatabaseLiveMountFilterInput
            $sourceDatabaseFilter.Field = "SOURCE_DATABASE_ID"
            $sourceDatabaseFilter.Texts = $MssqlDatabase.Id
            $mssqlInputs.Var.filters += $sourceDatabaseFilter
        }
        #endregion

        #region Patch additional fields
        $mssqlInputs.Field.Nodes[0].Fid = "FETCH"
        $mssqlInputs.Field.Nodes[0].MountedDatabaseName = "FETCH"
        $mssqlInputs.Field.Nodes[0].MountedDatabaseId = "FETCH"
        $mssqlInputs.Field.Nodes[0].SourceDatabase = New-Object RubrikSecurityCloud.Types.MssqlDatabase
        $mssqlInputs.Field.Nodes[0].SourceDatabase.id = "FETCH"
        $mssqlInputs.Field.Nodes[0].SourceDatabase.name = "FETCH"
        $mssqlInputs.Field.Nodes[0].TargetInstance = New-Object RubrikSecurityCloud.Types.MssqlInstance
        $mssqlInputs.Field.Nodes[0].TargetInstance.id = "FETCH"
        $mssqlInputs.Field.Nodes[0].TargetInstance.name = "FETCH"
        #endregion

        $query = { Invoke-RscQueryMssql -DatabaseLiveMounts -InputProfile $inputProfile -Input $mssqlInputs }

        $result = ( Invoke-Command -ScriptBlock $query )

        $result.Nodes
    } 
}