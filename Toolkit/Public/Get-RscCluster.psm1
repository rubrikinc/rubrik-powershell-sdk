#Requires -Version 3
function Get-RscCluster {
    <#
    .SYNOPSIS
    Retrieve info about clusters

    .DESCRIPTION
    By default, retrieve info about all clusters.
    `Get-RscCluster` defaults to `Get-RscCluster -List -First 1000`
    which returns the first 1000 clusters.

    To get info about a specific cluster, use the `-Id` parameter.

    By default, responses contain a minimal set of fields: mostly ids and names.
    To get more details, use the `-Detail` parameter.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    The ClusterConnection type:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/clusterconnection.doc.html
    
    The Cluster type:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference/cluster.doc.html

    .EXAMPLE
    Get-RscCluster -First 3
    Id                                   Name            Type
    --                                   ----            ----
    1eb06571-e013-49b2-a635-33c309c5227a test-brik01    POLARIS
    2f6c2b76-df80-400b-ad9e-53a67203cbbc test-brik02    POLARIS
    3b429c53-21fe-44b5-b4e4-e3a4308a69fe test-brik03    POLARIS

    This example lists the first 3 clusters.

    .EXAMPLE
    (Get-RscCluster -First 3).Id
    1eb06571-e013-49b2-a635-33c309c5227a
    2f6c2b76-df80-400b-ad9e-53a67203cbbc
    3b429c53-21fe-44b5-b4e4-e3a4308a69fe
    
    This example lists the first 3 clusters, and only get their ids.

    .EXAMPLE
    $firstId = (Get-RscCluster -First 1).Id

    Saves the first id.

    .EXAMPLE
    Get-RscCluster -Id $firstId

    Retrieves a cluster by id.

    .EXAMPLE
    Get-RscCluster -Id $firstId -Detail
    EncryptionEnabled  : False
    EstimatedRunway    : -1
    Id                 : 1eb06571-e013-49b2-a635-33c309c5227a
    IsHealthy          : True
    Name               : test-brik01
    NoSqlWorkloadCount : 0
    RegistrationTime   : 4/13/2023 2:51:55 AM
    SnapshotCount      : -1
    Version            : 8.0.2-p2-22662
    LicensedProducts   : {}
    PauseStatus        : UNKNOWN
    ProductType        : POC
    Status             : DISCONNECTED
    SubStatus          : DEFAULT
    SystemStatus       : OK
    Type               : POLARIS

    Retrieves a cluster by id, with details.

    .EXAMPLE
    $query = Get-RscCluster -First 1 -AsQuery
    $query = New-RscQuery -Copy $query -AddField Nodes.SnapshotCount
    $query | Invoke-Rsc

    Amends a query object to add a field, and sends it.
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        # Id parameter set: show cluster from id
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$Id,
        
        # List parameter set: list clusters
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$List,

        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Int]$First = 1000,
        
        [Parameter(
            ParameterSetName = "Count",
            Mandatory = $false,
            HelpMessage = "Return only the number of clusters"
        )]
        [Switch]$Count,

        # Available for -List and -Id
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false 
        )]
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false
        )]
        [Switch]$Detail,

        [Parameter(
            Mandatory = $false
        )]
        [Switch]$AsQuery
    )
    
    Process {
        # Re-use existing connection, or create a new one
        Connect-Rsc -ErrorAction Stop | Out-Null

        if ( $PSCmdlet.ParameterSetName -eq "Count" ) {
            $r = (New-RscQueryCluster -Op List -RemoveField Nodes).Invoke()
            # Object's 'Count' property is hidden by the 'Count' method
            # so we can't do `$r.Count`
            $clusterCount = $r | Select-Object -ExpandProperty Count
            return $clusterCount
        }

        # Pick a field profile
        # (that says what fields to select for retrieval)
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }

        # API Domain: Cluster
        # API Operation: Cluster or List
        if ( $Id ) {
            $operation = "Cluster"
        }
        else {
            $operation = "List"
        }

        # Create query
        $vars = @{}
        if ( $Id ) {
            $vars.clusterUuid = $Id
        }
        else {
            if ( $First -gt 0 ) {
                $vars.first = $First
            }
        }
        $query = New-RscQueryCluster -Op $operation -Var $vars -FieldProfile $fieldProfile

        # Skip sending, return query object
        if ( $AsQuery ) {
            return $query
        }

        # Send request to the API server
        $result = Invoke-Rsc $query

        # Filter results
        # the response's `Nodes` field contains the list
        if ( $PSCmdlet.ParameterSetName -eq "List" ) {
            $result = $result.Nodes
        }

        # Filter out null values:
        # fields that weren't requested
        # come back as nulls in the `$result` object,
        # but that's not interesting to display
        $result | Remove-NullProperties
    } 
}
