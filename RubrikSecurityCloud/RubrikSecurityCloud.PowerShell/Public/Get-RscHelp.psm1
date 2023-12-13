#Requires -Version 3
function Get-RscHelp {
    <#
    .SYNOPSIS
    Retrieve help around RSC cmdlets and the RSC schema.
    
    .DESCRIPTION
    This cmdlet is used to retrieve help around RSC cmdlets and the RSC schema.
    It can be used to retrieve help for a specific cmdlet,
    or to look up a schema element.
    but this cmdlet extracts just the subcommand help messages.

    .EXAMPLE
    Get-RscHelp -CommandName New-RscQueryCluster

    .EXAMPLE
    Get-RscHelp -Locations

    .EXAMPLE
    Get-RscHelp -LookupSchema clusterconnection
    Get-RscHelp -LookupSchema clustercon*
    
    #>
    [CmdletBinding(
        DefaultParameterSetName = 'Schema'
    )]
    Param (
        [Parameter(
            ParameterSetName = 'Locations',
            HelpMessage = 'Show File System locations the SDK uses.',
            Position = 0
        )]
        [Switch]$Locations,

        [Parameter(
            ParameterSetName = 'Schema',
            HelpMessage = 'Look up any symbol in the schema.',
            Position = 0
        )]
        [string]$Schema,

        [Parameter(
            ParameterSetName = 'Query',
            HelpMessage = 'Look up a query by name.',
            Position = 0
        )]
        [Switch]$Query,
    
        [Parameter(
            ParameterSetName = 'Interface',
            HelpMessage = 'Look up an interface by name.',
            Position = 0
        )]
        [Switch]$Interface,

        [Parameter(
            ParameterSetName = 'Input',
            HelpMessage = 'Look up an input by name.',
            Position = 0
        )]
        [Switch]$Inputs,

        [Parameter(
            ParameterSetName = 'Enum',
            HelpMessage = 'Look up an enum by name.',
            Position = 0
        )]
        [Switch]$Enum,

        [Parameter(
            HelpMessage = 'Regular expression to match',
            Position = 1
        )]
        [string]$Match = ""

    )
    Begin {
        function GetLocationHelp {
            Get-RscCmdlet -Locations
        }

        function LookupSchema {
            # Get all the enums within the SchemaMeta class
            $enums = [RubrikSecurityCloud.Types.SchemaMeta].GetNestedTypes() | Where-Object { $_.IsEnum -and $_.Name -ne 'GqlRootFieldName' }

            # Iterate through each enum and check if it contains the lookup name
            $found = 0
            foreach ($enum in $enums) {
                # Get all names in the current enum
                $enumNames = [Enum]::GetNames($enum) | Where-Object { $_ -ine 'Unknown' }
                # Check if any of the names match the provided pattern
                foreach ($n in $enumNames) {
                    if ($n -like $Match) {
                        # Extract the middle part of the enum name
                        $enumName = $enum.Name -replace '^Gql', '' -replace 'Name$', ''
                        Write-Output "${enumName}: $n"
                        $found += 1
                    }
                }
            }
            if ($found -eq 0) {
                Write-Output "No match found for '$Match'."
            }
            elseif ($found -gt 1) {
                Write-Output "${found} matches found for '$Match'."
            }
        }

        function LookupQuery {
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlQueryName])
            foreach ($value in $enumValues) {
                if ($value -eq 'Unknown') {
                    continue
                }
                # if it's an exact match, print query info
                if ( $value -eq $Match ) {
                    try {
                        $query = New-RscQuery -GqlQuery $value
                        $info = $query.Info()
                    }
                    catch {
                        $info = "Query $value is not supported."
                    }
                    Write-Output $info
                    continue
                }
                # print it if $Query is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    Write-Output $value
                }
            }
        }

        function LookupInterface {
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlInterfaceName])
            foreach ($value in $enumValues) {
                if ($value -eq 'Unknown') {
                    continue
                }
                # if it's an exact match, print interface info
                if ( $value -eq $Match ) {
                    try {
                        Write-Output "Types that implement interface ${value}:"
                        $info = Get-RscType -Interface $value
                    }
                    catch {
                        $info = "Interface $value is not supported."
                    }
                    Write-Output $info
                    continue
                }
                # print it if $Interface is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    Write-Output $value
                }
            }
        }

        function LookupInput {
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlInputName])
            foreach ($value in $enumValues) {
                if ($value -eq 'Unknown') {
                    continue
                }
                # print it if $Input is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    Write-Output $value
                }
            }
        }

        function LookupEnum {
            $enumValues = [Enum]::GetValues([RubrikSecurityCloud.Types.SchemaMeta+GqlEnumName])
            foreach ($value in $enumValues) {
                if ($value -eq 'Unknown') {
                    continue
                }
                # print it if $Enum is empty, or if it matches the pattern
                if ($Match -eq "" -or $value -like $Match) {
                    Write-Output $value
                }
            }
        }   

    }
    
    Process {
        if ($Match -ieq "Unknown") {
            Write-Output "Unknown"
            return
        }
        switch ($PSCmdlet.ParameterSetName) {
            'Locations' { GetLocationHelp }
            'Schema' { LookupSchema }
            'Query' { LookupQuery }
            'Interface' { LookupInterface }
            'Input' { LookupInput }
            'Enum' { LookupEnum }
        }
    }
}
