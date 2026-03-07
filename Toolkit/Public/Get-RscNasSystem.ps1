#Requires -Version 3
function Get-RscNasSystem {
    <#
    .SYNOPSIS
    Retrieves NAS systems managed by Rubrik Security Cloud.

    .DESCRIPTION
    Returns Network Attached Storage (NAS) systems added to RSC. You can list all
    systems, filter by name, or look up by ID. Pipe the output to Get-RscNasShare
    to list shares on a specific system.

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .PARAMETER Id
    The RSC object ID.

    .PARAMETER Name
    Filter by name. Matches systems whose name contains the specified string.

    .PARAMETER List
    Return all items. This is the default behavior.

    .PARAMETER AsQuery
    Return the query object instead of running the query.
    Preliminary read-only queries may still run to gather IDs or
    other data needed to build the main query.

Return the query object instead of executing it.

    .EXAMPLE
    # Get all NAS systems
    Get-RscNasSystem

    .EXAMPLE
    # Get a NAS system by name and list its shares
    Get-RscNasSystem -Name "netapp-01" | Get-RscNasShare

    .EXAMPLE
    # Get a specific NAS system by ID
    Get-RscNasSystem -Id "72859a28-6276-555a-9a66-d93fe99d2751"
    #>

    [CmdletBinding(
        DefaultParameterSetName = "List"
    )]
    Param(
        # The name of the NAS system to filter on.
        [Parameter(
            ParameterSetName = "Name",
            Mandatory = $false,
            Position = 0
        )]
        [ValidateNotNullOrEmpty()]
        [String]$Name,

        # The UUID of the object representing the NAS system.
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false
        )]
        [ValidateNotNullOrEmpty()]
        [String]$Id,
        
        # Retrieve list of NAS systems.
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )]
        [Switch]$List,

        # Should Cmdlet return the query object instead of running it
        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        Switch ($PSCmdlet.ParameterSetName) {
            "Id" {
                $query = New-RscQuery -Gql nasSystem `
                -RemoveField ObjectType `
                -AddField ShareCount, `
                OsVersion, `
                VendorType, `
                VolumeCount

                $query.Var.Fid = $Id
            }

            "Name" {
                $query = New-RscQuery -Gql nasSystems
                $query.Field.Nodes[0].VendorType = "FETCH"
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $InputObj.Field = "Name"
                $InputObj.Texts = @($Name)
                $query.Var.Filter = @($InputObj)
            }

            "List" {
                $query = New-RscQuery -Gql nasSystems
                $query.Field.Nodes[0].VendorType = "FETCH"
            }
        }
        
        if ( $AsQuery ) {
            return $query
        }

        $result = Invoke-Rsc -Query $query

        if ($PSCmdlet.ParameterSetName -eq "Name" -or $PSCmdlet.ParameterSetName -eq "List") {
            $result = $result.Nodes
        }

        $result | Remove-NullProperties
    }
}