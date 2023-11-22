#Requires -Version 3
function Get-RscCluster {
    <#
    .SYNOPSIS
    Retrieve info about clusters
    
    .DESCRIPTION
    By default, retrieve info about all clusters.
    By default, responses contain a minimal set of fields: mostly ids and names.
    To get more details, use the `-Detail` parameter.
    
    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference
    The ClusterConnection type:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html
    
    The Cluster type:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/cluster.doc.html
    
    .PARAMETER List
    Retrieve the list of clusters that are connected to Rubrik Securiry Cloud.
    This is the default parameter set.

    .PARAMETER Name
    Used to return a specific cluster based on the name

    .PARAMETER Detail
    Use the DETAIL field profile instead of the DEFAULT field profile.
    The DETAIL field profile returns more fields than the DEFAULT field profile.

    .PARAMETER IncludeNullProperties
    By default, fields will a NULL are not returned. Supplying this parameter will return all fields, including fields
    with a NULL in them. 

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.
    
    .EXAMPLE
    Return a list of all clusters managed by RSC
    
    Get-RscCluster -List
    
    .EXAMPLE
    Return a information about a cluster based on the name

    Get-RscCluster -Name vault-r-london
    
    
    .EXAMPLE
    Include the fields that are null in the response
    
    Get-RscCluster -Name vault-r-london -IncludeNullProperties

    .EXAMPLE
    Return back just the query that would run instead of running the query and returning the results

    Get-RscCluster -Name vault-r-london -AsQuery    
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
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Count clusters:
        if ( $PSCmdlet.ParameterSetName -eq "Count" ) {
            $r = (New-RscQueryCluster -Op List -RemoveField Nodes).Invoke()
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
                $query = New-RscQueryCluster -Operation List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
            }
            "Id" {
                $query = New-RscQueryCluster -Operation List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
                $query.Var.clusterUuid = $Id
            }
            "Name" {
                $query = New-RscQueryCluster -Operation List -RemoveField Nodes.isHealthy -FieldProfile $fieldProfile
                $query.Var.filter = New-Object -TypeName RubrikSecurityCloud.Types.ClusterFilterInput
                $query.Var.filter.Name = $Name
            }
        }

        # Skip sending, return query object:
        if ( $AsQuery ) {
            return $query
        }

        # Invoke the query:
        if ( $PSCmdlet.ParameterSetName -eq "List" ) {
            $response = Get-RscPages -Query $query -First $First
        }
        else {
            $response = Invoke-Rsc $query
        }

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
