#Requires -Version 3
function Get-RscCluster {
<#
    .SYNOPSIS
    Retrieve info about clusters
    
    .DESCRIPTION
    By default, retrieve info about all clusters.
    By default, responses contain a minimal set of fields: mostly ids and names.
    To get more details, use the `-Detail` parameter.
    
    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference
    The ClusterConnection type:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html
    
    The Cluster type:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/cluster.doc.html
    
    .PARAMETER List
    Used to create a list of clusters that are connected to Rubrik Securiry Cloud

    .PARAMETER Name
    Used to return a specific cluster based on the name

    .PARAMETER Detail
    Changes the data profile. This can affect the fields returned

    .PARAMETER IncludeNullProperties
    By default, fields will a NULL are not returned. Supplying this parameter will return all fields, including fields
    with a NULL in them. 

    .PARAMETER AsQuery
    Instead of running the command, the query and variables used for the query will be returned. 
    
    .EXAMPLE
    Return a list of all clusters managed by RSC
    
    Get-RscCluster -List
    
    .EXAMPLE
    Return a information about a cluster based on the name

    Get-RscCluster -Name vault-r-london
    
    
    .EXAMPLE
    Return back all fields, including the fields that are null
    
    Get-RscCluster -Name vault-r-london -IncludeNullProperties

    .EXAMPLE
    Return back just the query that will be run instead of running the query and returning the results

    Get-RscCluster -Name vault-r-london -AsQuery    
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
        )][Switch]$Detail,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$IncludeNullProperties,

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
        Write-Host "Get-RscCluster field profile: $fieldProfile"

        #region Create Query
        switch ( $PSCmdlet.ParameterSetName ){
            "List" {
                $query = New-RscQueryCluster -Operation List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
            }
            "Name"{
                $query = New-RscQueryCluster -Operation List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
                $query.Var.filter = New-Object -TypeName RubrikSecurityCloud.Types.ClusterFilterInput
                $query.Var.filter.Name = $Name
            }
        }
        #endregion

        if ( $AsQuery -eq $true ) {
            $result = $query.GqlRequest()
        }else{
            $result = $query.Invoke()
        }

        if ($null -ne $result.Nodes){
            if ( $IncludeNullProperties -eq $true ) {
                $result.Nodes
            }else{
                $result.Nodes | Remove-NullProperties
            }
        }else{
            if ( $IncludeNullProperties -eq $true ) {
                $result
            }else{
                $result | Remove-NullProperties
            }
        }    
    } 
}
