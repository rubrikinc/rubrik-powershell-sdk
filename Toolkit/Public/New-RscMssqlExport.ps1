#Requires -Version 3
function ___VERB___-Rsc___NOUN___ {
    <#
    .SYNOPSIS
    ___ Add synopsis here ___

    .DESCRIPTION
    ___ Add description here ___

    .LINK
    Schema reference:
    https://rubrikinc.github.io/rubrik-api-documentation/schema/reference

    .EXAMPLE
    ___ Add example here ___
    #>

    [CmdletBinding(
        # ___ Example ___
        DefaultParameterSetName = "Id"
    )]
    Param(
        # ___ Example ___
        # Id parameter set:
        [Parameter(
            ParameterSetName = "Id",
            Mandatory = $false, 
            ValueFromPipelineByPropertyName = $true
        )]
        [String]$Id,
        
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

        # Determine field profile:
        $fieldProfile = "DEFAULT"
        if ( $Detail -eq $true ) {
            $fieldProfile = "DETAIL"
        }
        Write-Host "___VERB___-Rsc___NOUN___: $fieldProfile"
        
        # ___ Example ___

        # Create query
        
        $vars = @{ someVar = someVal }

        if ( $PSCmdlet.ParameterSetName -eq "Id" ) {
            $vars.Id = $Id
        }
        
        $query = New-RscQuery___DOMAIN___ -___OPERATION___ -Var $vars -FieldProfile $fieldProfile
        
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
