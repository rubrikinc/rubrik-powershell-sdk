#Requires -Version 3
function Set-RscMssqlLogShippingSecondary {
    <#
    .SYNOPSIS
    Configures a SQL Server log shipping secondary database in Rubrik Security Cloud.

    .DESCRIPTION
    Updates the configuration of a SQL Server log shipping secondary target.
    Use this cmdlet to modify settings on an existing log shipping relationship
    managed by Rubrik. The log shipping target object is typically obtained
    from Get-RscMssqlLogShipping.

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

    .PARAMETER RscMssqlLogShipping
    A log shipping target object, typically obtained from Get-RscMssqlLogShipping.

    .PARAMETER Force
    Force the operation even if Rubrik cannot connect to the SQL Server instance.

    .EXAMPLE
    # Update a log shipping secondary configuration
    $logShipping = Get-RscMssqlLogShipping -Name "AdventureWorks2019"
    Set-RscMssqlLogShippingSecondary -RscMssqlLogShipping $logShipping

    .EXAMPLE
    # Pipe a log shipping target directly
    Get-RscMssqlLogShipping -Name "AdventureWorks2019" | Set-RscMssqlLogShippingSecondary
    #>

    [CmdletBinding()]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.MssqlLogShippingTarget]$RscMssqlLogShipping, 

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
