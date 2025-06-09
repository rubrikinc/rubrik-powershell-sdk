#Requires -Version 3
function Get-RscMssqlLinkedAvailabilityGroup {
    <#
    .SYNOPSIS
    Retrieves linked MSSQL availability groups protected by Rubrik Security Cloud

    .DESCRIPTION
    This cmdlet uses the GQL query 'mssqlAvailabilityGroupVirtualGroups' to retrieve a list of linked MSSQL availability groups with a predetermined set of properties.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    # Get all linked availability groups
    Get-RscMssqlLinkedAvailabilityGroups

    .EXAMPLE
    # Get linked availability group with specific name
    Get-RscMssqlLinkedAvailabilityGroups -Name "jake-001"

    #>

    [CmdletBinding(
        DefaultParameterSetName = "Name"
    )]
    Param(
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
        
        # Returns API query object
        [Parameter()]
        [switch]$AsQuery
    )
    
    Process {

        $query = New-RscQuery -GqlQuery mssqlAvailabilityGroupVirtualGroups
        $query.var.filters = @()

        if ($Name) {
            $nameFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterInput
            $nameFilter.Field = [RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterField]::NAME
            $nameFilter.texts = $Name
            $query.var.filters += $nameFilter
        }

        if ($Sla) {
            $slaFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterInput
            $slaFilter.Field = [RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterField]::EFFECTIVE_SLA_WITH_RETENTION_SLA
            $slaFilter.Texts = $Sla.id
            $query.var.filters += $slaFilter
        }

        if ($Cluster) {
            $clusterFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterInput
            $clusterFilter.Field = [RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterField]::CLUSTER_UUID
            $clusterFilter.Texts = $Cluster.id
            $query.var.filters += $clusterFilter
        }

        if ($Org) {
            $orgFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterInput
            $orgFilter.Field = [RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterField]::ORG_ID
            $orgFilter.Texts = $Org.id
            $query.var.filters += $orgFilter
        }

        if ($PSBoundParameters.ContainsKey('relic')) {
            $relicFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterInput
            $relicFilter.Field = [RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterField]::IS_RELIC
            $relicFilter.Texts = $Relic
            $query.var.filters += $relicFilter
        }

        if ($PSBoundParameters.ContainsKey('replica')) {
            $replicaFilter = New-Object -TypeName RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterInput
            $replicaFilter.Field = [RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroupFilterField]::IS_REPLICATED
            $replicaFilter.Texts = $replica
            $query.var.filters += $replicaFilter
        }

        $query.Field.nodes = @(
            # Doesn't work. Get-RscType: Cannot dynamically create an instance of type 'System.String'. Reason: Uninitialized Strings cannot be created.
            # Get-RscType -Name MssqlAvailabilityGroupVirtualGroup -InitialProperties name,linkedFids
            New-Object -TypeName RubrikSecurityCloud.Types.MssqlAvailabilityGroupVirtualGroup
        )
        $query.Field.nodes[0].Name = "FETCH"
        $query.Field.Nodes[0].LinkedFids = @(1)
        $query.Field.nodes[0].Groups = Get-RscType -Name MssqlAvailabilityGroup -InitialProperties name,id


        if ($AsQuery.IsPresent) {
            return $query
        }
        else {
            $result = Invoke-Rsc -Query $query
            $result.nodes
        }

    } 
}
