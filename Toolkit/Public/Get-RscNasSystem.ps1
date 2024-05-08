#Requires -Version 3
function Get-RscNasSystem {
    <#
    .SYNOPSIS
    Retrieves details of Nas Systems present in Rubrik Security Cloud.
    
    .DESCRIPTION
    Use this cmdlet to retrieve details of NAS Systems added to
    Rubrik Security Cloud (RSC).
    
    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference
    
    .PARAMETER Id
    The Rubrik UUID of the Nas System object.

    .PARAMETER First
    The number of NAS systems to retrieve in one query.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Get details of NAS system with id="72859a28-6276-555a-9a66-d93fe99d2751"
    Get-RscNasSystem "72859a28-6276-555a-9a66-d93fe99d2751"

    .EXAMPLE
    Retrieve list of NAS systems.
    Get-RscNasSystem -First 2
    #>

    [CmdletBinding(
        DefaultParameterSetName = "Id"
    )]
    Param(
        # The UUID of the object representing the NAS system.
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $true,
            Position = 0
        )]
        [ValidateNotNullOrEmpty()]
        [String]$Id,

        # The number of NAS systems to retrieve in one query.
        [Parameter(
            ParameterSetName = "List",
            Mandatory = $false
        )]
        [Int]$First = 50,

        # Should Cmdlet return the query object instead of running it
        [Parameter(Mandatory = $false)]
        [Switch]$AsQuery
    )

    Process {
        Switch ($PSCmdlet.ParameterSetName) {
            "Id" {
                $query = New-RscQueryNas -Operation System `
                -RemoveField ObjectType `
                -AddField ShareCount, `
                OsVersion, `
                VendorType, `
                VolumeCount

                $query.Var.Fid = $Id
            }
            "List" {
                $query = New-RscQueryNas -Operation Systems
                
                $query.Field.Nodes[0].VendorType = "FETCH"
            }
        }
        
        if ( $AsQuery ) {
            return $query
        }

        $result = Invoke-Rsc -Query $query

        if ($PSCmdlet.ParameterSetName -eq "List") {
            $result = $result.Nodes
        }

        $result | Remove-NullProperties
    }
}