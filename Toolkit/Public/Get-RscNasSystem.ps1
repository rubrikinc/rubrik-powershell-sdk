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

    .PARAMETER Name
    The name of the NAS system to filter on.

    .PARAMETER List
    Switch to list all NAS systems.

    .PARAMETER AsQuery
    Instead of running the command, the query object is returned.

    .EXAMPLE
    Retrieve list of NAS systems.
    Get-RscNasSystem
        or 
    Get-RscNasSystem -List
    
    .EXAMPLE
    Retrieve all NAS systems with the name containing "foo".
    Get-RscNasSystem -Name "foo"
        or
    Get-RscNasSystem "foo"

    .EXAMPLE
    Get details of NAS system with id="72859a28-6276-555a-9a66-d93fe99d2751"
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
                $query = New-RscQueryNas -Operation System `
                -RemoveField ObjectType `
                -AddField ShareCount, `
                OsVersion, `
                VendorType, `
                VolumeCount

                $query.Var.Fid = $Id
            }

            "Name" {
                $query = New-RscQueryNas -Operation Systems
                $query.Field.Nodes[0].VendorType = "FETCH"
                $InputObj = New-Object -TypeName RubrikSecurityCloud.Types.Filter
                $InputObj.Field = "Name"
                $InputObj.Texts = @($Name)
                $query.Var.Filter = @($InputObj)
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

        if ($PSCmdlet.ParameterSetName -eq "Name" -or $PSCmdlet.ParameterSetName -eq "List") {
            $result = $result.Nodes
        }

        $result | Remove-NullProperties
    }
}