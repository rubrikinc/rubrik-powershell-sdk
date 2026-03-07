#Requires -Version 3
function Get-RscMongoSource {
    <#
    .SYNOPSIS
    Retrieves MongoDB sources managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns MongoDB sources (clusters or standalone instances) that are registered
    with Rubrik. You can filter by name, SLA Domain, or cluster. Use -Id to
    retrieve a single source by its RSC identifier.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Id
    The RSC object ID.

    .PARAMETER Name
    Filter by name. Supports partial matching.

    .PARAMETER Sla
    An SLA Domain object to filter by. Pipe from Get-RscSla.

    .PARAMETER Cluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .EXAMPLE
    # Get all MongoDB sources
    Get-RscMongoSource

    .EXAMPLE
    # Get a MongoDB source by name
    Get-RscMongoSource -Name "mongo-prod"
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [String]$Id,
        [Parameter(
            Position = 0,
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$Name,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.Cluster]$Cluster,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -Gql mongoSource
            $query.var.filter = @()
            $query.Var.fid = $Id

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -Gql mongoSources
            $query.var.filter = @()

            if ($Name) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                # Regex filter doesn't work in the API right now, but we're going to play pretend. 
                # With real Regex, users could search for VMs that start with the letter A if they wanted.
                if ($name.Contains("*")) {
                    $name.Replace("*",'')
                    $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::REGEX
                    $nameFilter.texts = $Name.Replace("*",'')
                } else {
                    $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                    $nameFilter.texts = $Name
                }
                $query.var.filter += $nameFilter
            }
    
            if ($Sla) {
                $slaFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $slaFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::EFFECTIVE_SLA
                $slaFilter.Texts = $Sla.id
                $query.var.filter += $slaFilter
            }

            if ($Cluster) {
                $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $clusterFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::CLUSTER_ID
                $clusterFilter.Texts = $Cluster.id
                $query.var.filter += $clusterFilter
            }

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }





    } 
}

