#Requires -Version 3
function Get-RscNutanixVm {
    <#
    .SYNOPSIS
    Retrieves Nutanix AHV virtual machines managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns Nutanix AHV VMs that are protected or inventoried by Rubrik. You can
    filter by name, SLA Domain, or cluster. Use -Id to retrieve a single VM
    by its RSC identifier.

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
    # Get all Nutanix VMs
    Get-RscNutanixVm

    .EXAMPLE
    # Get a Nutanix VM by name
    Get-RscNutanixVm -Name "nutanix-vm-01"

    .EXAMPLE
    # Get Nutanix VMs protected by a specific SLA
    Get-RscSla -Name "Gold" | Get-RscNutanixVm
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
            $query = New-RscQuery -Gql nutanixVm
            $query.var.filter = @()
            $query.Var.fid = $Id
            $query.Field.Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            $query.Field.Cluster.id = "PIZZA" # Could Fields be a version of the type structure that has all booleans to define what we get back?
            $query.Field.AgentStatus = New-Object -TypeName RubrikSecurityCloud.Types.NutanixVmAgentStatus
            $query.Field.AgentStatus.connectionStatus = New-Object -typename RubrikSecurityCloud.Types.NutanixVmAgentConnectionStatus
            $query.Field.osType = New-Object -TypeName RubrikSecurityCloud.Types.OsType
            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -Gql nutanixVms
            $query.var.filter = @()
            $query.Field.Nodes[0].Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            $query.Field.Nodes[0].Cluster.id = "FETCH"
            $query.Field.Nodes[0].Cluster.name = "FETCH"
            $query.Field.Nodes[0].AgentStatus = New-Object -TypeName RubrikSecurityCloud.Types.NutanixVmAgentStatus
            $query.Field.Nodes[0].AgentStatus.connectionStatus = New-Object -typename RubrikSecurityCloud.Types.NutanixVmAgentConnectionStatus
            $query.Field.Nodes[0].osType = New-Object -TypeName RubrikSecurityCloud.Types.OsType
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
