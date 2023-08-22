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

        #  Common parameter to all parameter sets:
        [Parameter(
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [Switch]$Detail
    )
    
    Process {
        # Re-use existing connection, or create a new one:
        Connect-Rsc -ErrorAction Stop | Out-Null

        # Determine input profile:
        $inputProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $inputProfile = "DETAIL"
        }

        # -3- Retrieve pre-defined input objects:
        if ( $Id ) {
            $operation = "Cluster"
        }
        else {
            $operation = "List"
        }
        $in = (Invoke-RscQueryCluster -Op $operation -InputProfile $inputProfile -GetInput)

        # -4- Customize input objects:
        if ( $Id ) {
            $in.Var.clusterUuid = $Id
        }
        else {
            if ( $First -gt 0 ) {
                $in.Var.first = $First
            }
        }

        # -5- Invoke GraphQL operation:
        $result = Invoke-RscQueryCluster -Input $in

        # -6- Filter results:
        if ( $PSCmdlet.ParameterSetName -eq "List" ) {
            $result = $result.Nodes
        }

        # -7- Filter out null values:
        $result | Remove-NullProperties
    } 
}
