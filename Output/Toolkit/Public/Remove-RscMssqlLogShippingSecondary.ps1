#Requires -Version 3
function Remove-RscMssqlLogShippingSecondary {
    <#
    .SYNOPSIS
    Removes a Live Mount of a MSSQL Database

    .DESCRIPTION
    Removes a Live Mount of a MSSQL Database

    .PARAMETER MssqlLiveMount
    Live Mount object returned from Get-RscMssqlLiveMount

    .PARAMETER Force
    Forces the unmount of a database in the event Rubrik cannot connect to the SQL Server Instance or database. 

    .PARAMETER AsQuery
    Instead of running the command, the query and variables used for the query will be returned. 

    .EXAMPLE
    Removes the live mount from the SQL Server and cleans up the share and files on the Rubrik cluster
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlLiveMount -RscMssqlDatabase $RscMssqlDatabase -MountedDatabaseName AdventureWorks2019_LiveMount
    Remove-RscMssqlLiveMount -MssqlLiveMount $RscMssqlLiveMount
    
    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlDatabaseLiveMount]$MssqlLiveMount, 

        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $false
        )]
        [Switch]$Force
    )
    
    Process {
        Write-Debug "- Running Remove-RscMssqlLiveMount"
        
        #region Create Query
        $query = New-RscMutationMssql -Operation DeleteLiveMount  
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.DeleteMssqlLiveMountInput

        $query.Var.input.id = "$($MssqlLiveMount.Fid)"
        $query.Var.input.force = $force

        #endregion
        $result = $query.Invoke()
        $result
    } 
}
