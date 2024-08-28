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
        [switch]$ExactName = $false,
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Name"
        )]
        [switch]$Relic,
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
        [RubrikSecurityCloud.Types.Cluster]$Cluster
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
            $query.Field.Cluster.id = "PIZZA" # Could Fields be a version of the type structure that has all booleans to define what we get back?
            $query.Field.GuestOsName = "TACOS"
            $query.Field.AgentStatus = New-Object -TypeName RubrikSecurityCloud.Types.AgentStatus
            $query.Field.AgentStatus.AgentStatusField = New-Object -typename RubrikSecurityCloud.Types.AgentConnectionStatus
            $query.Field.snapshotConsistencyMandate = New-Object -TypeName [RubrikSecurityCloud.Types.ConsistencyLevelEnum]::CRASH_CONSISTENT
            $result = Invoke-Rsc -Query $query
            $result
        } else {
            #$query = New-RscQueryVsphereVm -Operation NewList -FieldProfile $inputProfile
            $query = New-RscQuery -GqlQuery vsphereVmNewConnection -FieldProfile $inputProfile
            $query.var.filter = @()
            $query.Field.Nodes[0].Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
            $query.Field.Nodes.Cluster.id = "PIZZA"
            $query.Field.Nodes[0].GuestOsName = "TACOS"
            $query.Field.Nodes[0].AgentStatus = New-Object -TypeName RubrikSecurityCloud.Types.AgentStatus
            $query.Field.Nodes[0].AgentStatus.AgentStatusField = New-Object -TypeName RubrikSecurityCloud.Types.AgentConnectionStatus
            $query.Field.Nodes[0].snapshotConsistencyMandate = [RubrikSecurityCloud.Types.ConsistencyLevelEnum]::CRASH_CONSISTENT
            if ($Name) {
                $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                # Regex filter doesn't work in the API right now, but we're going to play pretend. 
                # With real Regex, users could search for VMs that start with the letter A if they wanted.
                if ($name.Contains("*")) {
                    $name.Replace("*",'')
                    $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::REGEX
                    $nameFilter.texts = $Name.Replace("*",'')
                } elseif ($ExactName){
                    $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME_EXACT_MATCH
                    $nameFilter.texts = $Name
                } else {
                    $nameFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::NAME
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

            if ($PSBoundParameters.ContainsKey('relic')) {
                $relicFilter = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $relicFilter.Field = [RubrikSecurityCloud.Types.HierarchyFilterField]::IS_RELIC
                $relicFilter.Texts = $Relic
                $query.var.filter += $relicFilter
            }

            $result = Invoke-Rsc -Query $query
            $result.nodes
        }
    } 
}
