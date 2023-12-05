#Requires -Version 3
function Get-RscManagedVolume {
    <#
    .SYNOPSIS
    Retrieve info about Persistent Mount Managed Volumes

    .DESCRIPTION
    Retrieve info about Persistent Mount Managed Volumes. Persistent Mount Managed Volumes are controlled externally by the user, 
    unlike SLA Managed Volumes which are controlled by the SLA Domain. 

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Used to create a list of Managed Volumes

    .PARAMETER Name
    Used to return a specific Managed Volume based on the name

    .PARAMETER RscCluster
    RscCluster object retrieved via Get-RscCluster

   
    .EXAMPLE
    Return back a list of Managed Volumes.
    Get-RscManagedVolume -List

    .EXAMPLE
    Return back a list of Managed Volumes for a specified Rubrik Cluster
    Get-RscManagedVolume -List -RscCluster $RscCluster

    .EXAMPLE
    Returns back information about a specific Managed Volume
    Get-RscManagedVolume -Name rp-mysql-01 
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )]
        [Switch]$List,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$Name,
        
        [Parameter(
            Mandatory = $false
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster
    )
    
    Process {
        Write-Debug "-Running Get-RscManagedVolume"

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        #region Create Query
        switch ( $PSCmdlet.ParameterSetName){
            "List" {
                $query = New-RscQueryManagedVolume -Operation ManagedVolumes -FieldProfile $fieldProfile 
            }
            "Name"{
                $query = New-RscQueryManagedVolume -Operation ManagedVolumes -FieldProfile $fieldProfile 
                $query.Var.filter = @()
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                $nameFilter.texts = $Name
                $query.Var.filter += $nameFilter
            }
        }
        #endregion
        if($PSBoundParameters.ContainsKey('clusterId')) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $RscCluster.Id
            $query.Var.filter += $clusterFilter
        }
        $result = Get-RscPages -Query $query
        $result
    } 
}
