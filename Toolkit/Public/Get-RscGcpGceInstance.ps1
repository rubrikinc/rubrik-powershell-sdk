#Requires -Version 3
function Get-RscGcpGceInstance {
    <#
    .SYNOPSIS
    Retrieves GCP Compute Engine (GCE) instances managed by Rubrik Security Cloud

    .DESCRIPTION
    Returns GCP native GCE VM instances that are protected or inventoried by Rubrik.
    By default all instances are returned. Use -Name to filter by name or ID substring,
    -Sla to filter by effective SLA Domain, and -Relic to include or exclude relic
    (removed-from-cloud) instances. Use -Id to retrieve a single instance by its
    RSC object identifier.

    .LINK
    https://developer.rubrik.com/Rubrik-Security-Cloud-API/API-Reference/queries/gcpNativeGceInstances/

    .LINK
    https://developer.rubrik.com/Rubrik-Security-Cloud-API/API-Reference/queries/gcpNativeGceInstance/

    .PARAMETER Id
    The RSC object ID (UUID) of the GCE instance to retrieve.

    .PARAMETER Name
    Filter by name or ID substring. Matches instances whose name or native ID contains
    the specified string.

    .PARAMETER Sla
    An SLA Domain object to filter by effective SLA. Pipe from Get-RscSla.

    .PARAMETER Relic
    Filter by relic status. Pass $true to return only relics (instances removed from GCP
    but still tracked by Rubrik), or $false to exclude relics. Omit to return all instances.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or other data needed to build the main query.

    .EXAMPLE
    # List all GCE instances
    Get-RscGcpGceInstance

    .EXAMPLE
    # Find GCE instances whose name contains "prod"
    Get-RscGcpGceInstance -Name "prod"

    .EXAMPLE
    # Get a single GCE instance by RSC ID
    Get-RscGcpGceInstance -Id "11111111-2222-3333-4444-555555555555"

    .EXAMPLE
    # Get GCE instances protected by the Gold SLA
    Get-RscSla -Name "Gold" | Get-RscGcpGceInstance

    .EXAMPLE
    # Return the query object without executing it
    Get-RscGcpGceInstance -AsQuery
    #>

    [CmdletBinding(DefaultParameterSetName = "List")]
    Param(
        [Parameter(
            Mandatory = $false,
            ParameterSetName = "Id"
        )]
        [String]$Id,

        [Parameter(
            Position = 0,
            Mandatory = $false,
            ParameterSetName = "List"
        )]
        [String]$Name,

        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true,
            ParameterSetName = "List"
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla,

        [Parameter(
            Mandatory = $false,
            ParameterSetName = "List"
        )]
        [System.Nullable[bool]]$Relic,

        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        if ($PSCmdlet.ParameterSetName -eq "Id") {
            $query = New-RscQuery -Gql gcpNativeGceInstance
            $query.Var.fid = $Id

            $query.Field = New-Object RubrikSecurityCloud.Types.GcpNativeGceInstance
            $query.Field.Id = "FETCH"
            $query.Field.Name = "FETCH"
            $query.Field.Region = "FETCH"
            $query.Field.Zone = "FETCH"
            $query.Field.MachineType = "FETCH"
            $query.Field.ProjectId = "FETCH"
            $query.Field.VpcName = "FETCH"
            $query.Field.IsRelic = $true
            $sla = New-Object RubrikSecurityCloud.Types.GlobalSlaReply
            $sla.Id = "FETCH"
            $sla.Name = "FETCH"
            $query.Field.EffectiveSlaDomain = $sla

            if ($AsQuery) { return $query }
            $query.Invoke()
            return
        }

        $query = New-RscQuery -Gql gcpNativeGceInstances
        $query.Var.gceInstanceFilters = New-Object RubrikSecurityCloud.Types.GcpNativeGceInstanceFilters

        if ($Name) {
            $query.Var.gceInstanceFilters.NameOrIdSubstringFilter = New-Object RubrikSecurityCloud.Types.GcpNativeInstanceNameOrIdSubstringFilter
            $query.Var.gceInstanceFilters.NameOrIdSubstringFilter.NameOrIdSubstring = $Name
        }

        if ($Sla) {
            $query.Var.gceInstanceFilters.EffectiveSlaFilter = New-Object RubrikSecurityCloud.Types.EffectiveSlaFilter
            $query.Var.gceInstanceFilters.EffectiveSlaFilter.EffectiveSlaIds = @($Sla.Id)
        }

        if ($PSBoundParameters.ContainsKey('Relic')) {
            $query.Var.gceInstanceFilters.RelicFilter = New-Object RubrikSecurityCloud.Types.RelicFilter
            $query.Var.gceInstanceFilters.RelicFilter.Relic = $Relic
        }

        $node = New-Object RubrikSecurityCloud.Types.GcpNativeGceInstance
        $node.Id = "FETCH"
        $node.Name = "FETCH"
        $node.Region = "FETCH"
        $node.Zone = "FETCH"
        $node.MachineType = "FETCH"
        $node.ProjectId = "FETCH"
        $node.VpcName = "FETCH"
        $node.IsRelic = $true
        $sla = New-Object RubrikSecurityCloud.Types.GlobalSlaReply
        $sla.Id = "FETCH"
        $sla.Name = "FETCH"
        $node.EffectiveSlaDomain = $sla
        $query.Field.Nodes = @( $node )

        if ($AsQuery) { return $query }
        ($query.Invoke()).Nodes
    }
}
