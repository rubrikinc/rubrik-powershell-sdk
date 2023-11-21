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

    )]
    Param(
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Detail,
        [Parameter(
            Mandatory = $false
        )]
        [String]$Name,
        [Parameter(
            Mandatory = $false,
            ValueFromPipeline = $true
        )]
        [RubrikSecurityCloud.Types.GlobalSlaReply]$Sla
    )
    
    Process {

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }

        # Build the 'inputs' using -GetInput.
        # Rather than a cmdlet, This should be an object on which we can set field and object values.
        $query = New-RscQueryVsphereVm -Operation NewList -FieldProfile $inputProfile
        #$in = (Invoke-RscQueryVsphereVm -NewList -InputProfile $inputProfile -GetInput)
        $query.var.filter = @()

        if ($Name -ne "") {
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

        # Not sure why .Nodes is a list here, but it is.
        $query.Field.Nodes[0].Cluster = New-Object -TypeName RubrikSecurityCloud.Types.Cluster
        $query.Field.Nodes.Cluster.id = "PIZZA" # Could Fields be a version of the type structure that has all booleans to define what we get back?
        $query.field.Nodes[0].GuestOsName = "TACOS"
        $query.Field.Nodes[0].AgentStatus = New-Object -TypeName RubrikSecurityCloud.Types.AgentStatus
        $query.Field.Nodes[0].AgentStatus.AgentStatusField = New-object -typename RubrikSecurityCloud.Types.AgentConnectionStatus
        # Apparently we already get this through the "default" input profile? What else is in there?
        #$in.field.nodes[0].EffectiveSlaDomain.Name = "FETCH"

    $result = Get-RscPages { invoke-rsc $query }

    $result.nodes

    } 
}
