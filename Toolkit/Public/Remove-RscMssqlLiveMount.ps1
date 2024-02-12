#Requires -Version 3
function Remove-RscMssqlLiveMount {
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
        [Switch]$Force,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Remove-RscMssqlLiveMount field profile: $fieldProfile"
        
        #region Create Query
        $query = New-RscMutationMssql -Operation DeleteLiveMount  
        $query.Var.input = New-Object -TypeName RubrikSecurityCloud.Types.DeleteMssqlLiveMountInput

        $query.Var.input.id = "$($MssqlLiveMount.Fid)"
        $query.Var.input.force = $force

        #endregion

        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }
        $result
        
    } 
}
