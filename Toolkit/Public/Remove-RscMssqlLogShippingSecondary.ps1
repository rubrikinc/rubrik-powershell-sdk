#Requires -Version 3
function Remove-RscMssqlLogShippingSecondary {
    <#
    .SYNOPSIS
    Removes a log shipping secondary configuration for a Microsoft SQL Server database.

    .DESCRIPTION
    Deletes the log shipping relationship between the primary and secondary database. Optionally, the secondary database itself can be removed from the target SQL Server host. Obtain the log shipping object with Get-RscMssqlLogShipping.

    .PARAMETER RscMssqlLogShipping
    Log Shipping object returned from Get-RscMssqlLogShipping

    .PARAMETER deleteSecondaryDatabase
    Switch to delete the database off of the secondary host

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Removes the live mount from the SQL Server and cleans up the share and files on the Rubrik cluster
    $GetRscMssqlLogShipping = @{
        RscMssqlDatabase = $RscMssqlDatabase
        SecondaryDatabaseName = "logshipping_advanced_method"
        RscCluster = $RscCluster
    }
    $RscMssqlLogShipping = Get-RscMssqlLogShipping @GetRscMssqlLogShipping
    $RemoveRscMssqlLogShippingSecondary = Remove-RscMssqlLogShippingSecondary -RscMssqlLogShipping $RscMssqlLogShipping -deleteSecondaryDatabase
    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER RscMssqlLogShipping
    The log shipping target object. Pipe from Get-RscMssqlLogShipping.

    .PARAMETER deleteSecondaryDatabase
    Also delete the secondary database from the target SQL Server host.

    .EXAMPLE
    Remove a log shipping secondary and delete the database from the target host.

    $logShipping = Get-RscMssqlLogShipping -RscMssqlDatabase $db -SecondaryDatabaseName "AW_Secondary" -RscCluster $cluster
    Remove-RscMssqlLogShippingSecondary -RscMssqlLogShipping $logShipping -deleteSecondaryDatabase

    .EXAMPLE
    Remove only the log shipping configuration, keeping the secondary database.

    $logShipping = Get-RscMssqlLogShipping -RscMssqlDatabase $db -SecondaryDatabaseName "AW_Secondary" -RscCluster $cluster
    Remove-RscMssqlLogShippingSecondary -RscMssqlLogShipping $logShipping
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
        [Switch]$deleteSecondaryDatabase,

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
        $query = New-RscMutation -Gql deleteLogShipping  
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.DeleteLogShippingInput
        $query.Var.input.id = "$($RscMssqlLogShipping.Fid)"
        $query.Var.input.deleteSecondaryDatabase = $deleteSecondaryDatabase

        #endregion
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result
    } 
}
