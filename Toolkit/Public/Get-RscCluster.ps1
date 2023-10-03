#Requires -Version 3
function Get-RscCluster {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$List,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$Name,
        
        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$Detail
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "Get-RscCluster field profile: $fieldProfile"

        #region Create Query
        switch ( $PSCmdlet.ParameterSetName ){
            "List" {
                $query = New-RscQueryCluster -List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
            }
            "Name"{
                $query = New-RscQueryCluster -List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
                $query.Var.filter = New-Object -TypeName RubrikSecurityCloud.Types.ClusterFilterInput
                $query.Var.filter.Name = $Name
            }
        }
        
        $result = $query.Invoke()    
        if ($null -ne $result.Nodes){
            $result.Nodes #| Remove-NullProperties
        }else{
            $result #| Remove-NullProperties
        }    
    } 
}
