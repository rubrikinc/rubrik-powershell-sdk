#Requires -Version 3
function Remove-RscMssqlLogShippingSecondary {
    <#
    .SYNOPSIS
    Removes a log shipping secondary of a MSSQL Database

    .DESCRIPTION
    Removes a log shipping secondary of a MSSQL Database

    .PARAMETER RscMssqlLogShipping
    Log Shipping object returned from Get-RscMssqlLogShipping

    .PARAMETER deleteSecondaryDatabase
    Switch to delete the database off of the secondary host

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

    .EXAMPLE
    ___ Add example here ___
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
        [Switch]$deleteSecondaryDatabase
    )
    
    Process {
        Write-Debug "- Running Remove-RscMssqlLiveMount"
        
        #region Create Query
        $query = New-RscMutationMssql -Operation DeleteLogShipping  
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.DeleteLogShippingInput
        $query.Var.input.id = "$($RscMssqlLogShipping.Fid)"
        $query.Var.input.deleteSecondaryDatabase = $deleteSecondaryDatabase

        #endregion
        $result = $query.Invoke()
        $result
    } 
}
