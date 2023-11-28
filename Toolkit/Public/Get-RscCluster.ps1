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
    Retrieve the list of clusters that are connected to Rubrik Securiry Cloud.
    This is the default parameter set.

    .PARAMETER Id
    Retrieve a cluster based on a the ID of the cluster in Rubrik Security Cloud

    .PARAMETER Name
    Used to return a specific cluster based on the name

    # .PARAMETER Detail
    Use the DETAIL field profile instead of the DEFAULT field profile.
    The DETAIL field profile returns more fields than the DEFAULT field profile.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.
    
    .EXAMPLE
    Return a list of all clusters managed by RSC
    
    Get-RscCluster -List
    
    .EXAMPLE
    Return a RscCluster Object based on a specific cluster Id
    Get-RscCluster -Id "86da734b-2fee-4fdc-bdc8-a73ab5648f" 
    
    .EXAMPLE
    Return a RscCluster Object based on the name
    Get-RscCluster -Name vault-r-london
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )][Switch]$List,

        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            HelpMessage = "Return only the cluster with the specified id"
        )]
        [String]$Id,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false
        )][String]$Name,
        
        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false,
            HelpMessage = "Return more fields than the default field profile"
        )][Switch]$Detail
    )
    
    Process {
        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Debug "- Running Get-RscCluster"

        #regionCreate Query
        if ($List){
            $query = New-RscQueryCluster -Operation List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
        }

        if ($Id){
            $query = New-RscQueryCluster -Operation Cluster -FieldProfile $fieldProfile
            $query.Var.clusterUuid = $Id
        }

        if ($Name){
            $query = New-RscQueryCluster -Operation List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
            $query.Var.filter = New-Object -TypeName RubrikSecurityCloud.Types.ClusterFilterInput
            $query.Var.filter.Name = $Name
        }
        #endregion
        
        if ($AsQuery){
            $result = $query.GqlRequest()
        }else{
            $result = Get-RscPages -Query $query
        }
        $result
    } 
}
