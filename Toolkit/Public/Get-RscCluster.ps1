#Requires -Version 3
function Get-RscCluster {
    <#
    .SYNOPSIS
    Retrieves Rubrik clusters managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns Rubrik CDM clusters connected to RSC. By default returns a standard
    set of fields; use -Detail for additional properties. Use -Name to find a
    cluster by name, -Id for a specific cluster, or -Count to get just the total.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER List
    Return all items. This is the default behavior.

    .PARAMETER First
    Return only the first N results.

    .PARAMETER Count
    Return only the total count.

    .PARAMETER Id
    The RSC object ID.

    .PARAMETER Name
    Filter by name. Exact match on the cluster name.

    .PARAMETER Detail
    Return additional fields beyond the default set.

    .PARAMETER IncludeNullProperties
    Include fields with null values in the output.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

    .EXAMPLE
    Return a list of all clusters managed by RSC
    
    Get-RscCluster -List
    
    .EXAMPLE
    Return information about a cluster based on the name

Return the query object instead of executing it.

    .EXAMPLE
    # Get all clusters
    Get-RscCluster

    .EXAMPLE
    # Get a cluster by name
    Get-RscCluster -Name vault-r-london

    .EXAMPLE
    # Get cluster count
    Get-RscCluster -Count

    .EXAMPLE
    # Get a cluster with all fields including nulls
    Get-RscCluster -Name vault-r-london -Detail -IncludeNullProperties
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][Switch]$List,

        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true,
            HelpMessage = "Return only the first N clusters. Default is 0, which means use the default page size."
        )]
        [Int]$First = 0,

        [Parameter(
            ParameterSetName = "Count",
            Mandatory = $false,
            HelpMessage = "Return only the number of clusters"
        )]
        [Switch]$Count,

        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true,
            HelpMessage = "Return only the cluster with the specified id"
        )]
        [String]$Id,

        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false, 
            ValueFromPipeline = $false
        )][String]$Name,
        
        #  Common parameter to all parameter sets:

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false,
            HelpMessage = "Return more fields than the default field profile"
        )][Switch]$Detail,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false,
            HelpMessage = "Include fields that are null in the response"
        )][Switch]$IncludeNullProperties,

        [Parameter(
            Mandatory = $false, 
            ValueFromPipeline = $false,
            HelpMessage = "Return the query object instead of running the query"
        )][Switch]$AsQuery
    )
    
    Process {
        # Count clusters:
        if ( $PSCmdlet.ParameterSetName -eq "Count" ) {
            $query = New-RscQuery -Gql clusterConnection -RemoveField Nodes
            if ( $AsQuery ) {
                return $query
            }
            $r = $query.Invoke()
            # Object's 'Count' property is hidden by the 'Count' method
            # so we can't do `$r.Count`
            $clusterCount = $r | Select-Object -ExpandProperty Count
            return $clusterCount
        }

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Verbose "Get-RscCluster field profile: $fieldProfile"

        # Create Query
        switch ( $PSCmdlet.ParameterSetName ) {
            "List" {
                $query = New-RscQuery -Gql clusterConnection -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile -Var @{First = $First}
            }
            "Id" {
                $query = New-RscQuery -Gql clusterConnection -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
                $query.Var.filter = New-Object -TypeName RubrikSecurityCloud.Types.ClusterFilterInput
                $query.Var.filter.id = $Id
            }
            "Name" {
                $query = New-RscQuery -Gql clusterConnection -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
                $query.Var.filter = New-Object -TypeName RubrikSecurityCloud.Types.ClusterFilterInput
                $query.Var.filter.Name = $Name
            }
        }

        # Skip sending, return query object:
        if ( $AsQuery ) {
            return $query
        }

        # Invoke the query:
        $response = Invoke-Rsc $query

        # Filter results
        # the response's `Nodes` field contains the list
        if ($null -ne $response.Nodes) {
            $result = $response.Nodes
        }
        else {
            $result = $response
        }

        if ( $IncludeNullProperties -eq $true ) {
            $result
        }
        else {
            # Filter out null values:
            # fields that were not selected for retrieval
            # come back as nulls in the `$result` object,
            # so we filter them out here:
            $result | Remove-NullProperties
        }
    } 
}
