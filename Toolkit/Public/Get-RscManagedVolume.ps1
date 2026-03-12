#Requires -Version 3
function Get-RscManagedVolume {
    <#
    .SYNOPSIS
    Retrieves Managed Volumes from Rubrik Security Cloud.

    .DESCRIPTION
    Returns Persistent Mount Managed Volumes managed by Rubrik. These volumes are
    externally controlled by the user (unlike SLA-managed volumes). You can list all
    volumes or filter by name or cluster.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Return all items. This is the default behavior.

    .PARAMETER Name
    Filter by name. Exact match on the Managed Volume name.

    .PARAMETER RscCluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

   
    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.
    .EXAMPLE
    # Get all Managed Volumes
    Get-RscManagedVolume -List

    .EXAMPLE
    # Get a Managed Volume by name
    Get-RscManagedVolume -Name rp-mysql-01

    .EXAMPLE
    # Get Managed Volumes on a specific cluster
    Get-RscCluster -Name "cluster-east" | Get-RscManagedVolume -List
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
        )][RubrikSecurityCloud.Types.Cluster]$RscCluster,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        Write-Debug "-Running Get-RscManagedVolume"

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }

        $query = New-RscQuery -Gql managedVolumes -FieldProfile $fieldProfile 
        $query.Var.filter = @()

        #region Create Query
        if($Name) {
            $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
            $nameFilter.texts = $Name
            $query.Var.filter += $nameFilter
        }
        if($RscCluster) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
            $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
            $clusterFilter.texts = $RscCluster.Id
            $query.Var.filter += $clusterFilter
        }
        
        #endregion
        if ( $AsQuery ) { return $query }
        $result = $query.Invoke()
        $result.Nodes
    }
} 
