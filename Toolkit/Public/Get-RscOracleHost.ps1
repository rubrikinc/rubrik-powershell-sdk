#Requires -Version 3
function Get-RscOracleHost {
    <#
    .SYNOPSIS
    Retrieves RscOracleHost objects protected by Rubrik Security Cloud

    .DESCRIPTION
    This cmdlet uses the GQL query 'oracleTopLevelDescendants' to retrieve a list of VMs with a predetermined set of properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all
    Get-RscOracleHost

    .EXAMPLE
    # Get object with specific name
    Get-RscOracleHost -Name "jake-001"

    .EXAMPLE
    # Get objects by specifying part of a name
    Get-RscOracleHost -Name "*jake*"
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
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
        [RubrikSecurityCloud.Types.Cluster]$Cluster
    )
    
    Process {
        $query = New-RscQuery -GqlQuery oracleTopLevelDescendants
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

        $result = Invoke-Rsc -Query $query
        $result.nodes
    } 
}

