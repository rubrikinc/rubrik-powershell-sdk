#Requires -Version 3
function Get-RscVmwareVm {
    <#
    .SYNOPSIS
    Retrieves VMware VMs protected by Rubrik Security Cloud

    .DESCRIPTION
    This cmdlet uses the GQL query 'vsphereVmNewConnection' to retrieve a list of VMs with a predetermined set of properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all VMs
    Get-RscVmwareVm

    .EXAMPLE
    # Get VM with specific name
    Get-RscVmwareVm -Name "jake-001"

    .EXAMPLE
    # Get VMs by specifying part of a name
    Get-RscVmwareVm
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
        [RubrikSecurityCloud.Types.Org]$Org
    )
    
    Process {

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }

       # The query is different for getting a single object by ID.
        if ($Id) {
            #$query = New-RscQueryVsphereVm -Operation New -FieldProfile $inputProfile
            $query = New-RscQuery -GqlQuery vSphereVmNew -FieldProfile $inputProfile
            $query.var.filter = @()
            $query.Var.fid = $Id
            $query.Field.Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            $query.Field.Cluster.name = "PIZZA"
            $query.Field.Cluster.id = "PIZZA"
            $query.Field.GuestOsName = "TACOS"
            $query.Field.AgentStatus = New-Object -TypeName RubrikSecurityCloud.Types.AgentStatus
            $query.Field.AgentStatus.AgentStatusField = New-Object -typename RubrikSecurityCloud.Types.AgentConnectionStatus
            $query.Field.snapshotConsistencyMandate = [RubrikSecurityCloud.Types.ConsistencyLevelEnum]::CRASH_CONSISTENT
            $query.Field.allOrgs = New-Object RubrikSecurityCloud.Types.Org
            $query.Field.allOrgs[0].name = "FETCH"
            $query.Field.allOrgs[0].id = "FETCH"
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            #$query = New-RscQueryVsphereVm -Operation NewList -FieldProfile $inputProfile
            $query = New-RscQuery -GqlQuery vsphereVmNewConnection -FieldProfile $inputProfile
            $query.var.filter = @()
            $query.Field.Nodes[0].Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            $query.Field.Nodes[0].Cluster.name = "PIZZA"
            $query.Field.Nodes[0].Cluster.id = "PIZZA"
            $query.Field.Nodes[0].GuestOsName = "TACOS"
            $query.Field.Nodes[0].AgentStatus = New-Object -TypeName RubrikSecurityCloud.Types.AgentStatus
            $query.Field.Nodes[0].AgentStatus.AgentStatusField = New-Object -TypeName RubrikSecurityCloud.Types.AgentConnectionStatus
            $query.Field.Nodes[0].snapshotConsistencyMandate = [RubrikSecurityCloud.Types.ConsistencyLevelEnum]::CRASH_CONSISTENT
            $query.Field.Nodes[0].allOrgs = New-Object RubrikSecurityCloud.Types.Org
            $query.Field.Nodes[0].allOrgs[0].name = "FETCH"
            $query.Field.Nodes[0].allOrgs[0].id = "FETCH"
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

            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    } 
}
