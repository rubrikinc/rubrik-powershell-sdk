#Requires -Version 3
function Remove-RscMssqlLiveMount {
    <#
    .SYNOPSIS
    Removes a live mount of a Microsoft SQL Server database.

    .DESCRIPTION
    Unmounts a previously live-mounted SQL Server database and cleans up the associated share and files on the Rubrik cluster. Use -Force to unmount even when Rubrik cannot connect to the SQL Server instance, for example when the host is offline. Obtain the live mount object with Get-RscMssqlLiveMount.

    .PARAMETER MssqlLiveMount
    Live Mount object returned from Get-RscMssqlLiveMount

    .PARAMETER Force
    Forces the unmount of a database in the event Rubrik cannot connect to the SQL Server Instance or database. 

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Removes the live mount from the SQL Server and cleans up the share and files on the Rubrik cluster
    $RscMssqlDatabase = Get-RscMssqlDatabase -Name AdventureWorks2019
    Get-RscMssqlLiveMount -RscMssqlDatabase $RscMssqlDatabase -MountedDatabaseName AdventureWorks2019_LiveMount
    Remove-RscMssqlLiveMount -MssqlLiveMount $RscMssqlLiveMount
    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER MssqlLiveMount
    The live mount object to remove. Pipe from Get-RscMssqlLiveMount.

    .PARAMETER Force
    Force the unmount even if Rubrik cannot connect to the SQL Server instance.

    .EXAMPLE
    Remove a live mount by looking it up from the source database.

    $db = Get-RscMssqlDatabase -Name AdventureWorks2019
    $mount = Get-RscMssqlLiveMount -RscMssqlDatabase $db -MountedDatabaseName AdventureWorks2019_LiveMount
    Remove-RscMssqlLiveMount -MssqlLiveMount $mount

    .EXAMPLE
    Force-remove a live mount when the SQL Server host is unreachable.

    $mount = Get-RscMssqlLiveMount -RscMssqlDatabase $db -MountedDatabaseName AdventureWorks2019_LiveMount
    Remove-RscMssqlLiveMount -MssqlLiveMount $mount -Force
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
        [Switch]$Force,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )]
        [Switch]$AsQuery
    )
    
    Process {
        Write-Debug "- Running Remove-RscMssqlLiveMount"
        
        #region Create Query
        $query = New-RscMutation -Gql deleteMssqlLiveMount  
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.DeleteMssqlLiveMountInput

        $query.Var.input.id = "$($MssqlLiveMount.Fid)"
        $query.Var.input.force = $force

        #endregion
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
