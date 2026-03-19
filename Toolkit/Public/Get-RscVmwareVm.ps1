#Requires -Version 3
function Get-RscVmwareVm {
    <#
    .SYNOPSIS
    Retrieves VMware vSphere virtual machines managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns VMware vSphere VMs that are protected or inventoried by Rubrik.
    You can filter by name, SLA Domain, cluster, or organization. Use -Id to
    retrieve a single VM by its RSC identifier. By default returns a standard
    set of fields; use -Detail for additional properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

.PARAMETER Id
    The RSC object ID.

    .PARAMETER Detail
    Return additional fields beyond the default set.

    .PARAMETER Name
    Filter by name. Supports partial matching.

    .PARAMETER Relic
    Include deleted VMs that still have snapshots in Rubrik.

    .PARAMETER Replica
    Include replicated copies.

    .PARAMETER Sla
    An SLA Domain object to filter by. Pipe from Get-RscSla.

    .PARAMETER Cluster
    A Rubrik cluster object to filter by. Pipe from Get-RscCluster.

    .PARAMETER Org
    An RSC Organization to filter by. Pipe from Get-RscOrganization.

    .EXAMPLE
    # Get all VMware VMs
    Get-RscVmwareVm

    .EXAMPLE
    # Get a VM by name
    Get-RscVmwareVm -Name "web-server-01"

    .EXAMPLE
    # Get VMs assigned to a specific SLA
    Get-RscSla -Name "Gold" | Get-RscVmwareVm
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
            Mandatory = $false
        )]
        [Switch]$Detail,
        [Parameter(
            Position = 0,
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [String]$Name,
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [switch]$Relic,
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [switch]$Replica,
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
            ValueFromPipeline = $true,
            ParameterSetName = "Name"
        )]
        [RubrikSecurityCloud.Types.Org]$Org,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }

        # Shared helper: populate VsphereVm field spec.
        function Set-VmFields($vm) {
            $vm.Cluster = Get-RscType -Name Cluster -InitialProperties Name, Id
            $vm.GuestOsName = "FETCH"
            $vm.AgentStatus = Get-RscType -Name AgentStatus -InitialProperties @("agentStatusField")
            $vm.snapshotConsistencyMandate = [RubrikSecurityCloud.Types.ConsistencyLevelEnum]::CRASH_CONSISTENT
            $vm.allOrgs = Get-RscType -Name Org -InitialProperties Name, Id
        }

       # The query is different for getting a single object by ID.
        if ($Id) {
            $query = New-RscQuery -Gql vSphereVmNew -FieldProfile $inputProfile
            $query.var.filter = @()
            $query.Var.fid = $Id
            Set-VmFields $query.Field
            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            $query = New-RscQuery -Gql vsphereVmNewConnection -FieldProfile $inputProfile
            $query.var.filter = @()
            Set-VmFields $query.Field.Nodes[0]
            if ($Name) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                # Regex filter doesn't work in the API right now, but we're going to play pretend. 
                # With real Regex, users could search for VMs that start with the letter A if they wanted.
                if ($name.Contains("*")) {
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

            if ($Org) {
                $orgFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $orgFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::ORGANIZATION_ID
                $orgFilter.Texts = $Org.id
                $query.var.filter += $orgFilter
            }

            if ($PSBoundParameters.ContainsKey('relic')) {
                $relicFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $relicFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_RELIC
                $relicFilter.Texts = $Relic
                $query.var.filter += $relicFilter
            }

            if ($PSBoundParameters.ContainsKey('replica')) {
                $replicaFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $replicaFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_REPLICATED
                $replicaFilter.Texts = $replica
                $query.var.filter += $replicaFilter
            }

            if ( $AsQuery ) { return $query }
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    }
}
